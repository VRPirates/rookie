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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.donateButton = new System.Windows.Forms.Button();
            this.themesbutton = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.troubleshootButton = new System.Windows.Forms.Button();
            this.checkHashButton = new System.Windows.Forms.Button();
            this.userjsonButton = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.listApkButton = new System.Windows.Forms.Button();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etaLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.diskLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_combo.ForeColor = System.Drawing.Color.White;
            this.m_combo.Location = new System.Drawing.Point(284, 14);
            this.m_combo.Margin = new System.Windows.Forms.Padding(4);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(685, 24);
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
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 170);
            this.startsideloadbutton.Margin = new System.Windows.Forms.Padding(4);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(267, 34);
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
            this.devicesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(267, 34);
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
            this.obbcopybutton.Margin = new System.Windows.Forms.Padding(4);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(267, 34);
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
            this.backupbutton.Location = new System.Drawing.Point(0, 34);
            this.backupbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(267, 34);
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
            this.restorebutton.Margin = new System.Windows.Forms.Padding(4);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(267, 34);
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
            this.getApkButton.Location = new System.Drawing.Point(0, 68);
            this.getApkButton.Margin = new System.Windows.Forms.Padding(4);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(267, 34);
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
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 102);
            this.uninstallAppButton.Margin = new System.Windows.Forms.Padding(4);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(267, 34);
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
            this.sideloadFolderButton.Location = new System.Drawing.Point(0, 136);
            this.sideloadFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.sideloadFolderButton.Name = "sideloadFolderButton";
            this.sideloadFolderButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.sideloadFolderButton.Size = new System.Drawing.Size(267, 34);
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
            this.progressBar.Location = new System.Drawing.Point(284, 46);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(685, 25);
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
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 34);
            this.copyBulkObbButton.Margin = new System.Windows.Forms.Padding(4);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(267, 34);
            this.copyBulkObbButton.TabIndex = 3;
            this.copyBulkObbButton.Text = "Copy Bulk Obb";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton.UseVisualStyleBackColor = false;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = System.Drawing.Color.White;
            this.DragDropLbl.Location = new System.Drawing.Point(275, 486);
            this.DragDropLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(394, 69);
            this.DragDropLbl.TabIndex = 25;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // downloadInstallGameButton
            // 
            this.downloadInstallGameButton.Location = new System.Drawing.Point(284, 113);
            this.downloadInstallGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.downloadInstallGameButton.Name = "downloadInstallGameButton";
            this.downloadInstallGameButton.Size = new System.Drawing.Size(685, 28);
            this.downloadInstallGameButton.TabIndex = 22;
            this.downloadInstallGameButton.Text = "Download and Install Game";
            this.downloadInstallGameButton.UseVisualStyleBackColor = true;
            this.downloadInstallGameButton.Click += new System.EventHandler(this.downloadInstallGameButton_Click);
            // 
            // gamesComboBox
            // 
            this.gamesComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.gamesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesComboBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesComboBox.ForeColor = System.Drawing.Color.White;
            this.gamesComboBox.Location = new System.Drawing.Point(284, 81);
            this.gamesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamesComboBox.Name = "gamesComboBox";
            this.gamesComboBox.Size = new System.Drawing.Size(685, 24);
            this.gamesComboBox.Sorted = true;
            this.gamesComboBox.TabIndex = 21;
            this.gamesComboBox.Text = "Select a game from here...";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = global::AndroidSideloader.Properties.Settings.Default.PanelColor;
            this.panel1.Controls.Add(this.donateButton);
            this.panel1.Controls.Add(this.themesbutton);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.troubleshootButton);
            this.panel1.Controls.Add(this.checkHashButton);
            this.panel1.Controls.Add(this.userjsonButton);
            this.panel1.Controls.Add(this.backupContainer);
            this.panel1.Controls.Add(this.backupDrop);
            this.panel1.Controls.Add(this.sideloadContainer);
            this.panel1.Controls.Add(this.sideloadDrop);
            this.panel1.Controls.Add(this.devicesbutton);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "PanelColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 786);
            this.panel1.TabIndex = 73;
            // 
            // donateButton
            // 
            this.donateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.donateButton.FlatAppearance.BorderSize = 0;
            this.donateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.donateButton.Location = new System.Drawing.Point(0, 635);
            this.donateButton.Margin = new System.Windows.Forms.Padding(4);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(267, 58);
            this.donateButton.TabIndex = 18;
            this.donateButton.Text = "DONATE";
            this.donateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // themesbutton
            // 
            this.themesbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.themesbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.themesbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.themesbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.themesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.themesbutton.FlatAppearance.BorderSize = 0;
            this.themesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themesbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.themesbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.themesbutton.Location = new System.Drawing.Point(0, 601);
            this.themesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.themesbutton.Name = "themesbutton";
            this.themesbutton.Size = new System.Drawing.Size(267, 34);
            this.themesbutton.TabIndex = 17;
            this.themesbutton.Text = "THEMES";
            this.themesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themesbutton.UseVisualStyleBackColor = false;
            this.themesbutton.Click += new System.EventHandler(this.themesbutton_Click);
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
            this.aboutBtn.Location = new System.Drawing.Point(0, 567);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(267, 34);
            this.aboutBtn.TabIndex = 16;
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
            this.settingsButton.Location = new System.Drawing.Point(0, 533);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(267, 34);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // troubleshootButton
            // 
            this.troubleshootButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.troubleshootButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.troubleshootButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.troubleshootButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.troubleshootButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.troubleshootButton.FlatAppearance.BorderSize = 0;
            this.troubleshootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.troubleshootButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.troubleshootButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.troubleshootButton.Location = new System.Drawing.Point(0, 499);
            this.troubleshootButton.Margin = new System.Windows.Forms.Padding(4);
            this.troubleshootButton.Name = "troubleshootButton";
            this.troubleshootButton.Size = new System.Drawing.Size(267, 34);
            this.troubleshootButton.TabIndex = 14;
            this.troubleshootButton.Text = "TROUBLESHOOT";
            this.troubleshootButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.troubleshootButton.UseVisualStyleBackColor = false;
            this.troubleshootButton.Click += new System.EventHandler(this.troubleshootButton_Click);
            // 
            // checkHashButton
            // 
            this.checkHashButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.checkHashButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkHashButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkHashButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkHashButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkHashButton.FlatAppearance.BorderSize = 0;
            this.checkHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHashButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.checkHashButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.checkHashButton.Location = new System.Drawing.Point(0, 465);
            this.checkHashButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkHashButton.Name = "checkHashButton";
            this.checkHashButton.Size = new System.Drawing.Size(267, 34);
            this.checkHashButton.TabIndex = 13;
            this.checkHashButton.Text = "VIEW HASH";
            this.checkHashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkHashButton.UseVisualStyleBackColor = false;
            this.checkHashButton.Click += new System.EventHandler(this.checkHashButton_Click);
            // 
            // userjsonButton
            // 
            this.userjsonButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userjsonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userjsonButton.FlatAppearance.BorderSize = 0;
            this.userjsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userjsonButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.userjsonButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.userjsonButton.Location = new System.Drawing.Point(0, 431);
            this.userjsonButton.Margin = new System.Windows.Forms.Padding(4);
            this.userjsonButton.Name = "userjsonButton";
            this.userjsonButton.Size = new System.Drawing.Size(267, 34);
            this.userjsonButton.TabIndex = 12;
            this.userjsonButton.Text = "USER.JSON";
            this.userjsonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userjsonButton.UseVisualStyleBackColor = false;
            this.userjsonButton.Click += new System.EventHandler(this.userjsonButton_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 353);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(267, 78);
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
            this.backupDrop.Location = new System.Drawing.Point(0, 319);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.backupDrop.Size = new System.Drawing.Size(267, 34);
            this.backupDrop.TabIndex = 9;
            this.backupDrop.Text = "BACKUP";
            this.backupDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupDrop.UseVisualStyleBackColor = false;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideloadContainer.Controls.Add(this.listApkButton);
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.sideloadFolderButton);
            this.sideloadContainer.Controls.Add(this.uninstallAppButton);
            this.sideloadContainer.Controls.Add(this.getApkButton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 68);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(267, 251);
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
            this.listApkButton.Location = new System.Drawing.Point(0, 204);
            this.listApkButton.Margin = new System.Windows.Forms.Padding(4);
            this.listApkButton.Name = "listApkButton";
            this.listApkButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.listApkButton.Size = new System.Drawing.Size(267, 34);
            this.listApkButton.TabIndex = 8;
            this.listApkButton.Text = "Refresh Apk, Games";
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
            this.sideloadDrop.Location = new System.Drawing.Point(0, 34);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.sideloadDrop.Size = new System.Drawing.Size(267, 34);
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
            this.pictureBox1.Location = new System.Drawing.Point(264, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // etaLabel
            // 
            this.etaLabel.AutoSize = true;
            this.etaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etaLabel.ForeColor = System.Drawing.Color.White;
            this.etaLabel.Location = new System.Drawing.Point(278, 204);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(295, 36);
            this.etaLabel.TabIndex = 75;
            this.etaLabel.Text = "ETA: HH:MM:SS Left";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(278, 170);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(300, 36);
            this.speedLabel.TabIndex = 76;
            this.speedLabel.Text = "DLS: Speed in MBPS";
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskLabel.ForeColor = System.Drawing.Color.White;
            this.diskLabel.Location = new System.Drawing.Point(282, 145);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(103, 25);
            this.diskLabel.TabIndex = 77;
            this.diskLabel.Text = "Disk Label";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(982, 786);
            this.Controls.Add(this.diskLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.etaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamesComboBox);
            this.Controls.Add(this.downloadInstallGameButton);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 833);
            this.MinimumSize = new System.Drawing.Size(879, 833);
            this.Name = "Form1";
            this.Text = "Rookie SideLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button userjsonButton;
        private System.Windows.Forms.Panel backupContainer;
        private System.Windows.Forms.Button backupDrop;
        private System.Windows.Forms.Panel sideloadContainer;
        private System.Windows.Forms.Button sideloadDrop;
        private System.Windows.Forms.Button listApkButton;
        private System.Windows.Forms.Button checkHashButton;
        private System.Windows.Forms.Button troubleshootButton;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button themesbutton;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label diskLabel;
    }
}

