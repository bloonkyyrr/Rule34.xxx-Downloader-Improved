using System.Drawing;
using System.Windows.Forms;

namespace R34Downloader.Forms
{
    /// <summary>
    /// Shared palette and control styling for the desktop interface.
    /// </summary>
    internal static class UiTheme
    {
        public static readonly Color Canvas = Color.FromArgb(15, 17, 23);
        public static readonly Color Surface = Color.FromArgb(23, 26, 35);
        public static readonly Color Raised = Color.FromArgb(31, 35, 46);
        public static readonly Color Border = Color.FromArgb(47, 52, 66);
        public static readonly Color Text = Color.FromArgb(239, 241, 247);
        public static readonly Color Muted = Color.FromArgb(153, 160, 176);
        public static readonly Color Accent = Color.FromArgb(222, 91, 145);
        public static readonly Color AccentHover = Color.FromArgb(235, 112, 162);
        public static readonly Color Good = Color.FromArgb(105, 205, 163);

        public static Label CreateLabel(string text, float size = 9F, bool bold = false, Color? color = null)
        {
            return new Label
            {
                AutoSize = true,
                Text = text,
                ForeColor = color ?? Text,
                Font = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular),
                Margin = new Padding(0)
            };
        }

        public static Panel CreateCard()
        {
            return new Panel
            {
                BackColor = Surface,
                Padding = new Padding(22),
                Margin = new Padding(8),
                Dock = DockStyle.Fill
            };
        }

        public static Button CreateButton(string text, bool primary = false)
        {
            var button = new Button
            {
                AutoSize = false,
                Text = text,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = primary ? Color.White : Text,
                BackColor = primary ? Accent : Raised,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Height = 42,
                Padding = new Padding(12, 0, 12, 0),
                UseVisualStyleBackColor = false
            };

            button.FlatAppearance.BorderSize = primary ? 0 : 1;
            button.FlatAppearance.BorderColor = Border;
            button.FlatAppearance.MouseOverBackColor = primary ? AccentHover : Color.FromArgb(42, 47, 60);
            button.FlatAppearance.MouseDownBackColor = primary ? Color.FromArgb(192, 70, 122) : Color.FromArgb(52, 58, 72);
            return button;
        }

        public static void StyleInput(TextBox textBox, bool multiline = false)
        {
            textBox.BackColor = Raised;
            textBox.ForeColor = Text;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            textBox.Multiline = multiline;
            textBox.Margin = new Padding(0, 6, 0, 6);
        }

        public static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.AutoSize = true;
            checkBox.ForeColor = Text;
            checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            checkBox.Cursor = Cursors.Hand;
            checkBox.Margin = new Padding(0, 6, 20, 6);
            checkBox.UseVisualStyleBackColor = false;
            checkBox.BackColor = Surface;
        }

        public static void StyleRadioButton(RadioButton radioButton)
        {
            radioButton.AutoSize = true;
            radioButton.ForeColor = Text;
            radioButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            radioButton.Cursor = Cursors.Hand;
            radioButton.Margin = new Padding(0, 6, 12, 6);
            radioButton.UseVisualStyleBackColor = false;
            radioButton.BackColor = Surface;
        }

        public static void StyleLink(LinkLabel linkLabel)
        {
            linkLabel.LinkColor = AccentHover;
            linkLabel.ActiveLinkColor = Color.White;
            linkLabel.VisitedLinkColor = AccentHover;
            linkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            linkLabel.Margin = new Padding(0, 0, 18, 0);
        }
    }
}
