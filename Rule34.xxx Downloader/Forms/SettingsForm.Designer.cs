namespace R34Downloader.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = UiTheme.CreateButton("Save settings", true);
            this.buttonLogs = UiTheme.CreateButton("View download logs");
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = UiTheme.CreateLabel("API key", 8.5F, true, UiTheme.Muted);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = UiTheme.CreateLabel("USER ID", 8.5F, true, UiTheme.Muted);
            this.numericUpDownFileSizeMB = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFileSizeLimit = new System.Windows.Forms.CheckBox();
            this.labelFileSizeMB = UiTheme.CreateLabel("MB", 9F, false, UiTheme.Muted);
            this.labelBlacklistedTags = UiTheme.CreateLabel("Space-separated tags to skip", 9F, false, UiTheme.Muted);
            this.textBoxBlacklistedTags = new System.Windows.Forms.TextBox();

            var root = new System.Windows.Forms.TableLayoutPanel();
            var header = new System.Windows.Forms.Panel();
            var title = UiTheme.CreateLabel("Settings", 20F, true);
            var subtitle = UiTheme.CreateLabel("Tune how posts are found and which files are saved.", 9F, false, UiTheme.Muted);
            var content = new System.Windows.Forms.TableLayoutPanel();
            var leftColumn = new System.Windows.Forms.TableLayoutPanel();
            var rightColumn = new System.Windows.Forms.TableLayoutPanel();
            var sourceCard = UiTheme.CreateCard();
            var sourceLayout = new System.Windows.Forms.TableLayoutPanel();
            var sourceTitle = UiTheme.CreateLabel("SEARCH SOURCE", 9F, true, UiTheme.Muted);
            var sourceHint = UiTheme.CreateLabel("Choose how the app retrieves post details.", 9F, false, UiTheme.Muted);
            var sourceChoices = new System.Windows.Forms.FlowLayoutPanel();
            var authCard = UiTheme.CreateCard();
            var authLayout = new System.Windows.Forms.TableLayoutPanel();
            var authTitle = UiTheme.CreateLabel("API AUTHENTICATION", 9F, true, UiTheme.Muted);
            var authHint = UiTheme.CreateLabel("Optional credentials can improve API access.", 9F, false, UiTheme.Muted);
            var blacklistCard = UiTheme.CreateCard();
            var blacklistLayout = new System.Windows.Forms.TableLayoutPanel();
            var blacklistTitle = UiTheme.CreateLabel("TAG BLACKLIST", 9F, true, UiTheme.Muted);
            var sizeCard = UiTheme.CreateCard();
            var sizeLayout = new System.Windows.Forms.TableLayoutPanel();
            var sizeTitle = UiTheme.CreateLabel("FILE SIZE LIMIT", 9F, true, UiTheme.Muted);
            var sizeHint = UiTheme.CreateLabel("Skip files larger than the selected limit.", 9F, false, UiTheme.Muted);
            var sizeControls = new System.Windows.Forms.FlowLayoutPanel();
            var footer = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileSizeMB)).BeginInit();
            this.SuspendLayout();

            root.BackColor = UiTheme.Canvas;
            root.Dock = System.Windows.Forms.DockStyle.Fill;
            root.Padding = new System.Windows.Forms.Padding(20);
            root.ColumnCount = 1;
            root.RowCount = 3;
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));

            header.BackColor = UiTheme.Canvas;
            header.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Location = new System.Drawing.Point(0, 0);
            subtitle.Location = new System.Drawing.Point(1, 34);
            header.Controls.Add(title);
            header.Controls.Add(subtitle);

            content.BackColor = UiTheme.Canvas;
            content.Dock = System.Windows.Forms.DockStyle.Fill;
            content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            content.ColumnCount = 2;
            content.RowCount = 1;
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            leftColumn.BackColor = UiTheme.Canvas;
            leftColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            leftColumn.ColumnCount = 1;
            leftColumn.RowCount = 2;
            leftColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            leftColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            sourceLayout.BackColor = UiTheme.Surface;
            sourceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceLayout.Padding = new System.Windows.Forms.Padding(20);
            sourceLayout.ColumnCount = 1;
            sourceLayout.RowCount = 3;
            sourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            sourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            sourceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            sourceTitle.AutoSize = false;
            sourceTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceHint.AutoSize = false;
            sourceHint.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceChoices.BackColor = UiTheme.Surface;
            sourceChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceChoices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            sourceChoices.WrapContents = false;
            this.radioButton1.Text = "Official API (recommended)";
            this.radioButton1.Checked = true;
            this.radioButton2.Text = "HTML parser (fallback)";
            UiTheme.StyleRadioButton(this.radioButton1);
            UiTheme.StyleRadioButton(this.radioButton2);
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            sourceChoices.Controls.Add(this.radioButton1);
            sourceChoices.Controls.Add(this.radioButton2);
            sourceLayout.Controls.Add(sourceTitle, 0, 0);
            sourceLayout.Controls.Add(sourceHint, 0, 1);
            sourceLayout.Controls.Add(sourceChoices, 0, 2);
            sourceCard.Controls.Add(sourceLayout);

            authCard.Margin = new System.Windows.Forms.Padding(8, 10, 8, 0);
            authLayout.BackColor = UiTheme.Surface;
            authLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            authLayout.Padding = new System.Windows.Forms.Padding(20);
            authLayout.ColumnCount = 1;
            authLayout.RowCount = 6;
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            authLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            authTitle.AutoSize = false;
            authTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            authHint.AutoSize = false;
            authHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.AutoSize = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.AutoSize = false;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.UseSystemPasswordChar = true;
            UiTheme.StyleInput(this.textBox1);
            UiTheme.StyleInput(this.textBox2);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            authLayout.Controls.Add(authTitle, 0, 0);
            authLayout.Controls.Add(authHint, 0, 1);
            authLayout.Controls.Add(this.label1, 0, 2);
            authLayout.Controls.Add(this.textBox1, 0, 3);
            authLayout.Controls.Add(this.label2, 0, 4);
            authLayout.Controls.Add(this.textBox2, 0, 5);
            authCard.Controls.Add(authLayout);
            leftColumn.Controls.Add(sourceCard, 0, 0);
            leftColumn.Controls.Add(authCard, 0, 1);

            rightColumn.BackColor = UiTheme.Canvas;
            rightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            rightColumn.ColumnCount = 1;
            rightColumn.RowCount = 2;
            rightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            rightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));

            blacklistCard.Margin = new System.Windows.Forms.Padding(8, 0, 0, 10);
            blacklistLayout.BackColor = UiTheme.Surface;
            blacklistLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            blacklistLayout.Padding = new System.Windows.Forms.Padding(20);
            blacklistLayout.ColumnCount = 1;
            blacklistLayout.RowCount = 3;
            blacklistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            blacklistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            blacklistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            blacklistTitle.AutoSize = false;
            blacklistTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBlacklistedTags.AutoSize = false;
            this.labelBlacklistedTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlacklistedTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlacklistedTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            UiTheme.StyleInput(this.textBoxBlacklistedTags, true);
            this.textBoxBlacklistedTags.TextChanged += new System.EventHandler(this.textBoxBlacklistedTags_TextChanged);
            blacklistLayout.Controls.Add(blacklistTitle, 0, 0);
            blacklistLayout.Controls.Add(this.labelBlacklistedTags, 0, 1);
            blacklistLayout.Controls.Add(this.textBoxBlacklistedTags, 0, 2);
            blacklistCard.Controls.Add(blacklistLayout);

            sizeCard.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            sizeLayout.BackColor = UiTheme.Surface;
            sizeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeLayout.Padding = new System.Windows.Forms.Padding(20);
            sizeLayout.ColumnCount = 1;
            sizeLayout.RowCount = 3;
            sizeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            sizeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            sizeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            sizeTitle.AutoSize = false;
            sizeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeHint.AutoSize = false;
            sizeHint.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeControls.BackColor = UiTheme.Surface;
            sizeControls.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeControls.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            sizeControls.WrapContents = false;
            this.checkBoxFileSizeLimit.Text = "Enable limit";
            this.checkBoxFileSizeLimit.CheckedChanged += new System.EventHandler(this.checkBoxFileSizeLimit_CheckedChanged);
            UiTheme.StyleCheckBox(this.checkBoxFileSizeLimit);
            this.labelFileSizeMB.Text = "MB";
            this.labelFileSizeMB.Margin = new System.Windows.Forms.Padding(10, 12, 8, 0);
            this.numericUpDownFileSizeMB.DecimalPlaces = 2;
            this.numericUpDownFileSizeMB.Minimum = 0;
            this.numericUpDownFileSizeMB.Maximum = 100000;
            this.numericUpDownFileSizeMB.Value = 50;
            this.numericUpDownFileSizeMB.Enabled = false;
            this.numericUpDownFileSizeMB.Size = new System.Drawing.Size(112, 30);
            this.numericUpDownFileSizeMB.BackColor = UiTheme.Raised;
            this.numericUpDownFileSizeMB.ForeColor = UiTheme.Text;
            this.numericUpDownFileSizeMB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownFileSizeMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownFileSizeMB.ValueChanged += new System.EventHandler(this.numericUpDownFileSizeMB_ValueChanged);
            sizeControls.Controls.Add(this.checkBoxFileSizeLimit);
            sizeControls.Controls.Add(this.numericUpDownFileSizeMB);
            sizeControls.Controls.Add(this.labelFileSizeMB);
            sizeLayout.Controls.Add(sizeTitle, 0, 0);
            sizeLayout.Controls.Add(sizeHint, 0, 1);
            sizeLayout.Controls.Add(sizeControls, 0, 2);
            sizeCard.Controls.Add(sizeLayout);
            rightColumn.Controls.Add(blacklistCard, 0, 0);
            rightColumn.Controls.Add(sizeCard, 0, 1);
            content.Controls.Add(leftColumn, 0, 0);
            content.Controls.Add(rightColumn, 1, 0);

            footer.BackColor = UiTheme.Canvas;
            footer.Dock = System.Windows.Forms.DockStyle.Fill;
            footer.ColumnCount = 2;
            footer.RowCount = 1;
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.buttonLogs.Text = "View download logs";
            this.buttonLogs.Size = new System.Drawing.Size(158, 42);
            this.buttonLogs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            this.button1.Text = "Save settings";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            footer.Controls.Add(this.buttonLogs, 0, 0);
            footer.Controls.Add(this.button1, 1, 0);
            root.Controls.Add(header, 0, 0);
            root.Controls.Add(content, 0, 1);
            root.Controls.Add(footer, 0, 2);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = UiTheme.Canvas;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.MinimumSize = new System.Drawing.Size(760, 610);
            this.Controls.Add(root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileSizeMB)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFileSizeMB;
        private System.Windows.Forms.CheckBox checkBoxFileSizeLimit;
        private System.Windows.Forms.Label labelFileSizeMB;
        private System.Windows.Forms.Label labelBlacklistedTags;
        private System.Windows.Forms.TextBox textBoxBlacklistedTags;
    }
}
