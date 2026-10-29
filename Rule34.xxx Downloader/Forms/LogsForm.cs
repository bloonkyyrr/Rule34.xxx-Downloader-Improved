using R34Downloader.Services;
using System;
using System.Windows.Forms;

namespace R34Downloader.Forms
{
    /// <summary>
    /// Download logs viewer form.
    /// </summary>
    public partial class LogsForm : Form
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the LogsForm class.
        /// </summary>
        public LogsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Handlers

        private void LogsForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            RefreshLogs();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLogs();
        }

        private void buttonClearLogs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all logs?", "Clear Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DownloadLogService.ClearLogs();
                RefreshLogs();
                labelStatus.Text = "Logs cleared.";
            }
        }

        #endregion

        #region Methods

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            // ID Column
            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                FillWeight = 75
            };
            dataGridView1.Columns.Add(idColumn);

            // Type Column
            var typeColumn = new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                DataPropertyName = "Type",
                FillWeight = 70
            };
            dataGridView1.Columns.Add(typeColumn);

            // Status Column
            var statusColumn = new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                FillWeight = 75
            };
            dataGridView1.Columns.Add(statusColumn);

            // Duration Column
            var durationColumn = new DataGridViewTextBoxColumn
            {
                Name = "Duration",
                HeaderText = "Duration (s)",
                DataPropertyName = "Duration",
                FillWeight = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" }
            };
            dataGridView1.Columns.Add(durationColumn);

            var sizeColumn = new DataGridViewTextBoxColumn
            {
                Name = "FileSizeMB",
                HeaderText = "Size (MB)",
                DataPropertyName = "FileSizeMB",
                FillWeight = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" }
            };
            dataGridView1.Columns.Add(sizeColumn);

            // Timestamp Column
            var timestampColumn = new DataGridViewTextBoxColumn
            {
                Name = "Timestamp",
                HeaderText = "Timestamp",
                DataPropertyName = "Timestamp",
                FillWeight = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm:ss" }
            };
            dataGridView1.Columns.Add(timestampColumn);

            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "Status")
                {
                    return;
                }

                var status = Convert.ToString(e.Value);
                if (string.Equals(status, "Downloaded", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = UiTheme.Good;
                }
                else if (string.Equals(status, "Failed", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 125, 132);
                }
                else
                {
                    e.CellStyle.ForeColor = UiTheme.Muted;
                }
            };
        }

        private void RefreshLogs()
        {
            try
            {
                var logs = DownloadLogService.GetAllLogs();
                dataGridView1.DataSource = logs;

                labelLogCount.Text = logs.Count.ToString("N0") + (logs.Count == 1 ? " entry" : " entries");
                labelStatus.Text = "History updated.";
            }
            catch (Exception ex)
            {
                labelStatus.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
