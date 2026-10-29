namespace R34Downloader.Forms
{
    partial class LogsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = UiTheme.CreateButton("Refresh");
            this.buttonClearLogs = UiTheme.CreateButton("Clear logs");
            this.labelLogCount = UiTheme.CreateLabel("0 entries", 9F, true);
            this.labelStatus = UiTheme.CreateLabel("Ready", 9F, false, UiTheme.Muted);

            var root = new System.Windows.Forms.TableLayoutPanel();
            var header = new System.Windows.Forms.TableLayoutPanel();
            var heading = new System.Windows.Forms.Panel();
            var title = UiTheme.CreateLabel("Download history", 20F, true);
            var subtitle = UiTheme.CreateLabel("A record of completed, skipped, and failed files.", 9F, false, UiTheme.Muted);
            var gridCard = UiTheme.CreateCard();
            var footer = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            root.BackColor = UiTheme.Canvas;
            root.Dock = System.Windows.Forms.DockStyle.Fill;
            root.Padding = new System.Windows.Forms.Padding(20);
            root.ColumnCount = 1;
            root.RowCount = 3;
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));

            header.BackColor = UiTheme.Canvas;
            header.Dock = System.Windows.Forms.DockStyle.Fill;
            header.ColumnCount = 2;
            header.RowCount = 1;
            header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            heading.BackColor = UiTheme.Canvas;
            heading.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Location = new System.Drawing.Point(0, 0);
            subtitle.Location = new System.Drawing.Point(1, 34);
            heading.Controls.Add(title);
            heading.Controls.Add(subtitle);
            this.labelLogCount.AutoSize = false;
            this.labelLogCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            header.Controls.Add(heading, 0, 0);
            header.Controls.Add(this.labelLogCount, 1, 0);

            gridCard.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            gridCard.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = UiTheme.Surface;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = UiTheme.Border;
            this.dataGridView1.DefaultCellStyle.BackColor = UiTheme.Surface;
            this.dataGridView1.DefaultCellStyle.ForeColor = UiTheme.Text;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(92, 48, 72);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = UiTheme.Raised;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = UiTheme.Text;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = UiTheme.Raised;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = UiTheme.Muted;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            gridCard.Controls.Add(this.dataGridView1);

            footer.BackColor = UiTheme.Canvas;
            footer.Dock = System.Windows.Forms.DockStyle.Fill;
            footer.ColumnCount = 3;
            footer.RowCount = 1;
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.labelStatus.AutoSize = false;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Size = new System.Drawing.Size(108, 42);
            this.buttonClearLogs.Size = new System.Drawing.Size(118, 42);
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClearLogs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonClearLogs.Click += new System.EventHandler(this.buttonClearLogs_Click);
            footer.Controls.Add(this.labelStatus, 0, 0);
            footer.Controls.Add(this.buttonRefresh, 1, 0);
            footer.Controls.Add(this.buttonClearLogs, 2, 0);

            root.Controls.Add(header, 0, 0);
            root.Controls.Add(gridCard, 0, 1);
            root.Controls.Add(footer, 0, 2);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = UiTheme.Canvas;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(root);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download history";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClearLogs;
        private System.Windows.Forms.Label labelLogCount;
        private System.Windows.Forms.Label labelStatus;
    }
}
