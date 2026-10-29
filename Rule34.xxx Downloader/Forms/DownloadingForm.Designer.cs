namespace R34Downloader.Forms
{
    partial class DownloadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadingForm));
            this.label1 = UiTheme.CreateLabel("HOW MANY POSTS?", 9F, true, UiTheme.Muted);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = UiTheme.CreateButton("Continue", true);
            this.label2 = UiTheme.CreateLabel("Choose how many results to include.", 9F, false, UiTheme.Muted);
            this.checkBoxDownloadAll = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = UiTheme.CreateLabel("MEDIA TYPES", 9F, true, UiTheme.Muted);
            this.label4 = new System.Windows.Forms.Label();

            var root = new System.Windows.Forms.TableLayoutPanel();
            var header = new System.Windows.Forms.Panel();
            var title = UiTheme.CreateLabel("Download selection", 20F, true);
            var subtitle = UiTheme.CreateLabel("Set a result limit and choose the media you want to save.", 9F, false, UiTheme.Muted);
            var content = new System.Windows.Forms.TableLayoutPanel();
            var quantityCard = UiTheme.CreateCard();
            var quantityLayout = new System.Windows.Forms.TableLayoutPanel();
            var countControls = new System.Windows.Forms.FlowLayoutPanel();
            var selectedCountLabel = UiTheme.CreateLabel("Selected amount", 9F, false, UiTheme.Muted);
            var quantityTop = new System.Windows.Forms.TableLayoutPanel();
            var rangeLabel = UiTheme.CreateLabel("Drag to adjust", 9F, false, UiTheme.Muted);
            var availableLabel = UiTheme.CreateLabel("Maximum", 9F, false, UiTheme.Muted);
            var formatsCard = UiTheme.CreateCard();
            var formatsLayout = new System.Windows.Forms.TableLayoutPanel();
            var formatHint = UiTheme.CreateLabel("Select one or more formats.", 9F, false, UiTheme.Muted);
            var formatChoices = new System.Windows.Forms.FlowLayoutPanel();
            var footer = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

            root.BackColor = UiTheme.Canvas;
            root.Dock = System.Windows.Forms.DockStyle.Fill;
            root.Padding = new System.Windows.Forms.Padding(20);
            root.ColumnCount = 1;
            root.RowCount = 3;
            root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
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
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));

            quantityCard.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            quantityLayout.BackColor = UiTheme.Surface;
            quantityLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            quantityLayout.Padding = new System.Windows.Forms.Padding(20);
            quantityLayout.ColumnCount = 1;
            quantityLayout.RowCount = 7;
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            quantityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.label1.AutoSize = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.AutoSize = false;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxDownloadAll.Text = "Download every available post";
            UiTheme.StyleCheckBox(this.checkBoxDownloadAll);
            this.checkBoxDownloadAll.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.checkBoxDownloadAll.CheckedChanged += new System.EventHandler(this.checkBoxDownloadAll_CheckedChanged);
            countControls.BackColor = UiTheme.Surface;
            countControls.Dock = System.Windows.Forms.DockStyle.Fill;
            countControls.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            countControls.WrapContents = false;
            countControls.Margin = new System.Windows.Forms.Padding(0);
            selectedCountLabel.Margin = new System.Windows.Forms.Padding(0, 9, 12, 0);
            quantityTop.BackColor = UiTheme.Surface;
            quantityTop.Dock = System.Windows.Forms.DockStyle.Fill;
            quantityTop.ColumnCount = 2;
            quantityTop.RowCount = 1;
            quantityTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            quantityTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Maximum = 11111;
            this.numericUpDown1.Value = 1;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.None;
            this.numericUpDown1.Size = new System.Drawing.Size(128, 32);
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.BackColor = UiTheme.Raised;
            this.numericUpDown1.ForeColor = UiTheme.Text;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            countControls.Controls.Add(selectedCountLabel);
            countControls.Controls.Add(this.numericUpDown1);
            rangeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            availableLabel.AutoSize = false;
            availableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            availableLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            quantityTop.Controls.Add(rangeLabel, 0, 0);
            quantityTop.Controls.Add(availableLabel, 1, 0);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Maximum = 11111;
            this.trackBar1.Value = 1;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.AutoSize = false;
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            quantityLayout.Controls.Add(this.label1, 0, 0);
            quantityLayout.Controls.Add(this.label2, 0, 1);
            quantityLayout.Controls.Add(this.checkBoxDownloadAll, 0, 2);
            quantityLayout.Controls.Add(countControls, 0, 3);
            quantityLayout.Controls.Add(quantityTop, 0, 4);
            quantityLayout.Controls.Add(this.trackBar1, 0, 5);
            quantityCard.Controls.Add(quantityLayout);

            formatsCard.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            formatsLayout.BackColor = UiTheme.Surface;
            formatsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            formatsLayout.Padding = new System.Windows.Forms.Padding(20);
            formatsLayout.ColumnCount = 1;
            formatsLayout.RowCount = 3;
            formatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            formatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            formatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.label3.AutoSize = false;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            formatHint.AutoSize = false;
            formatHint.Dock = System.Windows.Forms.DockStyle.Fill;
            formatChoices.BackColor = UiTheme.Surface;
            formatChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            formatChoices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            formatChoices.WrapContents = false;
            this.checkBox1.Text = "Images";
            this.checkBox2.Text = "GIF animations";
            this.checkBox3.Text = "Video";
            this.checkBox1.Tag = "Images";
            this.checkBox2.Tag = "GIF animations";
            this.checkBox3.Tag = "Video";
            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            UiTheme.StyleCheckBox(this.checkBox1);
            UiTheme.StyleCheckBox(this.checkBox2);
            UiTheme.StyleCheckBox(this.checkBox3);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.label4.AutoSize = false;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Size = new System.Drawing.Size(200, 58);
            this.label4.Text = "Excluded formats are skipped and do not count toward the selected total.";
            this.label4.ForeColor = UiTheme.Muted;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.Visible = false;
            formatChoices.Controls.Add(this.checkBox1);
            formatChoices.Controls.Add(this.checkBox2);
            formatChoices.Controls.Add(this.checkBox3);
            formatChoices.Controls.Add(this.label4);
            formatsLayout.Controls.Add(this.label3, 0, 0);
            formatsLayout.Controls.Add(formatHint, 0, 1);
            formatsLayout.Controls.Add(formatChoices, 0, 2);
            formatsCard.Controls.Add(formatsLayout);
            content.Controls.Add(quantityCard, 0, 0);
            content.Controls.Add(formatsCard, 1, 0);

            footer.BackColor = UiTheme.Canvas;
            footer.Dock = System.Windows.Forms.DockStyle.Fill;
            footer.ColumnCount = 2;
            footer.RowCount = 1;
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.button1.Text = "Continue";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            footer.Controls.Add(this.button1, 1, 0);
            root.Controls.Add(header, 0, 0);
            root.Controls.Add(content, 0, 1);
            root.Controls.Add(footer, 0, 2);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = UiTheme.Canvas;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(760, 490);
            this.MinimumSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download selection";
            this.Load += new System.EventHandler(this.DownloadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDownloadAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
