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
            this.userJsonOnGameInstall = new System.Windows.Forms.CheckBox();
            this.BandwithTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BandwithComboBox = new System.Windows.Forms.ComboBox();
            this.DebugLogCopy = new System.Windows.Forms.Button();
            this.CrashLogCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkForUpdatesCheckBox
            // 
            this.checkForUpdatesCheckBox.AutoSize = true;
            this.checkForUpdatesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkForUpdatesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.checkForUpdatesCheckBox.Location = new System.Drawing.Point(13, 13);
            this.checkForUpdatesCheckBox.Name = "checkForUpdatesCheckBox";
            this.checkForUpdatesCheckBox.Size = new System.Drawing.Size(135, 20);
            this.checkForUpdatesCheckBox.TabIndex = 0;
            this.checkForUpdatesCheckBox.Text = "Check for updates";
            this.checkForUpdatesCheckBox.UseVisualStyleBackColor = true;
            this.checkForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.checkForUpdatesCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.applyButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.applyButton.Location = new System.Drawing.Point(12, 178);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(101, 31);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // enableMessageBoxesCheckBox
            // 
            this.enableMessageBoxesCheckBox.AutoSize = true;
            this.enableMessageBoxesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableMessageBoxesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.enableMessageBoxesCheckBox.Location = new System.Drawing.Point(13, 36);
            this.enableMessageBoxesCheckBox.Name = "enableMessageBoxesCheckBox";
            this.enableMessageBoxesCheckBox.Size = new System.Drawing.Size(284, 20);
            this.enableMessageBoxesCheckBox.TabIndex = 1;
            this.enableMessageBoxesCheckBox.Text = "Enable Message Boxes on task completed";
            this.enableMessageBoxesCheckBox.UseVisualStyleBackColor = true;
            this.enableMessageBoxesCheckBox.CheckedChanged += new System.EventHandler(this.enableMessageBoxesCheckBox_CheckedChanged);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.resetSettingsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resetSettingsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resetSettingsButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resetSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetSettingsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.resetSettingsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.resetSettingsButton.Location = new System.Drawing.Point(119, 178);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(101, 31);
            this.resetSettingsButton.TabIndex = 4;
            this.resetSettingsButton.Text = "Reset Settings";
            this.resetSettingsButton.UseVisualStyleBackColor = false;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // deleteAfterInstallCheckBox
            // 
            this.deleteAfterInstallCheckBox.AutoSize = true;
            this.deleteAfterInstallCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteAfterInstallCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.deleteAfterInstallCheckBox.Location = new System.Drawing.Point(13, 59);
            this.deleteAfterInstallCheckBox.Name = "deleteAfterInstallCheckBox";
            this.deleteAfterInstallCheckBox.Size = new System.Drawing.Size(266, 20);
            this.deleteAfterInstallCheckBox.TabIndex = 3;
            this.deleteAfterInstallCheckBox.Text = "Delete games after download and install";
            this.deleteAfterInstallCheckBox.UseVisualStyleBackColor = true;
            this.deleteAfterInstallCheckBox.CheckedChanged += new System.EventHandler(this.deleteAfterInstallCheckBox_CheckedChanged);
            // 
            // updateConfigCheckBox
            // 
            this.updateConfigCheckBox.AutoSize = true;
            this.updateConfigCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.updateConfigCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.updateConfigCheckBox.Location = new System.Drawing.Point(13, 83);
            this.updateConfigCheckBox.Name = "updateConfigCheckBox";
            this.updateConfigCheckBox.Size = new System.Drawing.Size(193, 20);
            this.updateConfigCheckBox.TabIndex = 6;
            this.updateConfigCheckBox.Text = "Update config automatically";
            this.updateConfigCheckBox.UseVisualStyleBackColor = true;
            this.updateConfigCheckBox.CheckedChanged += new System.EventHandler(this.updateConfigCheckBox_CheckedChanged);
            // 
            // userJsonOnGameInstall
            // 
            this.userJsonOnGameInstall.AutoSize = true;
            this.userJsonOnGameInstall.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userJsonOnGameInstall.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.userJsonOnGameInstall.Location = new System.Drawing.Point(13, 106);
            this.userJsonOnGameInstall.Name = "userJsonOnGameInstall";
            this.userJsonOnGameInstall.Size = new System.Drawing.Size(218, 20);
            this.userJsonOnGameInstall.TabIndex = 9;
            this.userJsonOnGameInstall.Text = "Push random user.json on install";
            this.userJsonOnGameInstall.UseVisualStyleBackColor = true;
            this.userJsonOnGameInstall.CheckedChanged += new System.EventHandler(this.userJsonOnGameInstall_CheckedChanged);
            // 
            // BandwithTextbox
            // 
            this.BandwithTextbox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.BandwithTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithTextbox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithTextbox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.BandwithTextbox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.BandwithTextbox.Location = new System.Drawing.Point(12, 148);
            this.BandwithTextbox.Name = "BandwithTextbox";
            this.BandwithTextbox.Size = new System.Drawing.Size(177, 22);
            this.BandwithTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Download speed limiter, 0 to disable";
            // 
            // BandwithComboBox
            // 
            this.BandwithComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.BandwithComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BandwithComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BandwithComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.BandwithComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.BandwithComboBox.FormattingEnabled = true;
            this.BandwithComboBox.Items.AddRange(new object[] {
            "B",
            "K",
            "M",
            "G"});
            this.BandwithComboBox.Location = new System.Drawing.Point(195, 146);
            this.BandwithComboBox.Name = "BandwithComboBox";
            this.BandwithComboBox.Size = new System.Drawing.Size(55, 24);
            this.BandwithComboBox.TabIndex = 13;
            // 
            // DebugLogCopy
            // 
            this.DebugLogCopy.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.DebugLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DebugLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DebugLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DebugLogCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugLogCopy.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.DebugLogCopy.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.DebugLogCopy.Location = new System.Drawing.Point(12, 215);
            this.DebugLogCopy.Name = "DebugLogCopy";
            this.DebugLogCopy.Size = new System.Drawing.Size(285, 31);
            this.DebugLogCopy.TabIndex = 5;
            this.DebugLogCopy.Text = "Copy DebugLog to Desktop";
            this.DebugLogCopy.UseVisualStyleBackColor = false;
            this.DebugLogCopy.Click += new System.EventHandler(this.DebugLogCopy_click);
            // 
            // CrashLogCopy
            // 
            this.CrashLogCopy.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.CrashLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CrashLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CrashLogCopy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CrashLogCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrashLogCopy.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.CrashLogCopy.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.CrashLogCopy.Location = new System.Drawing.Point(12, 252);
            this.CrashLogCopy.Name = "CrashLogCopy";
            this.CrashLogCopy.Size = new System.Drawing.Size(285, 31);
            this.CrashLogCopy.TabIndex = 5;
            this.CrashLogCopy.Text = "Copy CrashLog to Desktop";
            this.CrashLogCopy.UseVisualStyleBackColor = false;
            this.CrashLogCopy.Click += new System.EventHandler(this.CrashLogCopy_click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.BandwithComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BandwithTextbox);
            this.Controls.Add(this.userJsonOnGameInstall);
            this.Controls.Add(this.updateConfigCheckBox);
            this.Controls.Add(this.deleteAfterInstallCheckBox);
            this.Controls.Add(this.enableMessageBoxesCheckBox);
            this.Controls.Add(this.CrashLogCopy);
            this.Controls.Add(this.DebugLogCopy);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.checkForUpdatesCheckBox);
            this.Controls.Add(this.resetSettingsButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
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
        private System.Windows.Forms.CheckBox userJsonOnGameInstall;
        private System.Windows.Forms.TextBox BandwithTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BandwithComboBox;
        private System.Windows.Forms.Button DebugLogCopy;
        private System.Windows.Forms.Button CrashLogCopy;
    }
}