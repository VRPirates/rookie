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
            this.enableMessageBoxesCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteAfterInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.updateConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.userJsonOnGameInstall = new System.Windows.Forms.CheckBox();
            this.BandwithTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BandwithComboBox = new System.Windows.Forms.ComboBox();
            this.crashlogID = new System.Windows.Forms.Label();
            this.debuglogID = new System.Windows.Forms.Label();
            this.DebugID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nodevicemodeBox = new System.Windows.Forms.CheckBox();
            this.bmbfBox = new System.Windows.Forms.CheckBox();
            this.AutoReinstBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new AndroidSideloader.RoundButton();
            this.resetSettingsButton = new AndroidSideloader.RoundButton();
            this.DebugLogCopy = new AndroidSideloader.RoundButton();
            this.Button1 = new AndroidSideloader.RoundButton();
            this.SuspendLayout();
            // 
            // checkForUpdatesCheckBox
            // 
            this.checkForUpdatesCheckBox.AutoSize = true;
            this.checkForUpdatesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.checkForUpdatesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkForUpdatesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.checkForUpdatesCheckBox.Location = new System.Drawing.Point(12, 12);
            this.checkForUpdatesCheckBox.Name = "checkForUpdatesCheckBox";
            this.checkForUpdatesCheckBox.Size = new System.Drawing.Size(148, 22);
            this.checkForUpdatesCheckBox.TabIndex = 0;
            this.checkForUpdatesCheckBox.Text = "Check for updates";
            this.checkForUpdatesCheckBox.UseVisualStyleBackColor = false;
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
            this.applyButton.Location = new System.Drawing.Point(67, 328);
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
            this.enableMessageBoxesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.enableMessageBoxesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableMessageBoxesCheckBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.enableMessageBoxesCheckBox.Location = new System.Drawing.Point(12, 38);
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
            this.deleteAfterInstallCheckBox.Location = new System.Drawing.Point(12, 64);
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
            this.updateConfigCheckBox.Location = new System.Drawing.Point(12, 90);
            this.updateConfigCheckBox.Name = "updateConfigCheckBox";
            this.updateConfigCheckBox.Size = new System.Drawing.Size(208, 22);
            this.updateConfigCheckBox.TabIndex = 6;
            this.updateConfigCheckBox.Text = "Update config automatically";
            this.updateConfigCheckBox.UseVisualStyleBackColor = false;
            this.updateConfigCheckBox.CheckedChanged += new System.EventHandler(this.updateConfigCheckBox_CheckedChanged);
            // 
            // userJsonOnGameInstall
            // 
            this.userJsonOnGameInstall.AutoSize = true;
            this.userJsonOnGameInstall.BackColor = System.Drawing.Color.Transparent;
            this.userJsonOnGameInstall.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userJsonOnGameInstall.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.userJsonOnGameInstall.Location = new System.Drawing.Point(12, 116);
            this.userJsonOnGameInstall.Name = "userJsonOnGameInstall";
            this.userJsonOnGameInstall.Size = new System.Drawing.Size(243, 22);
            this.userJsonOnGameInstall.TabIndex = 9;
            this.userJsonOnGameInstall.Text = "Push random user.json on install";
            this.userJsonOnGameInstall.UseVisualStyleBackColor = false;
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
            this.BandwithTextbox.Location = new System.Drawing.Point(29, 248);
            this.BandwithTextbox.Name = "BandwithTextbox";
            this.BandwithTextbox.Size = new System.Drawing.Size(177, 24);
            this.BandwithTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label1.Location = new System.Drawing.Point(48, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
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
            this.BandwithComboBox.Location = new System.Drawing.Point(258, 246);
            this.BandwithComboBox.Name = "BandwithComboBox";
            this.BandwithComboBox.Size = new System.Drawing.Size(55, 26);
            this.BandwithComboBox.TabIndex = 13;
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
            // debuglogID
            // 
            this.debuglogID.BackColor = System.Drawing.Color.Transparent;
            this.debuglogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.debuglogID.Location = new System.Drawing.Point(29, 434);
            this.debuglogID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debuglogID.Name = "debuglogID";
            this.debuglogID.Size = new System.Drawing.Size(285, 48);
            this.debuglogID.TabIndex = 14;
            this.debuglogID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DebugID
            // 
            this.DebugID.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.DebugID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugID.Cursor = System.Windows.Forms.Cursors.Default;
            this.DebugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.DebugID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugID.Location = new System.Drawing.Point(29, 405);
            this.DebugID.Margin = new System.Windows.Forms.Padding(2);
            this.DebugID.Name = "DebugID";
            this.DebugID.ReadOnly = true;
            this.DebugID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DebugID.Size = new System.Drawing.Size(285, 21);
            this.DebugID.TabIndex = 16;
            this.DebugID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DebugID.Click += new System.EventHandler(this.DebugID_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(29, 505);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 86);
            this.label2.TabIndex = 14;
            this.label2.Text = "This is your most recent CrashLogID. Click on the CrashLogID to copy it to your c" +
    "lipboard.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(29, 488);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(285, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // nodevicemodeBox
            // 
            this.nodevicemodeBox.AutoSize = true;
            this.nodevicemodeBox.BackColor = System.Drawing.Color.Transparent;
            this.nodevicemodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nodevicemodeBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.nodevicemodeBox.Location = new System.Drawing.Point(12, 168);
            this.nodevicemodeBox.Name = "nodevicemodeBox";
            this.nodevicemodeBox.Size = new System.Drawing.Size(181, 22);
            this.nodevicemodeBox.TabIndex = 9;
            this.nodevicemodeBox.Text = "Enable no device mode";
            this.nodevicemodeBox.UseVisualStyleBackColor = false;
            this.nodevicemodeBox.CheckedChanged += new System.EventHandler(this.nodevicemodeBox_CheckedChanged);
            // 
            // bmbfBox
            // 
            this.bmbfBox.AutoSize = true;
            this.bmbfBox.BackColor = System.Drawing.Color.Transparent;
            this.bmbfBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bmbfBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.bmbfBox.Location = new System.Drawing.Point(12, 142);
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
            this.AutoReinstBox.Location = new System.Drawing.Point(12, 194);
            this.AutoReinstBox.Name = "AutoReinstBox";
            this.AutoReinstBox.Size = new System.Drawing.Size(280, 22);
            this.AutoReinstBox.TabIndex = 9;
            this.AutoReinstBox.Text = "Enable auto reinstall upon install failure";
            this.AutoReinstBox.UseVisualStyleBackColor = false;
            this.AutoReinstBox.CheckedChanged += new System.EventHandler(this.AutoReinstBox_CheckedChanged);
            this.AutoReinstBox.Click += new System.EventHandler(this.AutoReinstBox_Click);
            // 
            // applyButton
            // 
            this.applyButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.applyButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.applyButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.applyButton.Location = new System.Drawing.Point(29, 286);
            this.applyButton.Name = "applyButton";
            this.applyButton.Radius = 5;
            this.applyButton.Size = new System.Drawing.Size(101, 31);
            this.applyButton.Stroke = true;
            this.applyButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.applyButton.TabIndex = 17;
            this.applyButton.Text = "Apply";
            this.applyButton.Transparency = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
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
            this.resetSettingsButton.Location = new System.Drawing.Point(212, 286);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Radius = 5;
            this.resetSettingsButton.Size = new System.Drawing.Size(101, 31);
            this.resetSettingsButton.Stroke = true;
            this.resetSettingsButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.resetSettingsButton.TabIndex = 18;
            this.resetSettingsButton.Text = "Reset";
            this.resetSettingsButton.Transparency = false;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // DebugLogCopy
            // 
            this.DebugLogCopy.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DebugLogCopy.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DebugLogCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugLogCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DebugLogCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DebugLogCopy.ForeColor = System.Drawing.Color.White;
            this.DebugLogCopy.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugLogCopy.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugLogCopy.Location = new System.Drawing.Point(29, 323);
            this.DebugLogCopy.Name = "DebugLogCopy";
            this.DebugLogCopy.Radius = 5;
            this.DebugLogCopy.Size = new System.Drawing.Size(285, 31);
            this.DebugLogCopy.Stroke = true;
            this.DebugLogCopy.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.DebugLogCopy.TabIndex = 19;
            this.DebugLogCopy.Text = "Send DebugLog to server.";
            this.DebugLogCopy.Transparency = false;
            this.DebugLogCopy.Click += new System.EventHandler(this.DebugLogCopy_click);
            // 
            // Button1
            // 
            this.Button1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button1.Location = new System.Drawing.Point(29, 358);
            this.Button1.Name = "Button1";
            this.Button1.Radius = 5;
            this.Button1.Size = new System.Drawing.Size(285, 31);
            this.Button1.Stroke = true;
            this.Button1.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Button1.TabIndex = 20;
            this.Button1.Text = "Reset Debug Log";
            this.Button1.Transparency = false;
            this.Button1.Click += new System.EventHandler(this.button1_click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.ClientSize = new System.Drawing.Size(342, 601);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DebugLogCopy);
            this.Controls.Add(this.resetSettingsButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DebugID);
            this.Controls.Add(this.crashlogID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.debuglogID);
            this.Controls.Add(this.BandwithComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BandwithTextbox);
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
        private System.Windows.Forms.TextBox BandwithTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BandwithComboBox;
        private System.Windows.Forms.Label crashlogID;
        public System.Windows.Forms.Label debuglogID;
        private System.Windows.Forms.TextBox DebugID;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox nodevicemodeBox;
        private System.Windows.Forms.CheckBox bmbfBox;
        private System.Windows.Forms.CheckBox AutoReinstBox;
        private RoundButton applyButton;
        private RoundButton resetSettingsButton;
        private RoundButton DebugLogCopy;
        private RoundButton Button1;
    }
}