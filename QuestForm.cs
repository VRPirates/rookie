using AndroidSideloader.Utilities;
using System;
using System.IO;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class QuestForm : Form
    {
        private static readonly SettingsManager settings = SettingsManager.Instance;
        public static int length = 0;
        public static string[] result;
        public bool settingsexist = false;
        public bool delsh = false;
        public QuestForm()
        {
            InitializeComponent();
        }


        private void btnApplyTempSettings_Click(object sender, EventArgs e)
        {
            bool ChangesMade = false;

            //Quest 2 settings, might remove them in the future since some of them are broken
            if (RefreshRateComboBox.SelectedIndex != -1)
            {
                _ = ADB.RunAdbCommandToString($"shell setprop debug.oculus.refreshRate {RefreshRateComboBox.SelectedItem}");
                _ = ADB.RunAdbCommandToString($"shell settings put global 90hz_global {RefreshRateComboBox.SelectedIndex}");
                _ = ADB.RunAdbCommandToString($"shell settings put global 90hzglobal {RefreshRateComboBox.SelectedIndex}");
                ChangesMade = true;
            }

            if (TextureResTextBox.Text.Length > 0)
            {
                _ = int.TryParse(TextureResTextBox.Text, out _);
                _ = ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                _ = ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureWidth {TextureResTextBox.Text}");
                _ = ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureHeight {TextureResTextBox.Text}");
                ChangesMade = true;
            }

            if (CPUComboBox.SelectedIndex != -1)
            {
                _ = ADB.RunAdbCommandToString($"shell setprop debug.oculus.cpuLevel {CPUComboBox.SelectedItem}");
                ChangesMade = true;
            }

            if (GPUComboBox.SelectedIndex != -1)
            {
                _ = ADB.RunAdbCommandToString($"shell setprop debug.oculus.gpuLevel {GPUComboBox.SelectedItem}");
                ChangesMade = true;
            }

            if (ChangesMade)
            {
                _ = MessageBox.Show("Settings applied!");
            }
        }


        public static void setLength(int value)
        {
            result = new string[value];
        }


        private void DeleteShots_CheckedChanged(object sender, EventArgs e)
        {
            delsh = DeleteShots.Checked;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }




        private void QuestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DeleteShots.Checked)
            {
                settings.Delsh = true;
                settings.Save();
            }
            if (!DeleteShots.Checked)
            {
                settings.Delsh = false;
                settings.Save();
            }
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            DeleteShots.Checked = settings.Delsh;
            GlobalUsername.Text = settings.GlobalUsername;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Ok, Deleted your custom settings file.\nIf you would like to re-enable return here and apply settings again");
            File.Delete($"{settings.MainDir}\\Config.Json");
        }
        private void questPics_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!Directory.Exists($"{path}\\Quest ScreenShots"))
            {
                _ = Directory.CreateDirectory($"{path}\\Quest ScreenShots");
            }

            _ = MessageBox.Show("Please wait until you get the message that the transfer has finished.");
            Program.form.changeTitle("Pulling files...");
            _ = ADB.RunAdbCommandToString($"pull \"/sdcard/Oculus/Screenshots\" \"{path}\\Quest ScreenShots\"");
            if (delsh)
            {
                DialogResult dialogResult = MessageBox.Show("You have chosen to delete files from headset after transferring, so be sure to move them from your desktop to somewhere safe!", "Warning!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    _ = ADB.RunAdbCommandToString("shell rm -r /sdcard/Oculus/Screenshots");
                    _ = ADB.RunAdbCommandToString("shell mkdir /sdcard/Oculus/Screenshots");
                }
            }
            _ = MessageBox.Show("Transfer finished! ScreenShots can be found in a folder named Quest Screenshots on your desktop!");
            Program.form.changeTitle("Done!");
        }
        private void questVids_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!Directory.Exists($"{path}\\Quest Recordings"))
            {
                _ = Directory.CreateDirectory($"{path}\\Quest Recordings");
            }

            _ = MessageBox.Show("Please wait until you get the message that the transfer has finished.");
            Program.form.changeTitle("Pulling files...");
            _ = ADB.RunAdbCommandToString($"pull \"/sdcard/Oculus/Videoshots\" \"{path}\\Quest Recordings\"");
            if (delsh)
            {
                DialogResult dialogResult = MessageBox.Show("You have chosen to delete files from headset after transferring, so be sure to move them from your desktop to somewhere safe!", "Warning!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    _ = ADB.RunAdbCommandToString("shell rm -r /sdcard/Oculus/Videoshots");
                    _ = ADB.RunAdbCommandToString("shell mkdir /sdcard/Oculus/Videoshots");
                }
            }
            _ = MessageBox.Show("Transfer finished! Recordings can be found in a folder named Quest Recordings on your desktop!");
            Program.form.changeTitle("Done!");
        }

        private void btnApplyUsername_Click(object sender, EventArgs e)
        {
            _ = ADB.RunAdbCommandToString($"shell settings put global username {GlobalUsername.Text}");
            _ = MessageBox.Show($"Username set as {GlobalUsername.Text}", "Success");
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void GlobalUsername_TextChanged(object sender, EventArgs e)
        {
            btnApplyUsername.Enabled = GlobalUsername.TextLength > 0;
            settings.GlobalUsername = GlobalUsername.Text;
            settings.Save();
        }
    }
}
