namespace AndroidSideloader
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkForUpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.enableMessageBoxesCheckBox = new System.Windows.Forms.CheckBox();
            this.resetSettingsButton = new System.Windows.Forms.Button();
            this.deleteAfterInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.updateConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.debugRcloneCheckBox = new System.Windows.Forms.CheckBox();
            this.userJsonOnGameInstall = new System.Windows.Forms.CheckBox();
            this.spoofGamesCheckbox = new System.Windows.Forms.CheckBox();
            this.BandwithTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BandwithComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkForUpdatesCheckBox
            // 
            this.checkForUpdatesCheckBox.AutoSize = true;
            this.checkForUpdatesCheckBox.Location = new System.Drawing.Point(13, 13);
            this.checkForUpdatesCheckBox.Name = "checkForUpdatesCheckBox";
            this.checkForUpdatesCheckBox.Size = new System.Drawing.Size(113, 17);
            this.checkForUpdatesCheckBox.TabIndex = 0;
            this.checkForUpdatesCheckBox.Text = "Check for updates";
            this.checkForUpdatesCheckBox.UseVisualStyleBackColor = true;
            this.checkForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.checkForUpdatesCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.White;
            this.applyButton.ForeColor = System.Drawing.Color.Black;
            this.applyButton.Location = new System.Drawing.Point(357, 266);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // enableMessageBoxesCheckBox
            // 
            this.enableMessageBoxesCheckBox.AutoSize = true;
            this.enableMessageBoxesCheckBox.Location = new System.Drawing.Point(13, 36);
            this.enableMessageBoxesCheckBox.Name = "enableMessageBoxesCheckBox";
            this.enableMessageBoxesCheckBox.Size = new System.Drawing.Size(227, 17);
            this.enableMessageBoxesCheckBox.TabIndex = 1;
            this.enableMessageBoxesCheckBox.Text = "Enable Message Boxes on task completed";
            this.enableMessageBoxesCheckBox.UseVisualStyleBackColor = true;
            this.enableMessageBoxesCheckBox.CheckedChanged += new System.EventHandler(this.enableMessageBoxesCheckBox_CheckedChanged);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.BackColor = System.Drawing.Color.White;
            this.resetSettingsButton.ForeColor = System.Drawing.Color.Black;
            this.resetSettingsButton.Location = new System.Drawing.Point(256, 266);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(95, 23);
            this.resetSettingsButton.TabIndex = 4;
            this.resetSettingsButton.Text = "Reset Settings";
            this.resetSettingsButton.UseVisualStyleBackColor = false;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // deleteAfterInstallCheckBox
            // 
            this.deleteAfterInstallCheckBox.AutoSize = true;
            this.deleteAfterInstallCheckBox.Location = new System.Drawing.Point(13, 59);
            this.deleteAfterInstallCheckBox.Name = "deleteAfterInstallCheckBox";
            this.deleteAfterInstallCheckBox.Size = new System.Drawing.Size(214, 17);
            this.deleteAfterInstallCheckBox.TabIndex = 3;
            this.deleteAfterInstallCheckBox.Text = "Delete games after download and install";
            this.deleteAfterInstallCheckBox.UseVisualStyleBackColor = true;
            this.deleteAfterInstallCheckBox.CheckedChanged += new System.EventHandler(this.deleteAfterInstallCheckBox_CheckedChanged);
            // 
            // updateConfigCheckBox
            // 
            this.updateConfigCheckBox.AutoSize = true;
            this.updateConfigCheckBox.Location = new System.Drawing.Point(13, 83);
            this.updateConfigCheckBox.Name = "updateConfigCheckBox";
            this.updateConfigCheckBox.Size = new System.Drawing.Size(157, 17);
            this.updateConfigCheckBox.TabIndex = 6;
            this.updateConfigCheckBox.Text = "Update config automatically";
            this.updateConfigCheckBox.UseVisualStyleBackColor = true;
            this.updateConfigCheckBox.CheckedChanged += new System.EventHandler(this.updateConfigCheckBox_CheckedChanged);
            // 
            // debugRcloneCheckBox
            // 
            this.debugRcloneCheckBox.AutoSize = true;
            this.debugRcloneCheckBox.Location = new System.Drawing.Point(13, 106);
            this.debugRcloneCheckBox.Name = "debugRcloneCheckBox";
            this.debugRcloneCheckBox.Size = new System.Drawing.Size(95, 17);
            this.debugRcloneCheckBox.TabIndex = 8;
            this.debugRcloneCheckBox.Text = "Debug Rclone";
            this.debugRcloneCheckBox.UseVisualStyleBackColor = true;
            this.debugRcloneCheckBox.CheckedChanged += new System.EventHandler(this.debugRcloneCheckBox_CheckedChanged);
            // 
            // userJsonOnGameInstall
            // 
            this.userJsonOnGameInstall.AutoSize = true;
            this.userJsonOnGameInstall.Location = new System.Drawing.Point(13, 130);
            this.userJsonOnGameInstall.Name = "userJsonOnGameInstall";
            this.userJsonOnGameInstall.Size = new System.Drawing.Size(177, 17);
            this.userJsonOnGameInstall.TabIndex = 9;
            this.userJsonOnGameInstall.Text = "Push random user.json on install";
            this.userJsonOnGameInstall.UseVisualStyleBackColor = true;
            this.userJsonOnGameInstall.CheckedChanged += new System.EventHandler(this.userJsonOnGameInstall_CheckedChanged);
            // 
            // spoofGamesCheckbox
            // 
            this.spoofGamesCheckbox.AutoSize = true;
            this.spoofGamesCheckbox.Location = new System.Drawing.Point(13, 153);
            this.spoofGamesCheckbox.Name = "spoofGamesCheckbox";
            this.spoofGamesCheckbox.Size = new System.Drawing.Size(184, 17);
            this.spoofGamesCheckbox.TabIndex = 10;
            this.spoofGamesCheckbox.Text = "Spoof games installed from rclone";
            this.spoofGamesCheckbox.UseVisualStyleBackColor = true;
            this.spoofGamesCheckbox.CheckedChanged += new System.EventHandler(this.spoofGamesCheckbox_CheckedChanged);
            // 
            // BandwithTextbox
            // 
            this.BandwithTextbox.Location = new System.Drawing.Point(183, 176);
            this.BandwithTextbox.Name = "BandwithTextbox";
            this.BandwithTextbox.Size = new System.Drawing.Size(177, 20);
            this.BandwithTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rclone bandwith limit, 0 to disable";
            // 
            // BandwithComboBox
            // 
            this.BandwithComboBox.FormattingEnabled = true;
            this.BandwithComboBox.Items.AddRange(new object[] {
            "B",
            "K",
            "M",
            "G"});
            this.BandwithComboBox.Location = new System.Drawing.Point(366, 176);
            this.BandwithComboBox.Name = "BandwithComboBox";
            this.BandwithComboBox.Size = new System.Drawing.Size(55, 21);
            this.BandwithComboBox.TabIndex = 13;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.BandwithComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BandwithTextbox);
            this.Controls.Add(this.spoofGamesCheckbox);
            this.Controls.Add(this.userJsonOnGameInstall);
            this.Controls.Add(this.debugRcloneCheckBox);
            this.Controls.Add(this.updateConfigCheckBox);
            this.Controls.Add(this.deleteAfterInstallCheckBox);
            this.Controls.Add(this.resetSettingsButton);
            this.Controls.Add(this.enableMessageBoxesCheckBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.checkForUpdatesCheckBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkForUpdatesCheckBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox enableMessageBoxesCheckBox;
        private System.Windows.Forms.Button resetSettingsButton;
        private System.Windows.Forms.CheckBox deleteAfterInstallCheckBox;
        private System.Windows.Forms.CheckBox updateConfigCheckBox;
        private System.Windows.Forms.CheckBox debugRcloneCheckBox;
        private System.Windows.Forms.CheckBox userJsonOnGameInstall;
        private System.Windows.Forms.CheckBox spoofGamesCheckbox;
        private System.Windows.Forms.TextBox BandwithTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BandwithComboBox;
    }
}