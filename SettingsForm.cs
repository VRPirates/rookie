using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            copyMessageToClipboardCheckBox.Checked = Properties.Settings.Default.copyMessageToClipboard;
        }

        void intToolTips()
        {
            ToolTip checkForUpdatesToolTip = new ToolTip();
            checkForUpdatesToolTip.SetToolTip(this.checkForUpdatesCheckBox, "If this is checked, the software will check for available updates");
            ToolTip enableMessageBoxesToolTip = new ToolTip();
            enableMessageBoxesToolTip.SetToolTip(this.enableMessageBoxesCheckBox, "If this is checked, the software will display message boxes after every completed task");
            ToolTip copyMessageToClipboardToolTip = new ToolTip();
            copyMessageToClipboardToolTip.SetToolTip(this.copyMessageToClipboardCheckBox, "If this is checked, after each task the software will set the result message to your clipboard");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
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

        private void copyMessageToClipboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.copyMessageToClipboard = copyMessageToClipboardCheckBox.Checked;
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            intSettings();
        }
    }
}
