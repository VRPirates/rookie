using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class QuestForm : Form
    {
        public static int length = 0;
        public static string[] result;
        public bool settingsexist = false;
        public static bool QUSon = false;
        public QuestForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool ChangesMade = false;

            //Quest 2 settings, might remove them in the future since some of them are broken
            if (RefreshRateComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.refreshRate {RefreshRateComboBox.SelectedItem.ToString()}");
                ADB.RunAdbCommandToString($"shell settings put global 90hz_global {RefreshRateComboBox.SelectedIndex}");
                ADB.RunAdbCommandToString($"shell settings put global 90hzglobal {RefreshRateComboBox.SelectedIndex}");
                ChangesMade = true;
            }

            if (TextureResTextBox.Text.Length > 0)
            {
                Int32.TryParse(TextureResTextBox.Text, out int result);
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureWidth {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureHeight {TextureResTextBox.Text}");
                ChangesMade = true;
            }

            if (CPUComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.cpuLevel {CPUComboBox.SelectedItem.ToString()}");
                ChangesMade = true;
            }

            if (GPUComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.gpuLevel {GPUComboBox.SelectedItem.ToString()}");
                ChangesMade = true;
            }

            if (ChangesMade)
                MessageBox.Show("Settings applied!");
        }


        public static void setLength(int value)
        {
            result = new string[value];
        }



        private void Clear_click(object sender, EventArgs e)
        {
            ResBox.Clear();
            UsrBox.Clear();
            FOVx.Clear();
            FOVy.Clear();
            QURfrRt.SelectedIndex = 0;
        }

        private void QUon_CheckedChanged(object sender, EventArgs e)
        {
            if (QUon.Checked)
            {
                ResBox.Visible = true;
                UsrBox.Visible = true;
                FOVx.Visible = true;
                FOVy.Visible = true;
                QURfrRt.Visible = true;
                ResetQU.Visible = true;
                QUEnable.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                ResBox.Text = Properties.Settings.Default.QUres;
                UsrBox.Text = Properties.Settings.Default.QUname;
                FOVy.Text = Properties.Settings.Default.QUy;
                FOVx.Text = Properties.Settings.Default.QUx;
                QURfrRt.SelectedValue = Properties.Settings.Default.QUhz;
            }
            else if (!QUon.Checked)
            {
                ResBox.Visible = false;
                UsrBox.Visible = false;
                FOVx.Visible = false;
                FOVy.Visible = false;
                QURfrRt.Visible = false;
                ResetQU.Visible = false;
                QUEnable.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button2.Visible = false;
                MessageBox.Show("Ok, Deleted your custom settings file.\nIf you would like to re-enable return here and apply settings again");
                File.Delete($"{Properties.Settings.Default.MainDir}\\Config.Json");
            }

        }

        private void QUEnable_Click(object sender, EventArgs e)
        {

            settingsexist = true;
            MessageBox.Show("OK, any -QU packages installed will have these settings applied!\nTo delete settings: goto main app window, select a game with top menu, and click \"Remove QU Setting\"");
            if (QUon.Checked)
            {
                QUSon = true;

                string selected = this.QURfrRt.GetItemText(this.QURfrRt.SelectedItem);
                Properties.Settings.Default.QUString = $"{{\"user_id\":,\"username\":\"{UsrBox.Text}\",\"app_id\":\"\",\"refresh_rate\":{selected},\"eye_texture_width\":{ResBox.Text},\"fov_x\":{FOVx.Text},\"fov_y\":{FOVy.Text}}}";
                Properties.Settings.Default.Save();
                File.WriteAllText("Config.Json", Properties.Settings.Default.QUString);
            }
            


    }



    private void QuestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (QUon.Checked)
            {
                Properties.Settings.Default.QUsett = true;
                Properties.Settings.Default.Save();
            }
            if (!QUon.Checked)
                Properties.Settings.Default.QUsett = false;
                Properties.Settings.Default.Save();
        }
        private void QuestForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QUsett)
            {
                ResBox.Text = Properties.Settings.Default.QUres;
                UsrBox.Text = Properties.Settings.Default.QUname;
                FOVy.Text = Properties.Settings.Default.QUy;
                FOVx.Text = Properties.Settings.Default.QUx;
                QURfrRt.Text = Properties.Settings.Default.QUhz;
                QUon.Checked = true;
                if (settingsexist)
                QUSon = true;
              
                
            }
        }

        private void ResBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QUres = ResBox.Text;
            Properties.Settings.Default.Save();

        }

        private void UsrBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QUname = UsrBox.Text;
            Properties.Settings.Default.Save();
        }

        private void FOVx_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QUx = FOVx.Text;
            Properties.Settings.Default.Save();
        }

        private void FOVy_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QUy = FOVy.Text;
            Properties.Settings.Default.Save();
        }

        private void QURfrRt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.QURfrRt.GetItemText(this.QURfrRt.SelectedItem);
            Properties.Settings.Default.QUhz = selected;
            Properties.Settings.Default.Save();
        }
            private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok, Deleted your custom settings file.\nIf you would like to re-enable return here and apply settings again,\n\n To remove settings from game on Quest:\n\nchoose a game in the main app window then click Remove QU Setting from the menu.");
            File.Delete($"{Properties.Settings.Default.MainDir}\\Config.Json");
        }
    }
}
