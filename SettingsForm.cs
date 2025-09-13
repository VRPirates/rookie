using AndroidSideloader.Utilities;
using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class SettingsForm : Form
    {
        private static readonly SettingsManager _settings = SettingsManager.Instance;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
            initSettings();
            initToolTips();
        }

        private void initSettings()
        {
            checkForUpdatesCheckBox.Checked = _settings.CheckForUpdates;
            enableMessageBoxesCheckBox.Checked = _settings.EnableMessageBoxes;
            deleteAfterInstallCheckBox.Checked = _settings.DeleteAllAfterInstall;
            updateConfigCheckBox.Checked = _settings.AutoUpdateConfig;
            userJsonOnGameInstall.Checked = _settings.UserJsonOnGameInstall;
            nodevicemodeBox.Checked = _settings.NodeviceMode;
            bmbfBox.Checked = _settings.BMBFChecked;
            AutoReinstBox.Checked = _settings.AutoReinstall;
            trailersOn.Checked = _settings.TrailersOn;
            chkSingleThread.Checked = _settings.SingleThreadMode;
            virtualFilesystemCompatibilityCheckbox.Checked = _settings.VirtualFilesystemCompatibility;
            bandwidthLimitTextBox.Text = _settings.BandwidthLimit.ToString();
            if (nodevicemodeBox.Checked)
            {
                deleteAfterInstallCheckBox.Checked = false;
                deleteAfterInstallCheckBox.Enabled = false;
            }
            chkUseDownloadedFiles.Checked = _settings.UseDownloadedFiles;
        }

        private void initToolTips()
        {
            ToolTip checkForUpdatesToolTip = new ToolTip();
            checkForUpdatesToolTip.SetToolTip(checkForUpdatesCheckBox, "If this is checked, the software will check for available updates");
            ToolTip enableMessageBoxesToolTip = new ToolTip();
            enableMessageBoxesToolTip.SetToolTip(enableMessageBoxesCheckBox, "If this is checked, the software will display message boxes after every completed task");
            ToolTip deleteAfterInstallToolTip = new ToolTip();
            deleteAfterInstallToolTip.SetToolTip(deleteAfterInstallCheckBox, "If this is checked, the software will delete all game files after downloading and installing a game from a remote server");
            ToolTip chkUseDownloadedFilesTooltip = new ToolTip();
            chkUseDownloadedFilesTooltip.SetToolTip(chkUseDownloadedFiles, "If this is checked, Rookie will always install Downloaded files without Re-Downloading or Asking to Re-Download");
        }

        public void btnUploadDebug_click(object sender, EventArgs e)
        {
            if (File.Exists($"{_settings.CurrentLogPath}"))
            {
                string UUID = SideloaderUtilities.UUID();
                string debugLogPath = $"{Environment.CurrentDirectory}\\{UUID}.log";
                System.IO.File.Copy("debuglog.txt", debugLogPath);

                Clipboard.SetText(UUID);

                _ = RCLONE.runRcloneCommand_UploadConfig($"copy \"{debugLogPath}\" RSL-gameuploads:DebugLogs");
                _ = MessageBox.Show($"Your debug log has been copied to the server. ID: {UUID}");
            }
        }

        public void btnResetDebug_click(object sender, EventArgs e)
        {
            if (File.Exists($"{_settings.CurrentLogPath}"))
            {
                File.Delete($"{_settings.CurrentLogPath}");
            }

            if (File.Exists($"{Environment.CurrentDirectory}\\debuglog.txt"))
            {
                File.Delete($"{Environment.CurrentDirectory}\\debuglog.txt");
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string input = bandwidthLimitTextBox.Text;
            Regex regex = new Regex(@"^\d+(\.\d+)?$");

            if (regex.IsMatch(input) && float.TryParse(input, out float bandwidthLimit))
            {
                _settings.BandwidthLimit = bandwidthLimit;
                _settings.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the bandwidth limit.");
            }
        }

        private void checkForUpdatesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.CheckForUpdates = checkForUpdatesCheckBox.Checked;
            _settings.Save();
        }

        private void chkUseDownloadedFiles_CheckedChanged(object sender, EventArgs e)
        {
            _settings.UseDownloadedFiles = chkUseDownloadedFiles.Checked;
            _settings.Save();
        }

        private void enableMessageBoxesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.EnableMessageBoxes = enableMessageBoxesCheckBox.Checked;
            _settings.Save();
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            // Reset the specific properties
            _settings.CustomDownloadDir = false;
            _settings.CustomBackupDir = false;

            // Set backup folder and download directory
            MainForm.backupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Rookie Backups");
            _settings.DownloadDir = Environment.CurrentDirectory;
            _settings.CreatePubMirrorFile = true;

            // Optionally, call initSettings if it needs to initialize anything based on these settings
            initSettings();

            // Save the updated settings
            _settings.Save();
        }

        private void deleteAfterInstallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.DeleteAllAfterInstall = deleteAfterInstallCheckBox.Checked;
            _settings.Save();
        }

        private void updateConfigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.AutoUpdateConfig = updateConfigCheckBox.Checked;
            if (_settings.AutoUpdateConfig)
            {
                _settings.CreatePubMirrorFile = true;
            }
            _settings.Save();
        }

        private void userJsonOnGameInstall_CheckedChanged(object sender, EventArgs e)
        {
            _settings.UserJsonOnGameInstall = userJsonOnGameInstall.Checked;
            _settings.Save();
        }

        private void SettingsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void SettingsForm_Leave(object sender, EventArgs e)
        {
            Close();
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

        private void nodevicemodeBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.NodeviceMode = nodevicemodeBox.Checked;
            if (!nodevicemodeBox.Checked)
            {
                deleteAfterInstallCheckBox.Checked = true;
                _settings.DeleteAllAfterInstall = true;
                deleteAfterInstallCheckBox.Enabled = true;
            }
            else
            {
                deleteAfterInstallCheckBox.Checked = false;
                _settings.DeleteAllAfterInstall = false;
                deleteAfterInstallCheckBox.Enabled = false;
            }
            _settings.Save();
        }

        private void bmbfBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.BMBFChecked = bmbfBox.Checked;
            _settings.Save();
        }

        private void AutoReinstBox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.AutoReinstall = AutoReinstBox.Checked;
            _settings.Save();
        }

        private void AutoReinstBox_Click(object sender, EventArgs e)
        {
            if (AutoReinstBox.Checked)
            {
                DialogResult dialogResult = FlexibleMessageBox.Show(this, "WARNING: This box enables automatic reinstall when installs fail,\ndue to some games not allowing " +
                    "access to their save data (less than 5%) this\noption can lead to losing your progress." +
                    " However with this option\nchecked when installs fail you won't have to agree to a prompt to perform\nthe reinstall. " +
                    "(ideal when installing from a queue).\n\nNOTE: If your usb/wireless adb connection is extremely slow this option can\ncause larger" +
                    "apk file installations to fail. Enable anyway?", "WARNING", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    AutoReinstBox.Checked = false;
                }
            }
        }

        private void trailersOn_CheckedChanged(object sender, EventArgs e)
        {
            _settings.TrailersOn = trailersOn.Checked;
            _settings.Save();
        }

        private void btnOpenDebug_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{Environment.CurrentDirectory}\\debuglog.txt"))
            {
                _ = Process.Start($"{Environment.CurrentDirectory}\\debuglog.txt");
            }
        }

        private void setDownloadDirectory_Click(object sender, EventArgs e)
        {
            if (downloadDirectorySetter.ShowDialog() == DialogResult.OK)
            {
                _settings.CustomDownloadDir = true;
                _settings.DownloadDir = downloadDirectorySetter.SelectedPath;
                _settings.Save();
            }
        }

        private void setBackupDirectory_Click(object sender, EventArgs e)
        {
            if (backupDirectorySetter.ShowDialog() == DialogResult.OK)
            {
                _settings.CustomBackupDir = true;
                _settings.BackupDir = backupDirectorySetter.SelectedPath;
                MainForm.backupFolder = _settings.BackupDir;
                _settings.Save();
            }
        }

        private void chkSingleThread_CheckedChanged(object sender, EventArgs e)
        {
            _settings.SingleThreadMode = chkSingleThread.Checked;
            _settings.Save();
        }

        private void virtualFilesystemCompatibilityCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.VirtualFilesystemCompatibility = virtualFilesystemCompatibilityCheckbox.Checked;
            _settings.Save();
        }

        private void openDownloadDirectory_Click(object sender, EventArgs e)
        {
            string pathToOpen = _settings.CustomDownloadDir ? _settings.DownloadDir : Environment.CurrentDirectory;
            MainForm.OpenDirectory(pathToOpen);
        }

        private void openBackupDirectory_Click(object sender, EventArgs e)
        {
            string pathToOpen = _settings.CustomBackupDir
                ? Path.Combine(_settings.BackupDir, "Rookie Backups")
                : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Rookie Backups");
            MainForm.OpenDirectory(pathToOpen);
        }

        private void bandwidthLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}