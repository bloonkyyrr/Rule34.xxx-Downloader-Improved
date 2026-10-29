namespace R34Downloader.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = UiTheme.CreateButton("Search");
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = UiTheme.CreateButton("Download", true);
            this.buttonPauseResume = UiTheme.CreateButton("Pause");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = UiTheme.CreateButton("About");
            this.button4 = UiTheme.CreateButton("Tag syntax");
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.buttonSettings = UiTheme.CreateButton("Settings");
            this.labelModeValue = UiTheme.CreateLabel("Official API", 10F, true, UiTheme.Good);
            this.labelFileLimitValue = UiTheme.CreateLabel("No file size cap", 10F, true);
            this.labelBlacklistValue = new System.Windows.Forms.Label();

            var root = new System.Windows.Forms.TableLayoutPanel();
            var header = new System.Windows.Forms.Panel();
            var brandMark = new System.Windows.Forms.Panel();
            var brandMarkText = UiTheme.CreateLabel("34", 13F, true, System.Drawing.Color.White);
            var title = UiTheme.CreateLabel("Rule34.xxx Downloader", 16F, true);
            var subtitle = UiTheme.CreateLabel("Search, filter, and save media", 9F, false, UiTheme.Muted);
            var content = new System.Windows.Forms.TableLayoutPanel();
            var searchCard = UiTheme.CreateCard();
            var searchLayout = new System.Windows.Forms.TableLayoutPanel();
            var searchTitle = UiTheme.CreateLabel("Find your next download", 20F, true);
            var searchSubtitle = UiTheme.CreateLabel("Use the same tags and filters you use on Rule34.xxx.", 9F, false, UiTheme.Muted);
            var queryLabel = UiTheme.CreateLabel("SEARCH TAGS", 8.5F, true, UiTheme.Muted);
            var queryHint = new System.Windows.Forms.Label();
            var actions = new System.Windows.Forms.FlowLayoutPanel();
            var utilities = new System.Windows.Forms.FlowLayoutPanel();
            var profileCard = UiTheme.CreateCard();
            var profileLayout = new System.Windows.Forms.TableLayoutPanel();
            var profileTitle = UiTheme.CreateLabel("DOWNLOAD PROFILE", 9F, true, UiTheme.Muted);
            var profileSubtitle = UiTheme.CreateLabel("Your current filters at a glance.", 9F, false, UiTheme.Muted);
            var sourceLabel = UiTheme.CreateLabel("Search source", 8.5F, false, UiTheme.Muted);
            var sizeLabel = UiTheme.CreateLabel("File size limit", 8.5F, false, UiTheme.Muted);
            var blacklistLabel = UiTheme.CreateLabel("Excluded tags", 8.5F, false, UiTheme.Muted);
            var profileNote = new System.Windows.Forms.Label();

            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // Main window shell
            root.BackColor = UiTheme.Canvas;
            root.ColumnCount = 1;
            root.RowCount = 3;
            root.Dock = System.Windows.Forms.DockStyle.Fill;
            root.Padding = new System.Windows.Forms.Padding(18);
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));

            // Header
            header.BackColor = UiTheme.Surface;
            header.Dock = System.Windows.Forms.DockStyle.Fill;
            header.Size = new System.Drawing.Size(1044, 72);
            header.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
            brandMark.BackColor = UiTheme.Accent;
            brandMark.Location = new System.Drawing.Point(18, 15);
            brandMark.Size = new System.Drawing.Size(42, 42);
            brandMarkText.Location = new System.Drawing.Point(7, 10);
            brandMarkText.ForeColor = System.Drawing.Color.White;
            title.Location = new System.Drawing.Point(74, 12);
            subtitle.Location = new System.Drawing.Point(75, 39);
            this.buttonSettings.Size = new System.Drawing.Size(116, 40);
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.buttonSettings.Location = new System.Drawing.Point(910, 16);
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            brandMark.Controls.Add(brandMarkText);
            header.Controls.Add(brandMark);
            header.Controls.Add(title);
            header.Controls.Add(subtitle);
            header.Controls.Add(this.buttonSettings);

            // Search and profile columns
            content.BackColor = UiTheme.Canvas;
            content.Dock = System.Windows.Forms.DockStyle.Fill;
            content.ColumnCount = 2;
            content.RowCount = 1;
            content.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));

            searchCard.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            searchLayout.BackColor = UiTheme.Surface;
            searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            searchLayout.ColumnCount = 1;
            searchLayout.RowCount = 7;
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            searchTitle.AutoSize = false;
            searchTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            searchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            searchSubtitle.AutoSize = false;
            searchSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            searchSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            queryLabel.AutoSize = false;
            queryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            queryLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.textBox1.Text = "goth -ai_generated";
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            UiTheme.StyleInput(this.textBox1);
            queryHint.AutoSize = false;
            queryHint.Dock = System.Windows.Forms.DockStyle.Fill;
            queryHint.Text = "Separate required tags with spaces. Use -tag to exclude and * for wildcards.";
            queryHint.ForeColor = UiTheme.Muted;
            queryHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            queryHint.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            actions.BackColor = UiTheme.Surface;
            actions.Dock = System.Windows.Forms.DockStyle.Fill;
            actions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            actions.WrapContents = true;
            actions.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button2.Size = new System.Drawing.Size(132, 42);
            this.buttonPauseResume.Size = new System.Drawing.Size(116, 42);
            this.buttonPauseResume.Enabled = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.buttonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            actions.Controls.Add(this.button1);
            actions.Controls.Add(this.button2);
            actions.Controls.Add(this.buttonPauseResume);

            utilities.BackColor = UiTheme.Surface;
            utilities.Dock = System.Windows.Forms.DockStyle.Fill;
            utilities.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            utilities.WrapContents = true;
            utilities.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Text = "Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Text = "Project page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            UiTheme.StyleLink(this.linkLabel1);
            UiTheme.StyleLink(this.linkLabel2);
            utilities.Controls.Add(this.button4);
            utilities.Controls.Add(this.button3);
            utilities.Controls.Add(this.linkLabel1);
            utilities.Controls.Add(this.linkLabel2);

            searchLayout.Controls.Add(searchTitle, 0, 0);
            searchLayout.Controls.Add(searchSubtitle, 0, 1);
            searchLayout.Controls.Add(queryLabel, 0, 2);
            searchLayout.Controls.Add(this.textBox1, 0, 3);
            searchLayout.Controls.Add(queryHint, 0, 4);
            searchLayout.Controls.Add(actions, 0, 5);
            searchLayout.Controls.Add(utilities, 0, 6);
            searchCard.Controls.Add(searchLayout);

            // Profile summary card
            profileCard.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            profileLayout.BackColor = UiTheme.Surface;
            profileLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            profileLayout.ColumnCount = 1;
            profileLayout.RowCount = 8;
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            profileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            profileTitle.AutoSize = false;
            profileTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            profileSubtitle.AutoSize = false;
            profileSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceLabel.AutoSize = false;
            sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            sizeLabel.AutoSize = false;
            sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            blacklistLabel.AutoSize = false;
            blacklistLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            blacklistLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelModeValue.AutoSize = false;
            this.labelModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelModeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFileLimitValue.AutoSize = false;
            this.labelFileLimitValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFileLimitValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBlacklistValue.AutoSize = false;
            this.labelBlacklistValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBlacklistValue.ForeColor = UiTheme.Text;
            this.labelBlacklistValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBlacklistValue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            profileNote.AutoSize = false;
            profileNote.Dock = System.Windows.Forms.DockStyle.Fill;
            profileNote.Text = "Open Settings to change the source, authentication, file size cap, or excluded tags.";
            profileNote.ForeColor = UiTheme.Muted;
            profileNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            profileNote.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            profileLayout.Controls.Add(profileTitle, 0, 0);
            profileLayout.Controls.Add(profileSubtitle, 0, 1);
            profileLayout.Controls.Add(sourceLabel, 0, 2);
            profileLayout.Controls.Add(this.labelModeValue, 0, 3);
            profileLayout.Controls.Add(sizeLabel, 0, 4);
            profileLayout.Controls.Add(this.labelFileLimitValue, 0, 5);
            profileLayout.Controls.Add(blacklistLabel, 0, 6);
            var profileBottom = new System.Windows.Forms.TableLayoutPanel();
            profileBottom.BackColor = UiTheme.Surface;
            profileBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            profileBottom.ColumnCount = 1;
            profileBottom.RowCount = 2;
            profileBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            profileBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            profileBottom.Controls.Add(this.labelBlacklistValue, 0, 0);
            profileBottom.Controls.Add(profileNote, 0, 1);
            profileLayout.Controls.Add(profileBottom, 0, 7);
            profileCard.Controls.Add(profileLayout);

            content.Controls.Add(searchCard, 0, 0);
            content.Controls.Add(profileCard, 1, 0);

            // Progress and status bar
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.BackColor = UiTheme.Surface;
            this.statusStrip1.ForeColor = UiTheme.Muted;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(430, 22);
            this.toolStripStatusLabel1.ForeColor = UiTheme.Text;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(260, 18);
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.ForeColor = UiTheme.Muted;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1,
                this.toolStripProgressBar1,
                this.toolStripStatusLabel2});

            root.Controls.Add(header, 0, 0);
            root.Controls.Add(content, 0, 1);
            root.Controls.Add(this.statusStrip1, 0, 2);

            this.folderBrowserDialog1.Description = "Choose where downloaded media should be saved.";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = UiTheme.Canvas;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule34.xxx Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPauseResume;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelModeValue;
        private System.Windows.Forms.Label labelFileLimitValue;
        private System.Windows.Forms.Label labelBlacklistValue;
    }
}
