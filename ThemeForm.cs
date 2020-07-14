using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class ThemeForm : Form
    {
        
        public ThemeForm()
        {
            InitializeComponent();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackColor = Color.FromArgb(45, 45, 45);
            Properties.Settings.Default.ComboBoxColor = Color.FromArgb(45, 45, 45);
            Properties.Settings.Default.TextBoxColor = Color.FromArgb(45, 45, 45);
            Properties.Settings.Default.ButtonColor = SystemColors.ActiveCaptionText;
            Properties.Settings.Default.SubButtonColor = Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.PanelColor = SystemColors.ActiveCaptionText;
            Properties.Settings.Default.BackPicturePath = "";
            Properties.Settings.Default.FontStyle = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            Properties.Settings.Default.FontColor = Color.White;
            Properties.Settings.Default.Save();
        }

        private void SetBGcolorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.BackColor = colorDialog.Color;
        }

        private void SetBGpicButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String extension = Path.GetExtension(openFileDialog.FileName);
                if (File.Exists(Environment.CurrentDirectory + "\\pic" + extension))
                    File.Delete(Environment.CurrentDirectory + "\\pic" + extension);
                File.Copy(openFileDialog.FileName, Environment.CurrentDirectory + "\\pic" + extension);
                Properties.Settings.Default.BackPicturePath = Environment.CurrentDirectory + "\\pic" + extension;
            }
        }

        private void SetPanelColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.PanelColor = colorDialog.Color;
        }

        private void SetFontColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.FontColor = colorDialog.Color;
        }

        private void SetFontStyleButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.FontStyle = fontDialog.Font;
        }

        private void SetButtonColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.ButtonColor = colorDialog.Color;
        }

        private void SetSubBoxColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.SubButtonColor = colorDialog.Color;
        }

        private void SetComboBoxColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.ComboBoxColor = colorDialog.Color;
        }

        private void SetTextBoxColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.TextBoxColor = colorDialog.Color;
        }
    }
}
