using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace AndroidSideloader
{
    public partial class themeForm : Form
    {
        public themeForm()
        {
            InitializeComponent();
        }

        //Code made by @Gotard#9164 from discord (id 352745203322585088)
        //Steam profile: https://steamcommunity.com/id/GotardPL/
        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.ButtonColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.BackColor = colorDialog1.Color;    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackColor = Color.FromArgb(45,45,45);
            Properties.Settings.Default.ComboBoxColor = Color.FromArgb(45, 45, 45);
            Properties.Settings.Default.TextBoxColor = Color.FromArgb(45,45,45);
            Properties.Settings.Default.ButtonColor = SystemColors.ActiveCaptionText;
            Properties.Settings.Default.SubButtonColor=Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.BackPicturePath = "";
            Properties.Settings.Default.FontStyle = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            Properties.Settings.Default.FontColor = Color.White;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.ComboBoxColor = colorDialog1.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String extension = Path.GetExtension(openFileDialog1.FileName);
                if (File.Exists(Environment.CurrentDirectory + "\\pic" + extension))
                    File.Delete(Environment.CurrentDirectory + "\\pic" + extension);
                File.Copy(openFileDialog1.FileName, Environment.CurrentDirectory + "\\pic" + extension);
                Properties.Settings.Default.BackPicturePath = Environment.CurrentDirectory + "\\pic" + extension ;
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FontStyle = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.FontColor = colorDialog1.Color;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.SubButtonColor = colorDialog1.Color;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String BackColor = ColorTranslator.ToHtml(Properties.Settings.Default.BackColor);
            String TextBoxColor = ColorTranslator.ToHtml(Properties.Settings.Default.TextBoxColor);
            String ComboBoxColor = ColorTranslator.ToHtml(Properties.Settings.Default.ComboBoxColor);
            String ButtonColor = ColorTranslator.ToHtml(Properties.Settings.Default.ButtonColor);
            String SubButtonColor = ColorTranslator.ToHtml(Properties.Settings.Default.SubButtonColor);
            String FontColor = ColorTranslator.ToHtml(Properties.Settings.Default.FontColor);
            var cvt = new FontConverter();
            string FontStyle = cvt.ConvertToString(Properties.Settings.Default.FontStyle);
            int i;
            if (File.Exists(Environment.CurrentDirectory + "\\theme.txt"))
            {
                if (File.Exists(Environment.CurrentDirectory + "\\theme11.txt"))
                    MessageBox.Show("You can't export more than 12 themes, sorry :(");
                else
                {
                    for (i = 1; i <= 10; i++)
                    {
                        if (File.Exists(Environment.CurrentDirectory + "\\theme" + i + ".txt"))
                            continue;
                        else
                        {
                            break;
                        }
                    }
                    File.WriteAllText(Environment.CurrentDirectory + "\\theme" + i + ".txt", "#SideloaderTheme# \n" + BackColor + "\n" + ButtonColor + "\n" + SubButtonColor + "\n"
                        + TextBoxColor + "\n" + ComboBoxColor + "\n" + FontColor + "\n" + FontStyle);
                    MessageBox.Show("Theme exported as theme" + i + ".txt");
                }
            }
            else
            {
                File.WriteAllText(Environment.CurrentDirectory + "\\theme.txt", "#SideloaderTheme# \n" + BackColor + "\n" + ButtonColor + "\n" + SubButtonColor + "\n"
                    + TextBoxColor + "\n" + ComboBoxColor + "\n" + FontColor + "\n" + FontStyle);
                MessageBox.Show("Theme exported as theme.txt");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openThemeDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openThemeDialog.ShowDialog() == DialogResult.OK) {
                using (StreamReader sr = new StreamReader(openThemeDialog.FileName))
                {
                    StringCollection myCol = new StringCollection();
                    myCol.AddRange(File.ReadAllLines(openThemeDialog.FileName));
                    if (myCol.Contains("#SideloaderTheme# "))
                    {
                        String[] settings = new String[myCol.Count];
                        myCol.CopyTo(settings, 0);

                        Color BackColor = ColorTranslator.FromHtml(settings[1]);
                        Color ButtonColor = ColorTranslator.FromHtml(settings[2]);
                        Color SubButtonColor = ColorTranslator.FromHtml(settings[3]);
                        Color TextBoxColor = ColorTranslator.FromHtml(settings[4]);
                        Color ComboBoxColor = ColorTranslator.FromHtml(settings[5]);
                        Color FontColor = ColorTranslator.FromHtml(settings[6]);
                        Properties.Settings.Default.BackColor = BackColor;
                        Properties.Settings.Default.ButtonColor = ButtonColor;
                        Properties.Settings.Default.SubButtonColor = SubButtonColor;
                        Properties.Settings.Default.TextBoxColor = TextBoxColor;
                        Properties.Settings.Default.ComboBoxColor = ComboBoxColor;
                        Properties.Settings.Default.FontColor = FontColor;
                        System.ComponentModel.TypeConverter converter =
                        System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
                        var cvt = new FontConverter();
                        Font f = cvt.ConvertFromString(settings[7]) as Font;
                        Properties.Settings.Default.FontStyle = f;
                    }
                    else
                        MessageBox.Show("The file you've selected is not a Rookie's Sideloader theme file!");
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.TextBoxColor = colorDialog1.Color;
        }
    }
}
