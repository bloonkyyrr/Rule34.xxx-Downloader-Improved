using R34Downloader.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Xml;

namespace R34Downloader.Services
{
    /// <summary>
    /// API parsing service.
    /// </summary>
    public static class R34ApiService
    {
        #region Fields

        private const string ApiUrl = "https://api.rule34.xxx/index.php?page=dapi&s=post&q=index";
        private const byte PageSize = 100;
        private const int MaxRequestAttempts = 5;

        private static readonly CookieContainer CookieContainer;
        private static readonly HttpClient Client;

        #endregion

        #region Constructors

        static R34ApiService()
        {
            CookieContainer = new CookieContainer();
            CookieContainer.Add(new Cookie("gdpr", "1", "/", ".rule34.xxx"));
            CookieContainer.Add(new Cookie("gdpr-consent", "1", "/", ".rule34.xxx"));

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = CookieContainer,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            Client = new HttpClient(handler);
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36");
            Client.DefaultRequestHeaders.Referrer = new Uri("https://rule34.xxx/");
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the amount of content for the given tags.
        /// </summary>
        /// <param name="tags">Tags.</param>
        /// <returns>Content count.</returns>
        public static int GetContentCount(string tags)
        {
            var document = new XmlDocument();
            
            for (int attempt = 1; attempt <= 3; attempt++)
            {
                try
                {
                    var response = GetStringWithRetry(GetAuthenticatedUrl($"{ApiUrl}&tags={tags}"));
                    document.LoadXml(response);

                    if (document.DocumentElement?.Name == "error")
                    {
                        throw new Exception(document.DocumentElement.InnerText);
                    }
                    break;
                }
                catch (Exception)
                {
                    if (attempt == 3) throw;
                    Thread.Sleep(500 * attempt);
                }
            }

            return int.TryParse(document.DocumentElement?.Attributes[0].Value, out var count) ? count : default;
        }

        /// <summary>
        /// Downloads the specified content in the specified quantity.
        /// </summary>
        /// <param name="path">Path to save files.</param>
        /// <param name="tags">Tags.</param> 
        /// <param name="quantity">Quantity.</param>
        /// <param name="progress"><see cref="IProgress{T}"/></param>
        /// <param name="progress2"><see cref="IProgress{T}"/></param>
        public static void DownloadContent(string path, string tags, ushort quantity, IProgress<int> progress, IProgress<int> progress2)
        {
            var maxPid = quantity <= PageSize ? 1 : quantity % PageSize == 0 ? quantity / PageSize - 1 : quantity / PageSize;

            for (var pid = 0; pid <= maxPid; pid++)
            {
                DownloadControlService.WaitIfPaused();

                var doc = new XmlDocument();
                
                for (int attempt = 1; attempt <= 3; attempt++)
                {
                    try
                    {
                        var response = GetStringWithRetry(GetAuthenticatedUrl($"{ApiUrl}&tags={tags}&pid={pid}"));
                        doc.LoadXml(response);

                        if (doc.DocumentElement?.Name == "error")
                        {
                            throw new Exception(doc.DocumentElement.InnerText);
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        if (attempt == 3) throw;
                        Thread.Sleep(500 * attempt);
                    }
                }

                var postCount = quantity - pid * PageSize < PageSize ? quantity - pid * PageSize : PageSize;
                for (var i = 0; i < postCount; i++)
                {
                    DownloadControlService.WaitIfPaused();

                    var url = doc.DocumentElement?.ChildNodes[i].Attributes?.GetNamedItem("file_url")?.Value;
                    var fileExtension = Path.GetExtension(url);
                    var id = doc.DocumentElement?.ChildNodes[i].Attributes?.GetNamedItem("id")?.Value;
                    var filename = id + fileExtension;

                    // Skip posts that include any tags listed in Settings.
                    var tagsAttribute = doc.DocumentElement?.ChildNodes[i].Attributes?.GetNamedItem("tags")?.Value;
                    if (!string.IsNullOrEmpty(tagsAttribute) && TagBlacklistService.ContainsBlacklistedTags(tagsAttribute))
                    {
                        var skippedStatus = pid * 100 + i + 1;
                        progress.Report(skippedStatus);
                        progress2.Report(skippedStatus);
                        continue;
                    }

                    if (url != null)
                    {
                        if ((fileExtension == ".mp4" || fileExtension == ".webm") && SettingsModel.Video)
                        {
                            var sampleUrl = doc.DocumentElement?.ChildNodes[i].Attributes?.GetNamedItem("sample_url")?.Value ?? url;
                            DownloadService.Download(sampleUrl, Path.Combine(path, "Video", filename), id, "Video");
                        }
                        else if (fileExtension == ".gif" && SettingsModel.Gif)
                        {
                            DownloadService.Download(url, Path.Combine(path, "Gif", filename), id, "Gif");
                        }
                        else if (fileExtension != ".mp4" && fileExtension != ".webm" && fileExtension != ".gif" && SettingsModel.Images)
                        {
                            DownloadService.Download(url, Path.Combine(path, "Images", filename), id, "Image");
                        }
                    }

                    var reportStatus = pid * 100 + i + 1;
                    progress.Report(reportStatus);
                    progress2.Report(reportStatus);
                }
            }
        }

        private static string GetAuthenticatedUrl(string url)
        {
            var authenticatedUrl = url;

            if (!string.IsNullOrEmpty(SettingsModel.UserId))
            {
                authenticatedUrl += $"&user_id={SettingsModel.UserId}";
            }

            if (!string.IsNullOrEmpty(SettingsModel.ApiKey))
            {
                authenticatedUrl += $"&api_key={SettingsModel.ApiKey}";
            }

            return authenticatedUrl;
        }

        private static string GetStringWithRetry(string url)
        {
            for (var attempt = 1; attempt <= MaxRequestAttempts; attempt++)
            {
                using (var response = Client.GetAsync(url).GetAwaiter().GetResult())
                {
                    if ((int)response.StatusCode == 429 && attempt < MaxRequestAttempts)
                    {
                        Thread.Sleep(GetRetryDelay(response, attempt));
                        continue;
                    }

                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }
            }

            throw new HttpRequestException("The Rule34 API request failed after repeated rate limits.");
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

            return 1000 * (int)Math.Pow(2, attempt - 1);
        }

        #endregion
    }
}
