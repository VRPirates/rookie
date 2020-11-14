namespace AndroidSideloader
{
    partial class Form1
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
            this.m_combo = new SergeUtils.EasyCompletionComboBox();
            this.startsideloadbutton = new System.Windows.Forms.Button();
            this.devicesbutton = new System.Windows.Forms.Button();
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.getApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.sideloadFolderButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.copyBulkObbButton = new System.Windows.Forms.Button();
            this.DragDropLbl = new System.Windows.Forms.Label();
            this.downloadInstallGameButton = new System.Windows.Forms.Button();
            this.gamesComboBox = new SergeUtils.EasyCompletionComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.otherContainer = new System.Windows.Forms.Panel();
            this.ThemeChangerButton = new System.Windows.Forms.Button();
            this.SpoofFormButton = new System.Windows.Forms.Button();
            this.QuestOptionsButton = new System.Windows.Forms.Button();
            this.killRcloneButton = new System.Windows.Forms.Button();
            this.movieStreamButton = new System.Windows.Forms.Button();
            this.userjsonButton = new System.Windows.Forms.Button();
            this.otherDrop = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.listApkButton = new System.Windows.Forms.Button();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etaLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.diskLabel = new System.Windows.Forms.Label();
            this.gamesQueListBox = new System.Windows.Forms.ListBox();
            this.freeDisclaimer = new System.Windows.Forms.Label();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.remotesList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.otherContainer.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.m_combo.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.m_combo.Location = new System.Drawing.Point(224, 11);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(504, 26);
            this.m_combo.TabIndex = 19;
            this.m_combo.Text = "Select an app from here...";
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startsideloadbutton.FlatAppearance.BorderSize = 0;
            this.startsideloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsideloadbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.startsideloadbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 140);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(218, 28);
            this.startsideloadbutton.TabIndex = 7;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startsideloadbutton.UseVisualStyleBackColor = false;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesbutton.FlatAppearance.BorderSize = 0;
            this.devicesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesbutton.Location = new System.Drawing.Point(0, 0);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(218, 28);
            this.devicesbutton.TabIndex = 0;
            this.devicesbutton.Text = "ADB DEVICES";
            this.devicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesbutton.UseVisualStyleBackColor = false;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.obbcopybutton.FlatAppearance.BorderSize = 0;
            this.obbcopybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obbcopybutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.obbcopybutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.obbcopybutton.Location = new System.Drawing.Point(0, 0);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(218, 28);
            this.obbcopybutton.TabIndex = 2;
            this.obbcopybutton.Text = "Copy Obb";
            this.obbcopybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obbcopybutton.UseVisualStyleBackColor = false;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupbutton.Location = new System.Drawing.Point(0, 28);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(218, 28);
            this.backupbutton.TabIndex = 11;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.restorebutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.restorebutton.Location = new System.Drawing.Point(0, 0);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(218, 28);
            this.restorebutton.TabIndex = 10;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.getApkButton.FlatAppearance.BorderSize = 0;
            this.getApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.getApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.getApkButton.Location = new System.Drawing.Point(0, 56);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(218, 28);
            this.getApkButton.TabIndex = 4;
            this.getApkButton.Text = "Get Apk";
            this.getApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getApkButton.UseVisualStyleBackColor = false;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallAppButton.FlatAppearance.BorderSize = 0;
            this.uninstallAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallAppButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.uninstallAppButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 84);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(218, 28);
            this.uninstallAppButton.TabIndex = 5;
            this.uninstallAppButton.Text = "Uninstall App";
            this.uninstallAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallAppButton.UseVisualStyleBackColor = false;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // sideloadFolderButton
            // 
            this.sideloadFolderButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadFolderButton.FlatAppearance.BorderSize = 0;
            this.sideloadFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadFolderButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadFolderButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadFolderButton.Location = new System.Drawing.Point(0, 112);
            this.sideloadFolderButton.Name = "sideloadFolderButton";
            this.sideloadFolderButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.sideloadFolderButton.Size = new System.Drawing.Size(218, 28);
            this.sideloadFolderButton.TabIndex = 6;
            this.sideloadFolderButton.Text = "Sideload Folder";
            this.sideloadFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadFolderButton.UseVisualStyleBackColor = false;
            this.sideloadFolderButton.Click += new System.EventHandler(this.sideloadFolderButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ForeColor = System.Drawing.Color.Purple;
            this.progressBar.Location = new System.Drawing.Point(224, 43);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(504, 20);
            this.progressBar.TabIndex = 20;
            // 
            // copyBulkObbButton
            // 
            this.copyBulkObbButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyBulkObbButton.FlatAppearance.BorderSize = 0;
            this.copyBulkObbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBulkObbButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.copyBulkObbButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 28);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(218, 28);
            this.copyBulkObbButton.TabIndex = 3;
            this.copyBulkObbButton.Text = "Copy Bulk Obb";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton.UseVisualStyleBackColor = false;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.DragDropLbl.Location = new System.Drawing.Point(208, 566);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(320, 55);
            this.DragDropLbl.TabIndex = 25;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // downloadInstallGameButton
            // 
            this.downloadInstallGameButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.Enabled = false;
            this.downloadInstallGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadInstallGameButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.downloadInstallGameButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.downloadInstallGameButton.Location = new System.Drawing.Point(224, 101);
            this.downloadInstallGameButton.Name = "downloadInstallGameButton";
            this.downloadInstallGameButton.Size = new System.Drawing.Size(503, 30);
            this.downloadInstallGameButton.TabIndex = 22;
            this.downloadInstallGameButton.Text = "Download and Install Game";
            this.downloadInstallGameButton.UseVisualStyleBackColor = false;
            this.downloadInstallGameButton.Click += new System.EventHandler(this.downloadInstallGameButton_Click);
            // 
            // gamesComboBox
            // 
            this.gamesComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.gamesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesComboBox.Location = new System.Drawing.Point(224, 69);
            this.gamesComboBox.Name = "gamesComboBox";
            this.gamesComboBox.Size = new System.Drawing.Size(504, 26);
            this.gamesComboBox.Sorted = true;
            this.gamesComboBox.TabIndex = 21;
            this.gamesComboBox.Text = "Select a game from here...";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.otherContainer);
            this.panel1.Controls.Add(this.otherDrop);
            this.panel1.Controls.Add(this.backupContainer);
            this.panel1.Controls.Add(this.backupDrop);
            this.panel1.Controls.Add(this.sideloadContainer);
            this.panel1.Controls.Add(this.sideloadDrop);
            this.panel1.Controls.Add(this.devicesbutton);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 659);
            this.panel1.TabIndex = 73;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.aboutBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.aboutBtn.Location = new System.Drawing.Point(0, 577);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(218, 28);
            this.aboutBtn.TabIndex = 82;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.settingsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.settingsButton.Location = new System.Drawing.Point(0, 549);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(218, 28);
            this.settingsButton.TabIndex = 81;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // otherContainer
            // 
            this.otherContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.otherContainer.Controls.Add(this.ThemeChangerButton);
            this.otherContainer.Controls.Add(this.SpoofFormButton);
            this.otherContainer.Controls.Add(this.QuestOptionsButton);
            this.otherContainer.Controls.Add(this.killRcloneButton);
            this.otherContainer.Controls.Add(this.movieStreamButton);
            this.otherContainer.Controls.Add(this.userjsonButton);
            this.otherContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherContainer.Location = new System.Drawing.Point(0, 373);
            this.otherContainer.Margin = new System.Windows.Forms.Padding(2);
            this.otherContainer.Name = "otherContainer";
            this.otherContainer.Size = new System.Drawing.Size(218, 176);
            this.otherContainer.TabIndex = 80;
            // 
            // ThemeChangerButton
            // 
            this.ThemeChangerButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemeChangerButton.FlatAppearance.BorderSize = 0;
            this.ThemeChangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeChangerButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ThemeChangerButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ThemeChangerButton.Location = new System.Drawing.Point(0, 140);
            this.ThemeChangerButton.Name = "ThemeChangerButton";
            this.ThemeChangerButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.ThemeChangerButton.Size = new System.Drawing.Size(218, 28);
            this.ThemeChangerButton.TabIndex = 18;
            this.ThemeChangerButton.Text = "Theme Changer";
            this.ThemeChangerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemeChangerButton.UseVisualStyleBackColor = false;
            this.ThemeChangerButton.Click += new System.EventHandler(this.ThemeChangerButton_Click);
            // 
            // SpoofFormButton
            // 
            this.SpoofFormButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.SpoofFormButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofFormButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofFormButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpoofFormButton.FlatAppearance.BorderSize = 0;
            this.SpoofFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofFormButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.SpoofFormButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.SpoofFormButton.Location = new System.Drawing.Point(0, 112);
            this.SpoofFormButton.Name = "SpoofFormButton";
            this.SpoofFormButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.SpoofFormButton.Size = new System.Drawing.Size(218, 28);
            this.SpoofFormButton.TabIndex = 17;
            this.SpoofFormButton.Text = "SPOOF";
            this.SpoofFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpoofFormButton.UseVisualStyleBackColor = false;
            this.SpoofFormButton.Click += new System.EventHandler(this.SpoofFormButton_Click);
            // 
            // QuestOptionsButton
            // 
            this.QuestOptionsButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestOptionsButton.FlatAppearance.BorderSize = 0;
            this.QuestOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestOptionsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QuestOptionsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QuestOptionsButton.Location = new System.Drawing.Point(0, 84);
            this.QuestOptionsButton.Name = "QuestOptionsButton";
            this.QuestOptionsButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.QuestOptionsButton.Size = new System.Drawing.Size(218, 28);
            this.QuestOptionsButton.TabIndex = 16;
            this.QuestOptionsButton.Text = "QUEST OPTIONS";
            this.QuestOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestOptionsButton.UseVisualStyleBackColor = false;
            this.QuestOptionsButton.Click += new System.EventHandler(this.QuestOptionsButton_Click);
            // 
            // killRcloneButton
            // 
            this.killRcloneButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.killRcloneButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.killRcloneButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.killRcloneButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.killRcloneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.killRcloneButton.FlatAppearance.BorderSize = 0;
            this.killRcloneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killRcloneButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.killRcloneButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.killRcloneButton.Location = new System.Drawing.Point(0, 56);
            this.killRcloneButton.Name = "killRcloneButton";
            this.killRcloneButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.killRcloneButton.Size = new System.Drawing.Size(218, 28);
            this.killRcloneButton.TabIndex = 15;
            this.killRcloneButton.Text = "KILL RCLONE";
            this.killRcloneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.killRcloneButton.UseVisualStyleBackColor = false;
            this.killRcloneButton.Click += new System.EventHandler(this.killRcloneButton_Click);
            // 
            // movieStreamButton
            // 
            this.movieStreamButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.movieStreamButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.movieStreamButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.movieStreamButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.movieStreamButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieStreamButton.FlatAppearance.BorderSize = 0;
            this.movieStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieStreamButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.movieStreamButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.movieStreamButton.Location = new System.Drawing.Point(0, 28);
            this.movieStreamButton.Name = "movieStreamButton";
            this.movieStreamButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.movieStreamButton.Size = new System.Drawing.Size(218, 28);
            this.movieStreamButton.TabIndex = 14;
            this.movieStreamButton.Text = "START MOVIE STREAM";
            this.movieStreamButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movieStreamButton.UseVisualStyleBackColor = false;
            this.movieStreamButton.Click += new System.EventHandler(this.movieStreamButton_Click);
            // 
            // userjsonButton
            // 
            this.userjsonButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userjsonButton.FlatAppearance.BorderSize = 0;
            this.userjsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userjsonButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.userjsonButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.userjsonButton.Location = new System.Drawing.Point(0, 0);
            this.userjsonButton.Name = "userjsonButton";
            this.userjsonButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.userjsonButton.Size = new System.Drawing.Size(218, 28);
            this.userjsonButton.TabIndex = 11;
            this.userjsonButton.Text = "USER.JSON";
            this.userjsonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userjsonButton.UseVisualStyleBackColor = false;
            this.userjsonButton.Click += new System.EventHandler(this.userjsonButton_Click);
            // 
            // otherDrop
            // 
            this.otherDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherDrop.FlatAppearance.BorderSize = 0;
            this.otherDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.otherDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.otherDrop.Location = new System.Drawing.Point(0, 345);
            this.otherDrop.Margin = new System.Windows.Forms.Padding(2);
            this.otherDrop.Name = "otherDrop";
            this.otherDrop.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.otherDrop.Size = new System.Drawing.Size(218, 28);
            this.otherDrop.TabIndex = 77;
            this.otherDrop.Text = "OTHER";
            this.otherDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otherDrop.UseVisualStyleBackColor = false;
            this.otherDrop.Click += new System.EventHandler(this.otherDrop_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 285);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(218, 60);
            this.backupContainer.TabIndex = 76;
            // 
            // backupDrop
            // 
            this.backupDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupDrop.FlatAppearance.BorderSize = 0;
            this.backupDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupDrop.Location = new System.Drawing.Point(0, 257);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.backupDrop.Size = new System.Drawing.Size(218, 28);
            this.backupDrop.TabIndex = 9;
            this.backupDrop.Text = "BACKUP";
            this.backupDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupDrop.UseVisualStyleBackColor = false;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadContainer.Controls.Add(this.listApkButton);
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.sideloadFolderButton);
            this.sideloadContainer.Controls.Add(this.uninstallAppButton);
            this.sideloadContainer.Controls.Add(this.getApkButton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 56);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(218, 201);
            this.sideloadContainer.TabIndex = 74;
            // 
            // listApkButton
            // 
            this.listApkButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listApkButton.FlatAppearance.BorderSize = 0;
            this.listApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.listApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.listApkButton.Location = new System.Drawing.Point(0, 168);
            this.listApkButton.Name = "listApkButton";
            this.listApkButton.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.listApkButton.Size = new System.Drawing.Size(218, 28);
            this.listApkButton.TabIndex = 8;
            this.listApkButton.Text = "Refresh Apk, Games, Space";
            this.listApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listApkButton.UseVisualStyleBackColor = false;
            this.listApkButton.Click += new System.EventHandler(this.listApkButton_Click);
            // 
            // sideloadDrop
            // 
            this.sideloadDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadDrop.FlatAppearance.BorderSize = 0;
            this.sideloadDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadDrop.Location = new System.Drawing.Point(0, 28);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.sideloadDrop.Size = new System.Drawing.Size(218, 28);
            this.sideloadDrop.TabIndex = 1;
            this.sideloadDrop.Text = "SIDELOAD";
            this.sideloadDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadDrop.UseVisualStyleBackColor = false;
            this.sideloadDrop.Click += new System.EventHandler(this.sideloadContainer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::AndroidSideloader.Properties.Settings.Default, "BackPicturePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = global::AndroidSideloader.Properties.Settings.Default.BackPicturePath;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(217, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // etaLabel
            // 
            this.etaLabel.AutoSize = true;
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.etaLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.etaLabel.Location = new System.Drawing.Point(222, 382);
            this.etaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(148, 18);
            this.etaLabel.TabIndex = 75;
            this.etaLabel.Text = "ETA: HH:MM:SS Left";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.speedLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.speedLabel.Location = new System.Drawing.Point(222, 364);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(149, 18);
            this.speedLabel.TabIndex = 76;
            this.speedLabel.Text = "DLS: Speed in MBPS";
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.diskLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.diskLabel.Location = new System.Drawing.Point(223, 302);
            this.diskLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(77, 18);
            this.diskLabel.TabIndex = 77;
            this.diskLabel.Text = "Disk Label";
            // 
            // gamesQueListBox
            // 
            this.gamesQueListBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.gamesQueListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gamesQueListBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueListBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueListBox.FormattingEnabled = true;
            this.gamesQueListBox.ItemHeight = 18;
            this.gamesQueListBox.Location = new System.Drawing.Point(224, 172);
            this.gamesQueListBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamesQueListBox.Name = "gamesQueListBox";
            this.gamesQueListBox.Size = new System.Drawing.Size(504, 128);
            this.gamesQueListBox.TabIndex = 78;
            this.gamesQueListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamesQueListBox_MouseClick);
            // 
            // freeDisclaimer
            // 
            this.freeDisclaimer.AutoSize = true;
            this.freeDisclaimer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.freeDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeDisclaimer.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.freeDisclaimer.Location = new System.Drawing.Point(220, 622);
            this.freeDisclaimer.Name = "freeDisclaimer";
            this.freeDisclaimer.Size = new System.Drawing.Size(487, 24);
            this.freeDisclaimer.TabIndex = 79;
            this.freeDisclaimer.Text = "This software is free, if you paid for it, you got SCAMMED!";
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(224, 142);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(153, 26);
            this.devicesComboBox.TabIndex = 80;
            this.devicesComboBox.Text = "Select your device";
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // remotesList
            // 
            this.remotesList.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remotesList.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.remotesList.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.remotesList.FormattingEnabled = true;
            this.remotesList.Location = new System.Drawing.Point(381, 142);
            this.remotesList.Margin = new System.Windows.Forms.Padding(2);
            this.remotesList.Name = "remotesList";
            this.remotesList.Size = new System.Drawing.Size(153, 26);
            this.remotesList.TabIndex = 81;
            this.remotesList.Text = "Select a mirror";
            this.remotesList.SelectedIndexChanged += new System.EventHandler(this.remotesList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(738, 659);
            this.Controls.Add(this.remotesList);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.gamesQueListBox);
            this.Controls.Add(this.diskLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.etaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamesComboBox);
            this.Controls.Add(this.downloadInstallGameButton);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.freeDisclaimer);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 698);
            this.MinimumSize = new System.Drawing.Size(754, 698);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rookie's SideLoader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.panel1.ResumeLayout(false);
            this.otherContainer.ResumeLayout(false);
            this.backupContainer.ResumeLayout(false);
            this.sideloadContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startsideloadbutton;
        private System.Windows.Forms.Button devicesbutton;
        private System.Windows.Forms.Button obbcopybutton;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button getApkButton;
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.Button uninstallAppButton;
        private System.Windows.Forms.Button sideloadFolderButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button copyBulkObbButton;
        private System.Windows.Forms.Label DragDropLbl;
        private System.Windows.Forms.Button downloadInstallGameButton;
        private SergeUtils.EasyCompletionComboBox gamesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel backupContainer;
        private System.Windows.Forms.Button backupDrop;
        private System.Windows.Forms.Panel sideloadContainer;
        private System.Windows.Forms.Button sideloadDrop;
        private System.Windows.Forms.Button listApkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Button otherDrop;
        private System.Windows.Forms.Panel otherContainer;
        private System.Windows.Forms.Button userjsonButton;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button movieStreamButton;
        private System.Windows.Forms.Button killRcloneButton;
        private System.Windows.Forms.Label freeDisclaimer;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.ComboBox remotesList;
        private System.Windows.Forms.Button QuestOptionsButton;
        private System.Windows.Forms.Button SpoofFormButton;
        private System.Windows.Forms.Button ThemeChangerButton;
        private System.Windows.Forms.ListBox gamesQueListBox;
    }
}

