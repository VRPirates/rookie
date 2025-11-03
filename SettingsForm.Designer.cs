
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkForUpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.enableMessageBoxesCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteAfterInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.updateConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.userJsonOnGameInstall = new System.Windows.Forms.CheckBox();
            this.crashlogID = new System.Windows.Forms.Label();
            this.nodevicemodeBox = new System.Windows.Forms.CheckBox();
            this.bmbfBox = new System.Windows.Forms.CheckBox();
            this.AutoReinstBox = new System.Windows.Forms.CheckBox();
            this.trailersOn = new System.Windows.Forms.CheckBox();
            this.downloadDirectorySetter = new System.Windows.Forms.FolderBrowserDialog();
            this.backupDirectorySetter = new System.Windows.Forms.FolderBrowserDialog();
            this.chkSingleThread = new System.Windows.Forms.CheckBox();
            this.setBackupDirectory = new AndroidSideloader.RoundButton();
            this.setDownloadDirectory = new AndroidSideloader.RoundButton();
            this.btnOpenDebug = new AndroidSideloader.RoundButton();
            this.btnResetDebug = new AndroidSideloader.RoundButton();
            this.btnUploadDebug = new AndroidSideloader.RoundButton();
            this.resetSettingsButton = new AndroidSideloader.RoundButton();
            this.applyButton = new AndroidSideloader.RoundButton();
            this.virtualFilesystemCompatibilityCheckbox = new System.Windows.Forms.CheckBox();
            this.openBackupDirectory = new AndroidSideloader.RoundButton();
            this.openDownloadDirectory = new AndroidSideloader.RoundButton();
            this.chkUseDownloadedFiles = new System.Windows.Forms.CheckBox();
            this.bandwidthLabel = new System.Windows.Forms.Label();
            this.bandwidthLimitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkForUpdatesCheckBox
            // 
            this.checkForUpdatesCheckBox.AutoSize = true;
            this.checkForUpdatesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.checkForUpdatesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkForUpdatesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.checkForUpdatesCheckBox.Location = new System.Drawing.Point(13, 11);
            this.checkForUpdatesCheckBox.Name = "checkForUpdatesCheckBox";
            this.checkForUpdatesCheckBox.Size = new System.Drawing.Size(226, 22);
            this.checkForUpdatesCheckBox.TabIndex = 0;
            this.checkForUpdatesCheckBox.Text = "Check for Application Updates";
            this.checkForUpdatesCheckBox.UseVisualStyleBackColor = false;
            this.checkForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.checkForUpdatesCheckBox_CheckedChanged);
            // 
            // enableMessageBoxesCheckBox
            // 
            this.enableMessageBoxesCheckBox.AutoSize = true;
            this.enableMessageBoxesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.enableMessageBoxesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableMessageBoxesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.enableMessageBoxesCheckBox.Location = new System.Drawing.Point(13, 227);
            this.enableMessageBoxesCheckBox.Name = "enableMessageBoxesCheckBox";
            this.enableMessageBoxesCheckBox.Size = new System.Drawing.Size(309, 22);
            this.enableMessageBoxesCheckBox.TabIndex = 1;
            this.enableMessageBoxesCheckBox.Text = "Enable Message Boxes on task completed";
            this.enableMessageBoxesCheckBox.UseVisualStyleBackColor = false;
            this.enableMessageBoxesCheckBox.CheckedChanged += new System.EventHandler(this.enableMessageBoxesCheckBox_CheckedChanged);
            // 
            // deleteAfterInstallCheckBox
            // 
            this.deleteAfterInstallCheckBox.AutoSize = true;
            this.deleteAfterInstallCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.deleteAfterInstallCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteAfterInstallCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.deleteAfterInstallCheckBox.Location = new System.Drawing.Point(13, 92);
            this.deleteAfterInstallCheckBox.Name = "deleteAfterInstallCheckBox";
            this.deleteAfterInstallCheckBox.Size = new System.Drawing.Size(288, 22);
            this.deleteAfterInstallCheckBox.TabIndex = 3;
            this.deleteAfterInstallCheckBox.Text = "Delete games after download and install";
            this.deleteAfterInstallCheckBox.UseVisualStyleBackColor = false;
            this.deleteAfterInstallCheckBox.CheckedChanged += new System.EventHandler(this.deleteAfterInstallCheckBox_CheckedChanged);
            // 
            // updateConfigCheckBox
            // 
            this.updateConfigCheckBox.AutoSize = true;
            this.updateConfigCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.updateConfigCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.updateConfigCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.updateConfigCheckBox.Location = new System.Drawing.Point(13, 38);
            this.updateConfigCheckBox.Name = "updateConfigCheckBox";
            this.updateConfigCheckBox.Size = new System.Drawing.Size(256, 22);
            this.updateConfigCheckBox.TabIndex = 6;
            this.updateConfigCheckBox.Text = "Update Public Config Automatically";
            this.updateConfigCheckBox.UseVisualStyleBackColor = false;
            this.updateConfigCheckBox.CheckedChanged += new System.EventHandler(this.updateConfigCheckBox_CheckedChanged);
            // 
            // userJsonOnGameInstall
            // 
            this.userJsonOnGameInstall.AutoSize = true;
            this.userJsonOnGameInstall.BackColor = System.Drawing.Color.Transparent;
            this.userJsonOnGameInstall.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userJsonOnGameInstall.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.userJsonOnGameInstall.Location = new System.Drawing.Point(13, 254);
            this.userJsonOnGameInstall.Name = "userJsonOnGameInstall";
            this.userJsonOnGameInstall.Size = new System.Drawing.Size(243, 22);
            this.userJsonOnGameInstall.TabIndex = 9;
            this.userJsonOnGameInstall.Text = "Push random user.json on install";
            this.userJsonOnGameInstall.UseVisualStyleBackColor = false;
            this.userJsonOnGameInstall.CheckedChanged += new System.EventHandler(this.userJsonOnGameInstall_CheckedChanged);
            // 
            // crashlogID
            // 
            this.crashlogID.AutoSize = true;
            this.crashlogID.Location = new System.Drawing.Point(13, 439);
            this.crashlogID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crashlogID.Name = "crashlogID";
            this.crashlogID.Size = new System.Drawing.Size(0, 13);
            this.crashlogID.TabIndex = 15;
            // 
            // nodevicemodeBox
            // 
            this.nodevicemodeBox.AutoSize = true;
            this.nodevicemodeBox.BackColor = System.Drawing.Color.Transparent;
            this.nodevicemodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nodevicemodeBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.nodevicemodeBox.Location = new System.Drawing.Point(13, 65);
            this.nodevicemodeBox.Name = "nodevicemodeBox";
            this.nodevicemodeBox.Size = new System.Drawing.Size(226, 22);
            this.nodevicemodeBox.TabIndex = 9;
            this.nodevicemodeBox.Text = "Disable Sideloading (Installing)";
            this.nodevicemodeBox.UseVisualStyleBackColor = false;
            this.nodevicemodeBox.CheckedChanged += new System.EventHandler(this.nodevicemodeBox_CheckedChanged);
            // 
            // bmbfBox
            // 
            this.bmbfBox.AutoSize = true;
            this.bmbfBox.BackColor = System.Drawing.Color.Transparent;
            this.bmbfBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bmbfBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.bmbfBox.Location = new System.Drawing.Point(13, 281);
            this.bmbfBox.Name = "bmbfBox";
            this.bmbfBox.Size = new System.Drawing.Size(281, 22);
            this.bmbfBox.TabIndex = 9;
            this.bmbfBox.Text = "Enable BMBF song zips drag and drop";
            this.bmbfBox.UseVisualStyleBackColor = false;
            this.bmbfBox.CheckedChanged += new System.EventHandler(this.bmbfBox_CheckedChanged);
            // 
            // AutoReinstBox
            // 
            this.AutoReinstBox.AutoSize = true;
            this.AutoReinstBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoReinstBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AutoReinstBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.AutoReinstBox.Location = new System.Drawing.Point(13, 200);
            this.AutoReinstBox.Name = "AutoReinstBox";
            this.AutoReinstBox.Size = new System.Drawing.Size(280, 22);
            this.AutoReinstBox.TabIndex = 9;
            this.AutoReinstBox.Text = "Enable auto reinstall upon install failure";
            this.AutoReinstBox.UseVisualStyleBackColor = false;
            this.AutoReinstBox.CheckedChanged += new System.EventHandler(this.AutoReinstBox_CheckedChanged);
            this.AutoReinstBox.Click += new System.EventHandler(this.AutoReinstBox_Click);
            // 
            // trailersOn
            // 
            this.trailersOn.AutoSize = true;
            this.trailersOn.BackColor = System.Drawing.Color.Transparent;
            this.trailersOn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trailersOn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.trailersOn.Location = new System.Drawing.Point(13, 119);
            this.trailersOn.Name = "trailersOn";
            this.trailersOn.Size = new System.Drawing.Size(255, 22);
            this.trailersOn.TabIndex = 23;
            this.trailersOn.Text = "Use Trailers instead of Thumbnails";
            this.trailersOn.UseVisualStyleBackColor = false;
            this.trailersOn.CheckedChanged += new System.EventHandler(this.trailersOn_CheckedChanged);
            // 
            // downloadDirectorySetter
            // 
            this.downloadDirectorySetter.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // backupDirectorySetter
            // 
            this.backupDirectorySetter.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // chkSingleThread
            // 
            this.chkSingleThread.AutoSize = true;
            this.chkSingleThread.BackColor = System.Drawing.Color.Transparent;
            this.chkSingleThread.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSingleThread.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.chkSingleThread.Location = new System.Drawing.Point(13, 146);
            this.chkSingleThread.Name = "chkSingleThread";
            this.chkSingleThread.Size = new System.Drawing.Size(186, 22);
            this.chkSingleThread.TabIndex = 25;
            this.chkSingleThread.Text = "Enable Single-Threading";
            this.chkSingleThread.UseVisualStyleBackColor = false;
            this.chkSingleThread.CheckedChanged += new System.EventHandler(this.chkSingleThread_CheckedChanged);
            // 
            // setBackupDirectory
            // 
            this.setBackupDirectory.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.setBackupDirectory.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.setBackupDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setBackupDirectory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setBackupDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.setBackupDirectory.ForeColor = System.Drawing.Color.White;
            this.setBackupDirectory.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setBackupDirectory.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setBackupDirectory.Location = new System.Drawing.Point(26, 598);
            this.setBackupDirectory.Name = "setBackupDirectory";
            this.setBackupDirectory.Radius = 5;
            this.setBackupDirectory.Size = new System.Drawing.Size(285, 31);
            this.setBackupDirectory.Stroke = true;
            this.setBackupDirectory.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.setBackupDirectory.TabIndex = 24;
            this.setBackupDirectory.Text = "Set Backup Directory";
            this.setBackupDirectory.Transparency = false;
            this.setBackupDirectory.Click += new System.EventHandler(this.setBackupDirectory_Click);
            // 
            // setDownloadDirectory
            // 
            this.setDownloadDirectory.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.setDownloadDirectory.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.setDownloadDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setDownloadDirectory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setDownloadDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.setDownloadDirectory.ForeColor = System.Drawing.Color.White;
            this.setDownloadDirectory.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setDownloadDirectory.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.setDownloadDirectory.Location = new System.Drawing.Point(26, 561);
            this.setDownloadDirectory.Name = "setDownloadDirectory";
            this.setDownloadDirectory.Radius = 5;
            this.setDownloadDirectory.Size = new System.Drawing.Size(285, 31);
            this.setDownloadDirectory.Stroke = true;
            this.setDownloadDirectory.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.setDownloadDirectory.TabIndex = 23;
            this.setDownloadDirectory.Text = "Set Download Directory";
            this.setDownloadDirectory.Transparency = false;
            this.setDownloadDirectory.Click += new System.EventHandler(this.setDownloadDirectory_Click);
            // 
            // btnOpenDebug
            // 
            this.btnOpenDebug.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOpenDebug.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOpenDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOpenDebug.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpenDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnOpenDebug.ForeColor = System.Drawing.Color.White;
            this.btnOpenDebug.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOpenDebug.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOpenDebug.Location = new System.Drawing.Point(25, 434);
            this.btnOpenDebug.Name = "btnOpenDebug";
            this.btnOpenDebug.Radius = 5;
            this.btnOpenDebug.Size = new System.Drawing.Size(285, 31);
            this.btnOpenDebug.Stroke = true;
            this.btnOpenDebug.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOpenDebug.TabIndex = 21;
            this.btnOpenDebug.Text = "Open Debug Log";
            this.btnOpenDebug.Transparency = false;
            this.btnOpenDebug.Click += new System.EventHandler(this.btnOpenDebug_Click);
            // 
            // btnResetDebug
            // 
            this.btnResetDebug.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnResetDebug.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnResetDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnResetDebug.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResetDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnResetDebug.ForeColor = System.Drawing.Color.White;
            this.btnResetDebug.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnResetDebug.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnResetDebug.Location = new System.Drawing.Point(25, 471);
            this.btnResetDebug.Name = "btnResetDebug";
            this.btnResetDebug.Radius = 5;
            this.btnResetDebug.Size = new System.Drawing.Size(285, 31);
            this.btnResetDebug.Stroke = true;
            this.btnResetDebug.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnResetDebug.TabIndex = 20;
            this.btnResetDebug.Text = "Reset Debug Log";
            this.btnResetDebug.Transparency = false;
            this.btnResetDebug.Click += new System.EventHandler(this.btnResetDebug_click);
            // 
            // btnUploadDebug
            // 
            this.btnUploadDebug.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUploadDebug.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUploadDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUploadDebug.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUploadDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnUploadDebug.ForeColor = System.Drawing.Color.White;
            this.btnUploadDebug.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUploadDebug.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUploadDebug.Location = new System.Drawing.Point(25, 508);
            this.btnUploadDebug.Name = "btnUploadDebug";
            this.btnUploadDebug.Radius = 5;
            this.btnUploadDebug.Size = new System.Drawing.Size(285, 31);
            this.btnUploadDebug.Stroke = true;
            this.btnUploadDebug.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnUploadDebug.TabIndex = 19;
            this.btnUploadDebug.Text = "Upload Debug Log";
            this.btnUploadDebug.Transparency = false;
            this.btnUploadDebug.Click += new System.EventHandler(this.btnUploadDebug_click);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetSettingsButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.resetSettingsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.resetSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.resetSettingsButton.ForeColor = System.Drawing.Color.White;
            this.resetSettingsButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.resetSettingsButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.resetSettingsButton.Location = new System.Drawing.Point(178, 381);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Radius = 5;
            this.resetSettingsButton.Size = new System.Drawing.Size(133, 31);
            this.resetSettingsButton.Stroke = true;
            this.resetSettingsButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.resetSettingsButton.TabIndex = 18;
            this.resetSettingsButton.Text = "Reset Settings";
            this.resetSettingsButton.Transparency = false;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.applyButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.applyButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.applyButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.applyButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.applyButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.applyButton.Location = new System.Drawing.Point(26, 381);
            this.applyButton.Name = "applyButton";
            this.applyButton.Radius = 5;
            this.applyButton.Size = new System.Drawing.Size(133, 31);
            this.applyButton.Stroke = true;
            this.applyButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.applyButton.TabIndex = 17;
            this.applyButton.Text = "Apply Settings";
            this.applyButton.Transparency = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // virtualFilesystemCompatibilityCheckbox
            // 
            this.virtualFilesystemCompatibilityCheckbox.AutoSize = true;
            this.virtualFilesystemCompatibilityCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.virtualFilesystemCompatibilityCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.virtualFilesystemCompatibilityCheckbox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.virtualFilesystemCompatibilityCheckbox.Location = new System.Drawing.Point(13, 308);
            this.virtualFilesystemCompatibilityCheckbox.Name = "virtualFilesystemCompatibilityCheckbox";
            this.virtualFilesystemCompatibilityCheckbox.Size = new System.Drawing.Size(279, 22);
            this.virtualFilesystemCompatibilityCheckbox.TabIndex = 26;
            this.virtualFilesystemCompatibilityCheckbox.Text = "Enable Virtual Filesystem Compatibility";
            this.virtualFilesystemCompatibilityCheckbox.UseVisualStyleBackColor = true;
            this.virtualFilesystemCompatibilityCheckbox.CheckedChanged += new System.EventHandler(this.virtualFilesystemCompatibilityCheckbox_CheckedChanged);
            // 
            // openBackupDirectory
            // 
            this.openBackupDirectory.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openBackupDirectory.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openBackupDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBackupDirectory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.openBackupDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openBackupDirectory.ForeColor = System.Drawing.Color.White;
            this.openBackupDirectory.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBackupDirectory.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBackupDirectory.Location = new System.Drawing.Point(26, 672);
            this.openBackupDirectory.Name = "openBackupDirectory";
            this.openBackupDirectory.Radius = 5;
            this.openBackupDirectory.Size = new System.Drawing.Size(285, 31);
            this.openBackupDirectory.Stroke = true;
            this.openBackupDirectory.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.openBackupDirectory.TabIndex = 28;
            this.openBackupDirectory.Text = "Open Backup Directory";
            this.openBackupDirectory.Transparency = false;
            this.openBackupDirectory.Click += new System.EventHandler(this.openBackupDirectory_Click);
            // 
            // openDownloadDirectory
            // 
            this.openDownloadDirectory.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openDownloadDirectory.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openDownloadDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openDownloadDirectory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.openDownloadDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openDownloadDirectory.ForeColor = System.Drawing.Color.White;
            this.openDownloadDirectory.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openDownloadDirectory.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openDownloadDirectory.Location = new System.Drawing.Point(26, 635);
            this.openDownloadDirectory.Name = "openDownloadDirectory";
            this.openDownloadDirectory.Radius = 5;
            this.openDownloadDirectory.Size = new System.Drawing.Size(285, 31);
            this.openDownloadDirectory.Stroke = true;
            this.openDownloadDirectory.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.openDownloadDirectory.TabIndex = 27;
            this.openDownloadDirectory.Text = "Open Download Directory";
            this.openDownloadDirectory.Transparency = false;
            this.openDownloadDirectory.Click += new System.EventHandler(this.openDownloadDirectory_Click);
            // 
            // chkUseDownloadedFiles
            // 
            this.chkUseDownloadedFiles.AutoSize = true;
            this.chkUseDownloadedFiles.BackColor = System.Drawing.Color.Transparent;
            this.chkUseDownloadedFiles.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseDownloadedFiles.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.chkUseDownloadedFiles.Location = new System.Drawing.Point(13, 173);
            this.chkUseDownloadedFiles.Name = "chkUseDownloadedFiles";
            this.chkUseDownloadedFiles.Size = new System.Drawing.Size(227, 22);
            this.chkUseDownloadedFiles.TabIndex = 29;
            this.chkUseDownloadedFiles.Text = "Don\'t Prompt to Re-Download";
            this.chkUseDownloadedFiles.UseVisualStyleBackColor = false;
            this.chkUseDownloadedFiles.CheckedChanged += new System.EventHandler(this.chkUseDownloadedFiles_CheckedChanged);
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.BackColor = System.Drawing.Color.Transparent;
            this.bandwidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.bandwidthLabel.Location = new System.Drawing.Point(8, 340);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(115, 18);
            this.bandwidthLabel.TabIndex = 30;
            this.bandwidthLabel.Text = "Bandwidth Limit:";
            this.bandwidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bandwidthLimitTextBox
            // 
            this.bandwidthLimitTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bandwidthLimitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bandwidthLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandwidthLimitTextBox.ForeColor = System.Drawing.Color.White;
            this.bandwidthLimitTextBox.Location = new System.Drawing.Point(129, 338);
            this.bandwidthLimitTextBox.Name = "bandwidthLimitTextBox";
            this.bandwidthLimitTextBox.Size = new System.Drawing.Size(46, 21);
            this.bandwidthLimitTextBox.TabIndex = 31;
            this.bandwidthLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bandwidthLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bandwidthLimitTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(181, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "MB/s";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(339, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bandwidthLimitTextBox);
            this.Controls.Add(this.bandwidthLabel);
            this.Controls.Add(this.chkUseDownloadedFiles);
            this.Controls.Add(this.openBackupDirectory);
            this.Controls.Add(this.openDownloadDirectory);
            this.Controls.Add(this.virtualFilesystemCompatibilityCheckbox);
            this.Controls.Add(this.chkSingleThread);
            this.Controls.Add(this.setBackupDirectory);
            this.Controls.Add(this.trailersOn);
            this.Controls.Add(this.setDownloadDirectory);
            this.Controls.Add(this.btnOpenDebug);
            this.Controls.Add(this.btnResetDebug);
            this.Controls.Add(this.btnUploadDebug);
            this.Controls.Add(this.resetSettingsButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.crashlogID);
            this.Controls.Add(this.bmbfBox);
            this.Controls.Add(this.AutoReinstBox);
            this.Controls.Add(this.nodevicemodeBox);
            this.Controls.Add(this.userJsonOnGameInstall);
            this.Controls.Add(this.updateConfigCheckBox);
            this.Controls.Add(this.deleteAfterInstallCheckBox);
            this.Controls.Add(this.enableMessageBoxesCheckBox);
            this.Controls.Add(this.checkForUpdatesCheckBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsForm_KeyPress);
            this.Leave += new System.EventHandler(this.SettingsForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkForUpdatesCheckBox;
        private System.Windows.Forms.CheckBox enableMessageBoxesCheckBox;
        private System.Windows.Forms.CheckBox deleteAfterInstallCheckBox;
        private System.Windows.Forms.CheckBox updateConfigCheckBox;
        private System.Windows.Forms.CheckBox userJsonOnGameInstall;
        private System.Windows.Forms.Label crashlogID;
        private System.Windows.Forms.CheckBox nodevicemodeBox;
        private System.Windows.Forms.CheckBox bmbfBox;
        private System.Windows.Forms.CheckBox AutoReinstBox;
        private RoundButton applyButton;
        private RoundButton resetSettingsButton;
        private RoundButton btnResetDebug;
        private RoundButton btnUploadDebug;
        private RoundButton btnOpenDebug;
        private System.Windows.Forms.CheckBox trailersOn;
        private RoundButton setDownloadDirectory;
        private System.Windows.Forms.FolderBrowserDialog downloadDirectorySetter;
        private RoundButton setBackupDirectory;
        private System.Windows.Forms.FolderBrowserDialog backupDirectorySetter;
        private System.Windows.Forms.CheckBox chkSingleThread;
        private System.Windows.Forms.CheckBox virtualFilesystemCompatibilityCheckbox;
        private RoundButton openBackupDirectory;
        private RoundButton openDownloadDirectory;
        private System.Windows.Forms.CheckBox chkUseDownloadedFiles;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.TextBox bandwidthLimitTextBox;
        private System.Windows.Forms.Label label1;
    }
}
