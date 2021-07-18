using JR.Utils.GUI.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Environment.CurrentDirectory}\\{Properties.Settings.Default.CurrentCrashName}.txt"))
                textBox1.Text = Properties.Settings.Default.CurrentCrashName;
            this.CenterToParent();
            if (!Properties.Settings.Default.CurrentLogName.Equals(null))
            {
                if (!Properties.Settings.Default.CurrentLogTitle.Equals(null))
                {
                    Properties.Settings.Default.CurrentLogName = Properties.Settings.Default.CurrentLogTitle.Replace($"{Environment.CurrentDirectory}\\", "");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.CurrentLogName = Properties.Settings.Default.CurrentLogName.Replace($".txt", "");
                    Properties.Settings.Default.Save();
                }
            }


            debuglogID.Text = "This is your DebugLogID. Click on your DebugLogID to copy it to your clipboard.";
            DebugID.Text = Properties.Settings.Default.CurrentLogName;
            textBox1.Text = Properties.Settings.Default.CurrentCrashName;
            intSettings();
            intToolTips();
        }

        //Init form objects with values from settings
        private void intSettings()
        {
            checkForUpdatesCheckBox.Checked = Properties.Settings.Default.checkForUpdates;
            enableMessageBoxesCheckBox.Checked = Properties.Settings.Default.enableMessageBoxes;
            deleteAfterInstallCheckBox.Checked = Properties.Settings.Default.deleteAllAfterInstall;
            updateConfigCheckBox.Checked = Properties.Settings.Default.autoUpdateConfig;
            userJsonOnGameInstall.Checked = Properties.Settings.Default.userJsonOnGameInstall;
            if (Properties.Settings.Default.BandwithLimit.Length > 1)
            {
                BandwithTextbox.Text = Properties.Settings.Default.BandwithLimit.Remove(Properties.Settings.Default.BandwithLimit.Length - 1);
                BandwithComboBox.Text = Properties.Settings.Default.BandwithLimit[Properties.Settings.Default.BandwithLimit.Length - 1].ToString();
            }

        }

        void intToolTips()
        {
            ToolTip checkForUpdatesToolTip = new ToolTip();
            checkForUpdatesToolTip.SetToolTip(this.checkForUpdatesCheckBox, "If this is checked, the software will check for available updates");
            ToolTip enableMessageBoxesToolTip = new ToolTip();
            enableMessageBoxesToolTip.SetToolTip(this.enableMessageBoxesCheckBox, "If this is checked, the software will display message boxes after every completed task");
            ToolTip deleteAfterInstallToolTip = new ToolTip();
            deleteAfterInstallToolTip.SetToolTip(this.deleteAfterInstallCheckBox, "If this is checked, the software will delete all game files after downloading and installing a game from a remote server");
        }





        public void DebugLogCopy_click(object sender, EventArgs e)
        {
            if (File.Exists($"{Properties.Settings.Default.CurrentLogTitle}"))
            {
                RCLONE.runRcloneCommand($"copy \"{Environment.CurrentDirectory}\\{Properties.Settings.Default.CurrentLogName}.txt\" RSL-debuglogs:DebugLogs");

                MessageBox.Show($"Your debug log has been copied to the server. Please mention your DebugLog ID ({Properties.Settings.Default.CurrentLogName}) to the Mods (it has been automatically copied to your clipboard).");
                Clipboard.SetText(DebugID.Text);
            }
        }

        public void CrashLogCopy_click(object sender, EventArgs e)
        {
            if (File.Exists($"{Properties.Settings.Default.MainDir}\\crashlog.txt"))
            {
                if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\crashlog.txt"))
                    File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\crashlog.txt");
                System.IO.File.Copy($"{Properties.Settings.Default.MainDir}\\crashlog.txt", $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\crashlog.txt", true);
                MessageBox.Show("crashlog.txt copied to your desktop!");


            }
            else
                MessageBox.Show("No crashlog found!");
        }
        public void button1_click(object sender, EventArgs e)
        {

            if (File.Exists($"{Properties.Settings.Default.CurrentLogTitle}"))
                File.Delete($"{Properties.Settings.Default.CurrentLogTitle}");
            if (File.Exists($"{Environment.CurrentDirectory}\\debuglog.txt"))
                File.Delete($"{Environment.CurrentDirectory}\\debuglog.txt");
            if (!File.Exists(Properties.Settings.Default.CurrentLogTitle))
            {
                Random r = new Random();
                int x = r.Next(6806);
                int y = r.Next(6806);
                if (File.Exists($"{Properties.Settings.Default.MainDir}\\notes\\nouns.txt"))
                {
                    string[] lines = File.ReadAllLines($"{Properties.Settings.Default.MainDir}\\notes\\nouns.txt");

                    if (!File.Exists($"{Properties.Settings.Default.MainDir}\\notes\\nouns.txt"))
                        File.WriteAllText("NOUNS.TXT MISSING", $"{ Properties.Settings.Default.MainDir}\\notes\\nouns.txt");
                    string randomnoun = lines[new Random(x).Next(lines.Length)];
                    string randomnoun2 = lines[new Random(y).Next(lines.Length)];
                    Properties.Settings.Default.CurrentLogTitle = Properties.Settings.Default.MainDir + "\\" + randomnoun + "-" + randomnoun2 + ".txt";
                    Properties.Settings.Default.CurrentLogName = Properties.Settings.Default.CurrentLogName.Replace(Properties.Settings.Default.MainDir, "");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.CurrentLogName = Properties.Settings.Default.CurrentLogName.Replace($".txt", "");
                    DebugID.Text = Properties.Settings.Default.CurrentLogName;
                    Properties.Settings.Default.Save();
                    
                }
                this.Close();
            }

            DebugID.Text = Properties.Settings.Default.CurrentLogName;
            SettingsForm Form = new SettingsForm();
            Form.Show();

        }



        //Apply settings
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (BandwithTextbox.Text.Length > 0 && BandwithTextbox.Text != "0")
                if (BandwithComboBox.SelectedIndex == -1)
                {
                    FlexibleMessageBox.Show("You need to select something from the combobox");
                    return;
                }
                else
                {
                    Properties.Settings.Default.BandwithLimit = $"{BandwithTextbox.Text.Replace(" ", "")}{BandwithComboBox.Text}";
                }
            else
                Properties.Settings.Default.BandwithLimit = "";

            Properties.Settings.Default.Save();
            FlexibleMessageBox.Show("Settings applied!");
        }

        private void checkForUpdatesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkForUpdates = checkForUpdatesCheckBox.Checked;
        }

        private void enableMessageBoxesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.enableMessageBoxes = enableMessageBoxesCheckBox.Checked;
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            intSettings();
        }

        private void deleteAfterInstallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.deleteAllAfterInstall = deleteAfterInstallCheckBox.Checked;
        }

        private void updateConfigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoUpdateConfig = updateConfigCheckBox.Checked;
        }

        private void userJsonOnGameInstall_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.userJsonOnGameInstall = userJsonOnGameInstall.Checked;
        }

        private void SettingsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void SettingsForm_Leave(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void DebugID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DebugID.Text);
            MessageBox.Show("DebugLogID copied to clipboard! Paste it to a moderator/helper for assistance!");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("CrashLogID copied to clipboard! Paste it to a moderator/helper for assistance!");
        }
    }
}

