using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using R34Downloader.Models;

namespace R34Downloader.Services
{
    /// <summary>
    /// Download service.
    /// </summary>
    public static class DownloadService
    {
        #region Fields

        private static readonly CookieContainer CookieContainer;
        private static readonly HttpClient Client;

        /// <summary>
        /// Action to report download progress (downloaded MB, total MB).
        /// </summary>
        public static Action<double, double> OnDownloadProgress { get; set; }

        #endregion

        #region Constructors

        static DownloadService()
        {
            CookieContainer = new CookieContainer();

            // Standard GDPR cookies
            CookieContainer.Add(new Cookie("gdpr", "1", "/", ".rule34.xxx"));
            CookieContainer.Add(new Cookie("gdpr-consent", "1", "/", ".rule34.xxx"));

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = CookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            Client = new HttpClient(handler);
            Client.Timeout = TimeSpan.FromSeconds(300); // 5 minute timeout for large files
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36");
            Client.DefaultRequestHeaders.Referrer = new Uri("https://rule34.xxx/");
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");

            // Optimization for many connections
            ServicePointManager.DefaultConnectionLimit = 10;
            ServicePointManager.Expect100Continue = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Downloads and saves a file at the specified path.
        /// Skips the download when a file already exists at the target path.
        /// </summary>
        /// <param name="url">File url.</param>
        /// <param name="filePath">File path with name.</param>
        public static void Download(string url, string filePath)
        {
            Download(url, filePath, null, null);
        }

        /// <summary>
        /// Downloads and saves a file at the specified path with logging.
        /// Skips the download when a file already exists at the target path.
        /// </summary>
        /// <param name="url">File url.</param>
        /// <param name="filePath">File path with name.</param>
        /// <param name="id">Media ID for logging.</param>
        /// <param name="type">Media type (Video, Image, Gif) for logging.</param>
        public static void Download(string url, string filePath, string id, string type)
        {
            DownloadControlService.WaitIfPaused();

            var stopwatch = Stopwatch.StartNew();
            var temporaryFilePath = filePath + ".download";
            string status = "Downloaded";
            double fileSizeMB = 0;
            bool shouldLog = true;

            try
            {
                if (File.Exists(filePath))
                {
                    stopwatch.Stop();
                    if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(type))
                    {
                        DownloadLogService.AddLog(id, type, "Skipped", stopwatch.Elapsed.TotalSeconds, 0);
                    }
                    shouldLog = false;
                    return;
                }

                var directory = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Keep retrying transient network failures until the connection returns.
                // Each attempt starts a fresh temporary file so partial downloads are never
                // mistaken for complete files on a later run.
                for (int attempt = 1; ; attempt++)
                {
                    DownloadControlService.WaitIfPaused();

                    try
                    {
                        using (var response = Client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).Result)
                        {
                            var statusCode = (int)response.StatusCode;
                            if (statusCode == 429 || statusCode == 408 || statusCode >= 500)
                            {
                                DownloadControlService.ReportRetry("Temporary media request issue; retrying...");
                                var retryDelay = statusCode == 429
                                    ? GetRetryDelay(response, attempt)
                                    : GetNetworkRetryDelay(attempt);
                                response.Dispose();
                                PauseAwareDelay(retryDelay);
                                continue;
                            }

                            if (!response.IsSuccessStatusCode)
                            {
                                status = "Failed";
                                break;
                            }

                            // Get content length from headers
                            long? contentLength = response.Content.Headers.ContentLength;

                            // Check file size limit before downloading
                            if (contentLength.HasValue && contentLength.Value > 0)
                            {
                                double fileSizeMBCheck = contentLength.Value / (1024.0 * 1024.0);

                                // If file size limit is enabled and file exceeds limit, skip it
                                if (SettingsModel.EnableFileSizeLimit && SettingsModel.MaxFileSizeMB > 0 && fileSizeMBCheck > SettingsModel.MaxFileSizeMB)
                                {
                                    // Skipped oversized files still issue a request, so pace them too.
                                    PauseAwareDelay(500);
                                    stopwatch.Stop();
                                    if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(type))
                                    {
                                        DownloadLogService.AddLog(id, type, "Skipped", stopwatch.Elapsed.TotalSeconds, fileSizeMBCheck);
                                    }
                                    shouldLog = false;
                                    return;
                                }
                            }

                            // Stream to a temporary file so interrupted transfers can be retried safely.
                            using (var contentStream = ReadResponseStream(response.Content))
                            using (var fileStream = new FileStream(temporaryFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 8192, useAsync: false))
                            {
                                long downloadedBytes = 0;
                                byte[] buffer = new byte[8192];
                                int bytesRead;

                                while (true)
                                {
                                    try
                                    {
                                        bytesRead = contentStream.Read(buffer, 0, buffer.Length);
                                    }
                                    catch (Exception ex)
                                    {
                                        // Errors while reading this response stream are network
                                        // interruptions; file-write errors remain non-retryable.
                                        if (IsTransientNetworkException(ex) || ContainsIOException(ex))
                                        {
                                            throw new RetryableDownloadException(ex);
                                        }

                                        throw;
                                    }

                                    if (bytesRead == 0)
                                    {
                                        break;
                                    }

                                    DownloadControlService.WaitIfPaused();
                                    fileStream.Write(buffer, 0, bytesRead);
                                    downloadedBytes += bytesRead;

                                    // Report progress when the server supplies a total size.
                                    if (contentLength.HasValue && contentLength.Value > 0)
                                    {
                                        double downloadedMB = downloadedBytes / (1024.0 * 1024.0);
                                        double totalMB = contentLength.Value / (1024.0 * 1024.0);
                                        OnDownloadProgress?.Invoke(downloadedMB, totalMB);
                                    }
                                }

                                if (contentLength.HasValue && downloadedBytes != contentLength.Value)
                                {
                                    throw new RetryableDownloadException(
                                        new IOException("The response ended before the complete file was received."));
                                }

                                fileSizeMB = downloadedBytes / (1024.0 * 1024.0);
                            }

                            File.Move(temporaryFilePath, filePath);
                            status = "Downloaded";
                            // Keep consecutive downloads and skipped oversized files from flooding the host.
                            PauseAwareDelay(500);
                            break; // Success
                        }
                    }
                    catch (Exception ex)
                    {
                        if (IsTransientNetworkException(ex))
                        {
                            DownloadControlService.ReportRetry("Temporary media request issue; retrying...");
                            PauseAwareDelay(GetNetworkRetryDelay(attempt));
                        }
                        else
                        {
                            status = "Failed";
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                status = "Failed";
            }
            finally
            {
                if (!string.Equals(status, "Downloaded", StringComparison.Ordinal) && File.Exists(temporaryFilePath))
                {
                    try
                    {
                        File.Delete(temporaryFilePath);
                    }
                    catch (IOException)
                    {
                        // A leftover temporary file is harmless; it is never treated as complete.
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Preserve the original download result if cleanup is not permitted.
                    }
                }

                stopwatch.Stop();
                if (shouldLog && !string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(type))
                {
                    DownloadLogService.AddLog(id, type, status, stopwatch.Elapsed.TotalSeconds, fileSizeMB);
                }
            }
        }

        private static void PauseAwareDelay(int milliseconds)
        {
            var elapsed = 0;
            while (elapsed < milliseconds)
            {
                DownloadControlService.WaitIfPaused();
                var step = Math.Min(100, milliseconds - elapsed);
                System.Threading.Thread.Sleep(step);
                elapsed += step;
            }
        }

        private static int GetRetryDelay(HttpResponseMessage response, int attempt)
        {
            var retryAfter = response.Headers.RetryAfter;
            if (retryAfter?.Delta != null)
            {
                return (int)Math.Min(retryAfter.Delta.Value.TotalMilliseconds, int.MaxValue);
            }

            if (retryAfter?.Date != null)
            {
                return (int)Math.Max(0, Math.Min((retryAfter.Date.Value - DateTimeOffset.UtcNow).TotalMilliseconds, int.MaxValue));
            }

            return GetNetworkRetryDelay(attempt);
        }

        private static int GetNetworkRetryDelay(int attempt)
        {
            // Back off to 30 seconds, then keep checking at that interval.
            var exponent = Math.Min(Math.Max(attempt - 1, 0), 5);
            return Math.Min(1000 * (int)Math.Pow(2, exponent), 30000);
        }

        private static bool IsTransientNetworkException(Exception exception)
        {
            for (var current = exception; current != null; current = current.InnerException)
            {
                if (current is RetryableDownloadException ||
                    current is HttpRequestException ||
                    current is System.Threading.Tasks.TaskCanceledException)
                {
                    return true;
                }

                var webException = current as WebException;
                if (webException != null)
                {
                    if (webException.Status != WebExceptionStatus.ProtocolError ||
                        IsTransientHttpStatus(webException.Response as HttpWebResponse))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool IsTransientHttpStatus(HttpWebResponse response)
        {
            if (response == null)
            {
                return false;
            }

            var statusCode = (int)response.StatusCode;
            return statusCode == 408 || statusCode == 429 || statusCode >= 500;
        }

        private static Stream ReadResponseStream(HttpContent content)
        {
            try
            {
                return content.ReadAsStreamAsync().Result;
            }
            catch (Exception ex)
            {
                if (IsTransientNetworkException(ex) || ContainsIOException(ex))
                {
                    throw new RetryableDownloadException(ex);
                }

                throw;
            }
        }

        private static bool ContainsIOException(Exception exception)
        {
            for (var current = exception; current != null; current = current.InnerException)
            {
                if (current is IOException)
                {
                    return true;
                }
            }

            return false;
        }

        private sealed class RetryableDownloadException : Exception
        {
            public RetryableDownloadException(Exception innerException)
                : base("The file transfer was interrupted.", innerException)
            {
            }
        }

        #endregion
    }
}
