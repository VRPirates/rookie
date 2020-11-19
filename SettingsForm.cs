using JR.Utils.GUI.Forms;
using System;
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
            this.CenterToParent();

            intSettings();

            intToolTips();
        }

        private void intSettings()
        {
            checkForUpdatesCheckBox.Checked = Properties.Settings.Default.checkForUpdates;
            enableMessageBoxesCheckBox.Checked = Properties.Settings.Default.enableMessageBoxes;
            deleteAfterInstallCheckBox.Checked = Properties.Settings.Default.deleteAllAfterInstall;
            updateConfigCheckBox.Checked = Properties.Settings.Default.autoUpdateConfig;
            debugRcloneCheckBox.Checked = Properties.Settings.Default.logRclone;
            userJsonOnGameInstall.Checked = Properties.Settings.Default.userJsonOnGameInstall;
            spoofGamesCheckbox.Checked = Properties.Settings.Default.SpoofGames;
            if (Properties.Settings.Default.BandwithLimit.Length>1)
            {
                BandwithTextbox.Text = Properties.Settings.Default.BandwithLimit.Remove(Properties.Settings.Default.BandwithLimit.Length - 1);
                BandwithComboBox.Text = Properties.Settings.Default.BandwithLimit[Properties.Settings.Default.BandwithLimit.Length-1].ToString();
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

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (BandwithTextbox.Text.Length > 0 && BandwithTextbox.Text != "0")
                if (BandwithComboBox.SelectedIndex == -1)
                {
                    FlexibleMessageBox.Show("You need to select something from the combobox");
                    return;
                }
                else
                    Properties.Settings.Default.BandwithLimit = $"{BandwithTextbox.Text.Replace(" ", "")}{BandwithComboBox.Text}";
            else
                Properties.Settings.Default.BandwithLimit = "";

            Properties.Settings.Default.Save();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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

        private void debugRcloneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.logRclone = debugRcloneCheckBox.Checked;
        }

        private void userJsonOnGameInstall_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.userJsonOnGameInstall = userJsonOnGameInstall.Checked;
        }

        private void spoofGamesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpoofGames = spoofGamesCheckbox.Checked;
            if (spoofGamesCheckbox.Checked)
                FlexibleMessageBox.Show(Sideloader.SpooferWarning);
        }
    }
}
