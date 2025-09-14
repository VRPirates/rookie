
using AndroidSideloader.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidSideloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.m_combo = new SergeUtils.EasyCompletionComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.etaLabel = new System.Windows.Forms.Label();
            this.freeDisclaimer = new System.Windows.Forms.Label();
            this.gamesQueListBox = new System.Windows.Forms.ListBox();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.remotesList = new System.Windows.Forms.ComboBox();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.GameNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionCodeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseAPKPathIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownloadsIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.gamesQueueLabel = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DragDropLbl = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.adbCmd_background = new System.Windows.Forms.Label();
            this.lblUpdateAvailable = new System.Windows.Forms.Label();
            this.lblUpToDate = new System.Windows.Forms.Label();
            this.lblMirror = new System.Windows.Forms.Label();
            this.adbCmd_CommandBox = new System.Windows.Forms.TextBox();
            this.adbCmd_Label = new System.Windows.Forms.Label();
            this.lblNeedsDonate = new System.Windows.Forms.Label();
            this.gamesPictureBox = new System.Windows.Forms.PictureBox();
            this.startsideloadbutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.startsideloadbutton = new System.Windows.Forms.Button();
            this.devicesbutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.devicesbutton = new System.Windows.Forms.Button();
            this.obbcopybutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.backupadbbutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.backupadbbutton = new System.Windows.Forms.Button();
            this.backupbutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.backupbutton = new System.Windows.Forms.Button();
            this.restorebutton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.restorebutton = new System.Windows.Forms.Button();
            this.getApkButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.getApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.pullAppToDesktopBtn_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pullAppToDesktopBtn = new System.Windows.Forms.Button();
            this.copyBulkObbButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.copyBulkObbButton = new System.Windows.Forms.Button();
            this.aboutBtn_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.QuestOptionsButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.QuestOptionsButton = new System.Windows.Forms.Button();
            this.btnOpenDownloads_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenDownloads = new System.Windows.Forms.Button();
            this.btnRunAdbCmd_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRunAdbCmd = new System.Windows.Forms.Button();
            this.ADBWirelessDisable_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ADBWirelessDisable = new System.Windows.Forms.Button();
            this.ADBWirelessEnable_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ADBWirelessEnable = new System.Windows.Forms.Button();
            this.UpdateGamesButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.UpdateGamesButton = new System.Windows.Forms.Button();
            this.listApkButton_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.listApkButton = new System.Windows.Forms.Button();
            this.speedLabel_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.etaLabel_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.progressDLbtnContainer = new System.Windows.Forms.Panel();
            this.diskLabel = new System.Windows.Forms.Label();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.deviceDrop = new System.Windows.Forms.Button();
            this.deviceDropContainer = new System.Windows.Forms.Panel();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.installedAppsMenu = new System.Windows.Forms.Button();
            this.installedAppsMenuContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.otherDrop = new System.Windows.Forms.Button();
            this.otherContainer = new System.Windows.Forms.Panel();
            this.batteryLevImg = new System.Windows.Forms.PictureBox();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.ULLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.leftNavContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.favoriteGame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favoriteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteSwitcher = new AndroidSideloader.RoundButton();
            this.adbCmd_btnSend = new AndroidSideloader.RoundButton();
            this.adbCmd_btnToggleUpdates = new AndroidSideloader.RoundButton();
            this.downloadInstallGameButton = new AndroidSideloader.RoundButton();
            this.MountButton = new AndroidSideloader.RoundButton();
            this.btnNoDevice = new AndroidSideloader.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).BeginInit();
            this.progressDLbtnContainer.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            this.deviceDropContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            this.installedAppsMenuContainer.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.otherContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryLevImg)).BeginInit();
            this.leftNavContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.favoriteGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.m_combo.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.m_combo.Location = new System.Drawing.Point(224, 9);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(374, 26);
            this.m_combo.TabIndex = 0;
            this.m_combo.Text = "Select an Installed App to Uninstall or Share...";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ForeColor = System.Drawing.Color.Purple;
            this.progressBar.Location = new System.Drawing.Point(2, 0);
            this.progressBar.MinimumSize = new System.Drawing.Size(200, 13);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(553, 13);
            this.progressBar.TabIndex = 7;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.speedLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.speedLabel.Location = new System.Drawing.Point(2, 14);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(149, 18);
            this.speedLabel.TabIndex = 76;
            this.speedLabel.Text = "DLS: Speed in MBPS";
            this.speedLabel_Tooltip.SetToolTip(this.speedLabel, "Current download speed, updates every second, in mbps");
            // 
            // etaLabel
            // 
            this.etaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.etaLabel.BackColor = System.Drawing.Color.Transparent;
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.etaLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.etaLabel.Location = new System.Drawing.Point(359, 14);
            this.etaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(196, 18);
            this.etaLabel.TabIndex = 75;
            this.etaLabel.Text = "ETA: HH:MM:SS Left";
            this.etaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.etaLabel_Tooltip.SetToolTip(this.etaLabel, "Estimated time when game will finish download, updates every 5 seconds, format is" +
        " HH:MM:SS");
            // 
            // freeDisclaimer
            // 
            this.freeDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.freeDisclaimer.AutoSize = true;
            this.freeDisclaimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.freeDisclaimer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.freeDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeDisclaimer.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.freeDisclaimer.Location = new System.Drawing.Point(289, 582);
            this.freeDisclaimer.Name = "freeDisclaimer";
            this.freeDisclaimer.Size = new System.Drawing.Size(246, 40);
            this.freeDisclaimer.TabIndex = 79;
            this.freeDisclaimer.Text = "This app is FREE!! \r\nClick here to go to the github.";
            this.freeDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.freeDisclaimer.Click += new System.EventHandler(this.freeDisclaimer_Click);
            // 
            // gamesQueListBox
            // 
            this.gamesQueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesQueListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesQueListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueListBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueListBox.FormattingEnabled = true;
            this.gamesQueListBox.ItemHeight = 18;
            this.gamesQueListBox.Location = new System.Drawing.Point(601, 493);
            this.gamesQueListBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamesQueListBox.Name = "gamesQueListBox";
            this.gamesQueListBox.Size = new System.Drawing.Size(556, 128);
            this.gamesQueListBox.TabIndex = 9;
            this.gamesQueListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamesQueListBox_MouseClick);
            this.gamesQueListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesQueListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(224, 39);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(164, 26);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.Text = "Select your device";
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // remotesList
            // 
            this.remotesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remotesList.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.remotesList.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.remotesList.FormattingEnabled = true;
            this.remotesList.Location = new System.Drawing.Point(531, 40);
            this.remotesList.Margin = new System.Windows.Forms.Padding(2);
            this.remotesList.Name = "remotesList";
            this.remotesList.Size = new System.Drawing.Size(67, 26);
            this.remotesList.TabIndex = 3;
            this.remotesList.SelectedIndexChanged += new System.EventHandler(this.remotesList_SelectedIndexChanged);
            // 
            // gamesListView
            // 
            this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameNameIndex,
            this.ReleaseNameIndex,
            this.PackageNameIndex,
            this.VersionCodeIndex,
            this.ReleaseAPKPathIndex,
            this.VersionNameIndex,
            this.DownloadsIndex});
            this.gamesListView.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesListView.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesListView.HideSelection = false;
            this.gamesListView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gamesListView.Location = new System.Drawing.Point(224, 98);
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.ShowGroups = false;
            this.gamesListView.Size = new System.Drawing.Size(933, 350);
            this.gamesListView.TabIndex = 6;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.gamesListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.gamesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseClick);
            this.gamesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
            // 
            // GameNameIndex
            // 
            this.GameNameIndex.Text = "Game Name";
            this.GameNameIndex.Width = 158;
            // 
            // ReleaseNameIndex
            // 
            this.ReleaseNameIndex.Text = "Release Name";
            this.ReleaseNameIndex.Width = 244;
            // 
            // PackageNameIndex
            // 
            this.PackageNameIndex.Text = "Package Name";
            this.PackageNameIndex.Width = 87;
            // 
            // VersionCodeIndex
            // 
            this.VersionCodeIndex.Text = "Version";
            this.VersionCodeIndex.Width = 75;
            // 
            // ReleaseAPKPathIndex
            // 
            this.ReleaseAPKPathIndex.Text = "Last Updated";
            this.ReleaseAPKPathIndex.Width = 145;
            // 
            // VersionNameIndex
            // 
            this.VersionNameIndex.Text = "Size (MB)";
            this.VersionNameIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VersionNameIndex.Width = 66;
            // 
            // DownloadsIndex
            // 
            this.DownloadsIndex.Text = "Popularity";
            this.DownloadsIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DownloadsIndex.Width = 80;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.searchTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.searchTextBox.Location = new System.Drawing.Point(224, 70);
            this.searchTextBox.MinimumSize = new System.Drawing.Size(231, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(933, 26);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // gamesQueueLabel
            // 
            this.gamesQueueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesQueueLabel.AutoSize = true;
            this.gamesQueueLabel.BackColor = System.Drawing.Color.Transparent;
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueueLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueueLabel.Location = new System.Drawing.Point(971, 603);
            this.gamesQueueLabel.Name = "gamesQueueLabel";
            this.gamesQueueLabel.Size = new System.Drawing.Size(123, 18);
            this.gamesQueueLabel.TabIndex = 86;
            this.gamesQueueLabel.Text = "Download Queue";
            // 
            // ProgressText
            // 
            this.ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressText.AutoSize = true;
            this.ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.ProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.White;
            this.ProgressText.Location = new System.Drawing.Point(225, 710);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 18);
            this.ProgressText.TabIndex = 88;
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.notesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notesRichTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.notesRichTextBox.HideSelection = false;
            this.notesRichTextBox.Location = new System.Drawing.Point(601, 626);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.ReadOnly = true;
            this.notesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesRichTextBox.ShowSelectionMargin = true;
            this.notesRichTextBox.Size = new System.Drawing.Size(556, 81);
            this.notesRichTextBox.TabIndex = 10;
            this.notesRichTextBox.Text = "\n\n\n                                     TIP: PRESS F1 TO SEE A LIST OF SHORTCUTS";
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DragDropLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.DragDropLbl.Location = new System.Drawing.Point(602, 527);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(320, 55);
            this.DragDropLbl.TabIndex = 25;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblNotes.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblNotes.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.lblNotes.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.lblNotes.Location = new System.Drawing.Point(988, 689);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(106, 18);
            this.lblNotes.TabIndex = 86;
            this.lblNotes.Text = "Release Notes";
            // 
            // adbCmd_background
            // 
            this.adbCmd_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adbCmd_background.Location = new System.Drawing.Point(462, 196);
            this.adbCmd_background.Name = "adbCmd_background";
            this.adbCmd_background.Size = new System.Drawing.Size(322, 103);
            this.adbCmd_background.TabIndex = 89;
            this.adbCmd_background.Visible = false;
            // 
            // lblUpdateAvailable
            // 
            this.lblUpdateAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdateAvailable.AutoSize = true;
            this.lblUpdateAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdateAvailable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateAvailable.Location = new System.Drawing.Point(72, 20);
            this.lblUpdateAvailable.Name = "lblUpdateAvailable";
            this.lblUpdateAvailable.Size = new System.Drawing.Size(151, 20);
            this.lblUpdateAvailable.TabIndex = 90;
            this.lblUpdateAvailable.Text = "𝖴𝖯𝖣𝖠𝖳𝖤 𝖠𝖵𝖠𝖨𝖫𝖠𝖡𝖫𝖤";
            this.lblUpdateAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUpdateAvailable.Click += new System.EventHandler(this.updateAvailable_Click);
            // 
            // lblUpToDate
            // 
            this.lblUpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpToDate.AutoSize = true;
            this.lblUpToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpToDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpToDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpToDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpToDate.Location = new System.Drawing.Point(127, 0);
            this.lblUpToDate.Name = "lblUpToDate";
            this.lblUpToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpToDate.Size = new System.Drawing.Size(96, 20);
            this.lblUpToDate.TabIndex = 90;
            this.lblUpToDate.Text = "𝖴𝖯 𝖳𝖮 𝖣𝖠𝖳𝖤";
            this.lblUpToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUpToDate.Click += new System.EventHandler(this.lblUpToDate_Click);
            // 
            // lblMirror
            // 
            this.lblMirror.AutoSize = true;
            this.lblMirror.BackColor = System.Drawing.Color.Transparent;
            this.lblMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMirror.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMirror.Location = new System.Drawing.Point(475, 44);
            this.lblMirror.Name = "lblMirror";
            this.lblMirror.Size = new System.Drawing.Size(51, 17);
            this.lblMirror.TabIndex = 90;
            this.lblMirror.Text = "Mirror";
            this.lblMirror.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adbCmd_CommandBox
            // 
            this.adbCmd_CommandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adbCmd_CommandBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.adbCmd_CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adbCmd_CommandBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_CommandBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_CommandBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_CommandBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.adbCmd_CommandBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.adbCmd_CommandBox.Location = new System.Drawing.Point(477, 231);
            this.adbCmd_CommandBox.MaximumSize = new System.Drawing.Size(290, 24);
            this.adbCmd_CommandBox.MinimumSize = new System.Drawing.Size(290, 24);
            this.adbCmd_CommandBox.Name = "adbCmd_CommandBox";
            this.adbCmd_CommandBox.Size = new System.Drawing.Size(290, 24);
            this.adbCmd_CommandBox.TabIndex = 5;
            this.adbCmd_CommandBox.Visible = false;
            this.adbCmd_CommandBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.adbCmd_CommandBox.Enter += new System.EventHandler(this.ADBcommandbox_Enter);
            this.adbCmd_CommandBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADBcommandbox_KeyPress);
            this.adbCmd_CommandBox.Leave += new System.EventHandler(this.ADBcommandbox_Leave);
            // 
            // adbCmd_Label
            // 
            this.adbCmd_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adbCmd_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.adbCmd_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adbCmd_Label.Location = new System.Drawing.Point(500, 205);
            this.adbCmd_Label.MaximumSize = new System.Drawing.Size(247, 20);
            this.adbCmd_Label.MinimumSize = new System.Drawing.Size(247, 20);
            this.adbCmd_Label.Name = "adbCmd_Label";
            this.adbCmd_Label.Size = new System.Drawing.Size(247, 20);
            this.adbCmd_Label.TabIndex = 90;
            this.adbCmd_Label.Text = "Type ADB Command";
            this.adbCmd_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adbCmd_Label.Visible = false;
            // 
            // lblNeedsDonate
            // 
            this.lblNeedsDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNeedsDonate.AutoSize = true;
            this.lblNeedsDonate.BackColor = System.Drawing.Color.Transparent;
            this.lblNeedsDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNeedsDonate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedsDonate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNeedsDonate.Location = new System.Drawing.Point(81, 40);
            this.lblNeedsDonate.Name = "lblNeedsDonate";
            this.lblNeedsDonate.Size = new System.Drawing.Size(142, 20);
            this.lblNeedsDonate.TabIndex = 90;
            this.lblNeedsDonate.Text = "𝖭𝖤𝖶𝖤𝖱 𝖳𝖧𝖠𝖭 𝖫𝖨𝖲𝖳";
            this.lblNeedsDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNeedsDonate.Click += new System.EventHandler(this.lblNeedsDonate_Click);
            // 
            // gamesPictureBox
            // 
            this.gamesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamesPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesPictureBox.Location = new System.Drawing.Point(224, 493);
            this.gamesPictureBox.Name = "gamesPictureBox";
            this.gamesPictureBox.Size = new System.Drawing.Size(374, 214);
            this.gamesPictureBox.TabIndex = 84;
            this.gamesPictureBox.TabStop = false;
            this.gamesPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startsideloadbutton.FlatAppearance.BorderSize = 0;
            this.startsideloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsideloadbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.startsideloadbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 56);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(221, 28);
            this.startsideloadbutton.TabIndex = 5;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startsideloadbutton_Tooltip.SetToolTip(this.startsideloadbutton, "Sideload an APK onto your device");
            this.startsideloadbutton.UseVisualStyleBackColor = false;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesbutton.FlatAppearance.BorderSize = 0;
            this.devicesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesbutton.Location = new System.Drawing.Point(0, 0);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.devicesbutton.Size = new System.Drawing.Size(221, 28);
            this.devicesbutton.TabIndex = 0;
            this.devicesbutton.Text = "RECONNECT DEVICE";
            this.devicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesbutton_Tooltip.SetToolTip(this.devicesbutton, "Rookie will attempt to reconnect to your Device");
            this.devicesbutton.UseVisualStyleBackColor = false;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.obbcopybutton.FlatAppearance.BorderSize = 0;
            this.obbcopybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obbcopybutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.obbcopybutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.obbcopybutton.Location = new System.Drawing.Point(0, 0);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(221, 28);
            this.obbcopybutton.TabIndex = 0;
            this.obbcopybutton.Text = "Copy OBB";
            this.obbcopybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obbcopybutton_Tooltip.SetToolTip(this.obbcopybutton, "Copies an obb folder to the Android/obb folder from the device (Not all games use" +
        " obb files)");
            this.obbcopybutton.UseVisualStyleBackColor = false;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupadbbutton
            // 
            this.backupadbbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.backupadbbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupadbbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupadbbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupadbbutton.FlatAppearance.BorderSize = 0;
            this.backupadbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupadbbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupadbbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupadbbutton.Location = new System.Drawing.Point(0, 28);
            this.backupadbbutton.Name = "backupadbbutton";
            this.backupadbbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.backupadbbutton.Size = new System.Drawing.Size(221, 28);
            this.backupadbbutton.TabIndex = 1;
            this.backupadbbutton.Text = "Backup with ADB";
            this.backupadbbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupadbbutton_Tooltip.SetToolTip(this.backupadbbutton, "Uses ADB-Backup to Save Game Data (Pick app within the Dropdown)");
            this.backupadbbutton.UseVisualStyleBackColor = false;
            this.backupadbbutton.Click += new System.EventHandler(this.backupadbbutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupbutton.Location = new System.Drawing.Point(0, 0);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(221, 28);
            this.backupbutton.TabIndex = 1;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton_Tooltip.SetToolTip(this.backupbutton, "Saves the game and apps data to the sideloader folder (Does not save APKs or OBBs" +
        ")");
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.restorebutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.restorebutton.Location = new System.Drawing.Point(0, 56);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(221, 28);
            this.restorebutton.TabIndex = 0;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton_Tooltip.SetToolTip(this.restorebutton, "Restores the game and apps data to the device (Use the Backup Game Data button fi" +
        "rst!)");
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.getApkButton.FlatAppearance.BorderSize = 0;
            this.getApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.getApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.getApkButton.Location = new System.Drawing.Point(0, 0);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(221, 28);
            this.getApkButton.TabIndex = 2;
            this.getApkButton.Text = "Share Selected App";
            this.getApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getApkButton_Tooltip.SetToolTip(this.getApkButton, "Uploads the selected app to our Servers (Pick app within the Dropdown)");
            this.getApkButton.UseVisualStyleBackColor = false;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallAppButton.FlatAppearance.BorderSize = 0;
            this.uninstallAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallAppButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.uninstallAppButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 28);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(221, 28);
            this.uninstallAppButton.TabIndex = 3;
            this.uninstallAppButton.Text = "Uninstall Selected App";
            this.uninstallAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallAppButton_Tooltip.SetToolTip(this.uninstallAppButton, "Uninstalls the selected app (Select within the Dropdown)");
            this.uninstallAppButton.UseVisualStyleBackColor = false;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // pullAppToDesktopBtn
            // 
            this.pullAppToDesktopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pullAppToDesktopBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pullAppToDesktopBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pullAppToDesktopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pullAppToDesktopBtn.FlatAppearance.BorderSize = 0;
            this.pullAppToDesktopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pullAppToDesktopBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.pullAppToDesktopBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.pullAppToDesktopBtn.Location = new System.Drawing.Point(0, 56);
            this.pullAppToDesktopBtn.Name = "pullAppToDesktopBtn";
            this.pullAppToDesktopBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pullAppToDesktopBtn.Size = new System.Drawing.Size(221, 28);
            this.pullAppToDesktopBtn.TabIndex = 4;
            this.pullAppToDesktopBtn.Text = "Pull App To Desktop";
            this.pullAppToDesktopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pullAppToDesktopBtn_Tooltip.SetToolTip(this.pullAppToDesktopBtn, "Extracts APK and OBB to your Desktop (Select within the Dropdown)");
            this.pullAppToDesktopBtn.UseVisualStyleBackColor = false;
            this.pullAppToDesktopBtn.Click += new System.EventHandler(this.pullAppToDesktopBtn_Click);
            // 
            // copyBulkObbButton
            // 
            this.copyBulkObbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyBulkObbButton.FlatAppearance.BorderSize = 0;
            this.copyBulkObbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBulkObbButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.copyBulkObbButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 28);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(221, 28);
            this.copyBulkObbButton.TabIndex = 1;
            this.copyBulkObbButton.Text = "Recursive Copy OBB";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton_Tooltip.SetToolTip(this.copyBulkObbButton, "Copies an multiple OBB folders to your device.");
            this.copyBulkObbButton.UseVisualStyleBackColor = false;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.aboutBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.aboutBtn.Location = new System.Drawing.Point(0, 645);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(221, 28);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = " ?   ABOUT";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn_Tooltip.SetToolTip(this.aboutBtn, "About the Rookie App and it\'s amazing creators and contributors");
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.settingsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 617);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(221, 28);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "⚙ SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton_Tooltip.SetToolTip(this.settingsButton, "Rookie App Settings");
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // QuestOptionsButton
            // 
            this.QuestOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestOptionsButton.FlatAppearance.BorderSize = 0;
            this.QuestOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestOptionsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QuestOptionsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QuestOptionsButton.Location = new System.Drawing.Point(0, 56);
            this.QuestOptionsButton.Name = "QuestOptionsButton";
            this.QuestOptionsButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.QuestOptionsButton.Size = new System.Drawing.Size(221, 28);
            this.QuestOptionsButton.TabIndex = 2;
            this.QuestOptionsButton.Text = "Quest Options";
            this.QuestOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestOptionsButton_Tooltip.SetToolTip(this.QuestOptionsButton, "Additional Quest Settings and Utilities");
            this.QuestOptionsButton.UseVisualStyleBackColor = false;
            this.QuestOptionsButton.Click += new System.EventHandler(this.QuestOptionsButton_Click);
            // 
            // btnOpenDownloads
            // 
            this.btnOpenDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOpenDownloads.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOpenDownloads.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOpenDownloads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenDownloads.FlatAppearance.BorderSize = 0;
            this.btnOpenDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDownloads.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.btnOpenDownloads.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.btnOpenDownloads.Location = new System.Drawing.Point(0, 84);
            this.btnOpenDownloads.Name = "btnOpenDownloads";
            this.btnOpenDownloads.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpenDownloads.Size = new System.Drawing.Size(221, 28);
            this.btnOpenDownloads.TabIndex = 7;
            this.btnOpenDownloads.Text = "Open Downloads Folder";
            this.btnOpenDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDownloads_Tooltip.SetToolTip(this.btnOpenDownloads, "Opens your set Rookie Download Folder");
            this.btnOpenDownloads.UseVisualStyleBackColor = false;
            this.btnOpenDownloads.Click += new System.EventHandler(this.btnOpenDownloads_Click);
            // 
            // btnRunAdbCmd
            // 
            this.btnRunAdbCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRunAdbCmd.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRunAdbCmd.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRunAdbCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunAdbCmd.FlatAppearance.BorderSize = 0;
            this.btnRunAdbCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAdbCmd.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.btnRunAdbCmd.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.btnRunAdbCmd.Location = new System.Drawing.Point(0, 112);
            this.btnRunAdbCmd.Name = "btnRunAdbCmd";
            this.btnRunAdbCmd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRunAdbCmd.Size = new System.Drawing.Size(221, 28);
            this.btnRunAdbCmd.TabIndex = 6;
            this.btnRunAdbCmd.Text = "Run ADB Command";
            this.btnRunAdbCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunAdbCmd_Tooltip.SetToolTip(this.btnRunAdbCmd, "Opens the Run ADB Command Prompt");
            this.btnRunAdbCmd.UseVisualStyleBackColor = false;
            this.btnRunAdbCmd.Click += new System.EventHandler(this.btnRunAdbCmd_Click);
            // 
            // ADBWirelessDisable
            // 
            this.ADBWirelessDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessDisable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessDisable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessDisable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessDisable.Location = new System.Drawing.Point(0, 28);
            this.ADBWirelessDisable.Name = "ADBWirelessDisable";
            this.ADBWirelessDisable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ADBWirelessDisable.Size = new System.Drawing.Size(221, 28);
            this.ADBWirelessDisable.TabIndex = 1;
            this.ADBWirelessDisable.Text = "Disable Wireless ADB";
            this.ADBWirelessDisable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessDisable_Tooltip.SetToolTip(this.ADBWirelessDisable, "Removes Wireless ADB settings and disconnects any Wireless devices");
            this.ADBWirelessDisable.UseVisualStyleBackColor = false;
            this.ADBWirelessDisable.Click += new System.EventHandler(this.ADBWirelessDisable_Click);
            // 
            // ADBWirelessEnable
            // 
            this.ADBWirelessEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessEnable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessEnable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessEnable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessEnable.Location = new System.Drawing.Point(0, 0);
            this.ADBWirelessEnable.Name = "ADBWirelessEnable";
            this.ADBWirelessEnable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ADBWirelessEnable.Size = new System.Drawing.Size(221, 28);
            this.ADBWirelessEnable.TabIndex = 0;
            this.ADBWirelessEnable.Text = "Enable Wireless ADB";
            this.ADBWirelessEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessEnable_Tooltip.SetToolTip(this.ADBWirelessEnable, "Enables Wireless sideloading. Requires a connected device to activate!");
            this.ADBWirelessEnable.UseVisualStyleBackColor = false;
            this.ADBWirelessEnable.Click += new System.EventHandler(this.ADBWirelessEnable_Click);
            // 
            // UpdateGamesButton
            // 
            this.UpdateGamesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateGamesButton.FlatAppearance.BorderSize = 0;
            this.UpdateGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGamesButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.UpdateGamesButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.UpdateGamesButton.Location = new System.Drawing.Point(0, 28);
            this.UpdateGamesButton.Name = "UpdateGamesButton";
            this.UpdateGamesButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UpdateGamesButton.Size = new System.Drawing.Size(221, 29);
            this.UpdateGamesButton.TabIndex = 7;
            this.UpdateGamesButton.Text = "Refresh Update List";
            this.UpdateGamesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGamesButton_Tooltip.SetToolTip(this.UpdateGamesButton, "Refresh Game List and available updates");
            this.UpdateGamesButton.UseVisualStyleBackColor = false;
            this.UpdateGamesButton.Click += new System.EventHandler(this.UpdateGamesButton_Click);
            // 
            // listApkButton
            // 
            this.listApkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listApkButton.FlatAppearance.BorderSize = 0;
            this.listApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.listApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.listApkButton.Location = new System.Drawing.Point(0, 57);
            this.listApkButton.Name = "listApkButton";
            this.listApkButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.listApkButton.Size = new System.Drawing.Size(221, 28);
            this.listApkButton.TabIndex = 6;
            this.listApkButton.Text = "Refresh All";
            this.listApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listApkButton_Tooltip.SetToolTip(this.listApkButton, "Refresh connected devices, installed apps, and update game list");
            this.listApkButton.UseVisualStyleBackColor = false;
            this.listApkButton.Click += new System.EventHandler(this.listApkButton_Click);
            // 
            // progressDLbtnContainer
            // 
            this.progressDLbtnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressDLbtnContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progressDLbtnContainer.BackColor = System.Drawing.Color.Transparent;
            this.progressDLbtnContainer.Controls.Add(this.downloadInstallGameButton);
            this.progressDLbtnContainer.Controls.Add(this.progressBar);
            this.progressDLbtnContainer.Controls.Add(this.etaLabel);
            this.progressDLbtnContainer.Controls.Add(this.speedLabel);
            this.progressDLbtnContainer.Location = new System.Drawing.Point(224, 454);
            this.progressDLbtnContainer.MinimumSize = new System.Drawing.Size(600, 34);
            this.progressDLbtnContainer.Name = "progressDLbtnContainer";
            this.progressDLbtnContainer.Size = new System.Drawing.Size(933, 34);
            this.progressDLbtnContainer.TabIndex = 96;
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.diskLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.diskLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.diskLabel.Location = new System.Drawing.Point(0, 0);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.diskLabel.Size = new System.Drawing.Size(82, 18);
            this.diskLabel.TabIndex = 7;
            this.diskLabel.Text = "Disk Label";
            this.diskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomContainer
            // 
            this.bottomContainer.AutoSize = true;
            this.bottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.bottomContainer.Controls.Add(this.diskLabel);
            this.bottomContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bottomContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomContainer.Location = new System.Drawing.Point(0, 673);
            this.bottomContainer.Margin = new System.Windows.Forms.Padding(2);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(221, 18);
            this.bottomContainer.TabIndex = 73;
            // 
            // deviceDrop
            // 
            this.deviceDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deviceDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone;
            this.deviceDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.deviceDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deviceDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deviceDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceDrop.FlatAppearance.BorderSize = 0;
            this.deviceDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.deviceDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.deviceDrop.Location = new System.Drawing.Point(0, 0);
            this.deviceDrop.Margin = new System.Windows.Forms.Padding(2);
            this.deviceDrop.Name = "deviceDrop";
            this.deviceDrop.Size = new System.Drawing.Size(221, 28);
            this.deviceDrop.TabIndex = 1;
            this.deviceDrop.Text = "▶ DEVICE ◀";
            this.deviceDrop.UseVisualStyleBackColor = false;
            this.deviceDrop.Click += new System.EventHandler(this.deviceDropContainer_Click);
            // 
            // deviceDropContainer
            // 
            this.deviceDropContainer.AutoSize = true;
            this.deviceDropContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deviceDropContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.deviceDropContainer.Controls.Add(this.listApkButton);
            this.deviceDropContainer.Controls.Add(this.UpdateGamesButton);
            this.deviceDropContainer.Controls.Add(this.devicesbutton);
            this.deviceDropContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deviceDropContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceDropContainer.Location = new System.Drawing.Point(0, 28);
            this.deviceDropContainer.Margin = new System.Windows.Forms.Padding(2);
            this.deviceDropContainer.Name = "deviceDropContainer";
            this.deviceDropContainer.Size = new System.Drawing.Size(221, 85);
            this.deviceDropContainer.TabIndex = 73;
            // 
            // sideloadDrop
            // 
            this.sideloadDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideloadDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone;
            this.sideloadDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadDrop.FlatAppearance.BorderSize = 0;
            this.sideloadDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadDrop.Location = new System.Drawing.Point(0, 113);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Size = new System.Drawing.Size(221, 28);
            this.sideloadDrop.TabIndex = 1;
            this.sideloadDrop.Text = "▶ SIDELOAD ◀";
            this.sideloadDrop.UseVisualStyleBackColor = false;
            this.sideloadDrop.Click += new System.EventHandler(this.sideloadContainer_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.AutoSize = true;
            this.sideloadContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideloadContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 141);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(221, 84);
            this.sideloadContainer.TabIndex = 74;
            // 
            // installedAppsMenu
            // 
            this.installedAppsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.installedAppsMenu.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone;
            this.installedAppsMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.installedAppsMenu.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.installedAppsMenu.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.installedAppsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.installedAppsMenu.FlatAppearance.BorderSize = 0;
            this.installedAppsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installedAppsMenu.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.installedAppsMenu.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.installedAppsMenu.Location = new System.Drawing.Point(0, 225);
            this.installedAppsMenu.Margin = new System.Windows.Forms.Padding(2);
            this.installedAppsMenu.Name = "installedAppsMenu";
            this.installedAppsMenu.Size = new System.Drawing.Size(221, 28);
            this.installedAppsMenu.TabIndex = 1;
            this.installedAppsMenu.Text = "▶ INSTALLED APPS ◀";
            this.installedAppsMenu.UseVisualStyleBackColor = false;
            this.installedAppsMenu.Click += new System.EventHandler(this.installedAppsMenuContainer_Click);
            // 
            // installedAppsMenuContainer
            // 
            this.installedAppsMenuContainer.AutoSize = true;
            this.installedAppsMenuContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installedAppsMenuContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.installedAppsMenuContainer.Controls.Add(this.pullAppToDesktopBtn);
            this.installedAppsMenuContainer.Controls.Add(this.uninstallAppButton);
            this.installedAppsMenuContainer.Controls.Add(this.getApkButton);
            this.installedAppsMenuContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.installedAppsMenuContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.installedAppsMenuContainer.Location = new System.Drawing.Point(0, 253);
            this.installedAppsMenuContainer.Margin = new System.Windows.Forms.Padding(2);
            this.installedAppsMenuContainer.Name = "installedAppsMenuContainer";
            this.installedAppsMenuContainer.Size = new System.Drawing.Size(221, 84);
            this.installedAppsMenuContainer.TabIndex = 73;
            // 
            // backupDrop
            // 
            this.backupDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.backupDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone;
            this.backupDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupDrop.FlatAppearance.BorderSize = 0;
            this.backupDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupDrop.Location = new System.Drawing.Point(0, 337);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Size = new System.Drawing.Size(221, 28);
            this.backupDrop.TabIndex = 2;
            this.backupDrop.Text = "▶ BACKUP / RESTORE ◀";
            this.backupDrop.UseVisualStyleBackColor = false;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.AutoSize = true;
            this.backupContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backupContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.Controls.Add(this.backupadbbutton);
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 365);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(221, 84);
            this.backupContainer.TabIndex = 76;
            // 
            // otherDrop
            // 
            this.otherDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.otherDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone;
            this.otherDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherDrop.FlatAppearance.BorderSize = 0;
            this.otherDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.otherDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.otherDrop.Location = new System.Drawing.Point(0, 449);
            this.otherDrop.Margin = new System.Windows.Forms.Padding(2);
            this.otherDrop.Name = "otherDrop";
            this.otherDrop.Size = new System.Drawing.Size(221, 28);
            this.otherDrop.TabIndex = 3;
            this.otherDrop.Text = "▶ OTHER ◀";
            this.otherDrop.UseVisualStyleBackColor = false;
            this.otherDrop.Click += new System.EventHandler(this.otherDrop_Click);
            // 
            // otherContainer
            // 
            this.otherContainer.AutoSize = true;
            this.otherContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.otherContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.otherContainer.Controls.Add(this.btnRunAdbCmd);
            this.otherContainer.Controls.Add(this.btnOpenDownloads);
            this.otherContainer.Controls.Add(this.QuestOptionsButton);
            this.otherContainer.Controls.Add(this.ADBWirelessDisable);
            this.otherContainer.Controls.Add(this.ADBWirelessEnable);
            this.otherContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherContainer.Location = new System.Drawing.Point(0, 477);
            this.otherContainer.Margin = new System.Windows.Forms.Padding(2);
            this.otherContainer.Name = "otherContainer";
            this.otherContainer.Size = new System.Drawing.Size(221, 140);
            this.otherContainer.TabIndex = 80;
            // 
            // batteryLevImg
            // 
            this.batteryLevImg.BackColor = System.Drawing.Color.Transparent;
            this.batteryLevImg.BackgroundImage = global::AndroidSideloader.Properties.Resources.battery;
            this.batteryLevImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.batteryLevImg.Location = new System.Drawing.Point(166, 715);
            this.batteryLevImg.Margin = new System.Windows.Forms.Padding(2);
            this.batteryLevImg.Name = "batteryLevImg";
            this.batteryLevImg.Size = new System.Drawing.Size(55, 29);
            this.batteryLevImg.TabIndex = 85;
            this.batteryLevImg.TabStop = false;
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.BackColor = System.Drawing.Color.Transparent;
            this.batteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.batteryLabel.Location = new System.Drawing.Point(174, 721);
            this.batteryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(0, 13);
            this.batteryLabel.TabIndex = 84;
            // 
            // ULLabel
            // 
            this.ULLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ULLabel.AutoSize = true;
            this.ULLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULLabel.ForeColor = System.Drawing.Color.Snow;
            this.ULLabel.Location = new System.Drawing.Point(635, 11);
            this.ULLabel.Name = "ULLabel";
            this.ULLabel.Size = new System.Drawing.Size(120, 13);
            this.ULLabel.TabIndex = 87;
            this.ULLabel.Text = "Uploading to VRP...";
            this.ULLabel.Visible = false;
            // 
            // verLabel
            // 
            this.verLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.verLabel.BackColor = System.Drawing.Color.Transparent;
            this.verLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.verLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.verLabel.Location = new System.Drawing.Point(1101, 721);
            this.verLabel.Name = "verLabel";
            this.verLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.verLabel.Size = new System.Drawing.Size(68, 20);
            this.verLabel.TabIndex = 88;
            // 
            // leftNavContainer
            // 
            this.leftNavContainer.AutoScroll = true;
            this.leftNavContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.leftNavContainer.Controls.Add(this.batteryLabel);
            this.leftNavContainer.Controls.Add(this.batteryLevImg);
            this.leftNavContainer.Controls.Add(this.bottomContainer);
            this.leftNavContainer.Controls.Add(this.aboutBtn);
            this.leftNavContainer.Controls.Add(this.settingsButton);
            this.leftNavContainer.Controls.Add(this.otherContainer);
            this.leftNavContainer.Controls.Add(this.otherDrop);
            this.leftNavContainer.Controls.Add(this.backupContainer);
            this.leftNavContainer.Controls.Add(this.backupDrop);
            this.leftNavContainer.Controls.Add(this.installedAppsMenuContainer);
            this.leftNavContainer.Controls.Add(this.installedAppsMenu);
            this.leftNavContainer.Controls.Add(this.sideloadContainer);
            this.leftNavContainer.Controls.Add(this.sideloadDrop);
            this.leftNavContainer.Controls.Add(this.deviceDropContainer);
            this.leftNavContainer.Controls.Add(this.deviceDrop);
            this.leftNavContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftNavContainer.Location = new System.Drawing.Point(0, 0);
            this.leftNavContainer.Margin = new System.Windows.Forms.Padding(2);
            this.leftNavContainer.Name = "leftNavContainer";
            this.leftNavContainer.Size = new System.Drawing.Size(221, 747);
            this.leftNavContainer.TabIndex = 73;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblUpToDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUpdateAvailable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNeedsDonate, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(931, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 64);
            this.tableLayoutPanel1.TabIndex = 97;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(224, 493);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(374, 214);
            this.webView21.TabIndex = 98;
            this.webView21.ZoomFactor = 1D;
            // 
            // favoriteGame
            // 
            this.favoriteGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoriteButton});
            this.favoriteGame.Name = "favoriteGame";
            this.favoriteGame.Size = new System.Drawing.Size(117, 26);
            // 
            // favoriteButton
            // 
            this.favoriteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.favoriteButton.ForeColor = System.Drawing.Color.White;
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(116, 22);
            this.favoriteButton.Text = "Favorite";
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // favoriteSwitcher
            // 
            this.favoriteSwitcher.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.favoriteSwitcher.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.favoriteSwitcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.favoriteSwitcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.favoriteSwitcher.Cursor = System.Windows.Forms.Cursors.Default;
            this.favoriteSwitcher.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.favoriteSwitcher.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.favoriteSwitcher.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.favoriteSwitcher.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.favoriteSwitcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.favoriteSwitcher.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.favoriteSwitcher.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.favoriteSwitcher.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.favoriteSwitcher.Location = new System.Drawing.Point(786, 34);
            this.favoriteSwitcher.Name = "favoriteSwitcher";
            this.favoriteSwitcher.Radius = 5;
            this.favoriteSwitcher.Size = new System.Drawing.Size(168, 28);
            this.favoriteSwitcher.Stroke = true;
            this.favoriteSwitcher.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.favoriteSwitcher.TabIndex = 101;
            this.favoriteSwitcher.Text = "Games List";
            this.favoriteSwitcher.Transparency = false;
            this.favoriteSwitcher.Click += new System.EventHandler(this.favoriteSwitcher_Click);
            // 
            // adbCmd_btnSend
            // 
            this.adbCmd_btnSend.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.adbCmd_btnSend.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.adbCmd_btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adbCmd_btnSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.adbCmd_btnSend.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnSend.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnSend.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adbCmd_btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.adbCmd_btnSend.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.adbCmd_btnSend.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnSend.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnSend.Location = new System.Drawing.Point(478, 262);
            this.adbCmd_btnSend.Name = "adbCmd_btnSend";
            this.adbCmd_btnSend.Radius = 5;
            this.adbCmd_btnSend.Size = new System.Drawing.Size(126, 28);
            this.adbCmd_btnSend.Stroke = true;
            this.adbCmd_btnSend.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.adbCmd_btnSend.TabIndex = 100;
            this.adbCmd_btnSend.Text = "Send Command";
            this.adbCmd_btnSend.Transparency = false;
            this.adbCmd_btnSend.Visible = false;
            this.adbCmd_btnSend.Click += new System.EventHandler(this.adbCmd_btnSend_Click);
            // 
            // adbCmd_btnToggleUpdates
            // 
            this.adbCmd_btnToggleUpdates.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.adbCmd_btnToggleUpdates.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.adbCmd_btnToggleUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnToggleUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adbCmd_btnToggleUpdates.Cursor = System.Windows.Forms.Cursors.Default;
            this.adbCmd_btnToggleUpdates.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnToggleUpdates.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnToggleUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbCmd_btnToggleUpdates.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adbCmd_btnToggleUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.adbCmd_btnToggleUpdates.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.adbCmd_btnToggleUpdates.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnToggleUpdates.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adbCmd_btnToggleUpdates.Location = new System.Drawing.Point(627, 262);
            this.adbCmd_btnToggleUpdates.Name = "adbCmd_btnToggleUpdates";
            this.adbCmd_btnToggleUpdates.Radius = 5;
            this.adbCmd_btnToggleUpdates.Size = new System.Drawing.Size(143, 28);
            this.adbCmd_btnToggleUpdates.Stroke = true;
            this.adbCmd_btnToggleUpdates.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.adbCmd_btnToggleUpdates.TabIndex = 99;
            this.adbCmd_btnToggleUpdates.Text = "Toggle OS Updates";
            this.adbCmd_btnToggleUpdates.Transparency = false;
            this.adbCmd_btnToggleUpdates.Visible = false;
            this.adbCmd_btnToggleUpdates.Click += new System.EventHandler(this.adbCmd_btnToggleUpdates_Click);
            // 
            // downloadInstallGameButton
            // 
            this.downloadInstallGameButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadInstallGameButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadInstallGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadInstallGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.downloadInstallGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.downloadInstallGameButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.downloadInstallGameButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.Location = new System.Drawing.Point(569, 0);
            this.downloadInstallGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.downloadInstallGameButton.Name = "downloadInstallGameButton";
            this.downloadInstallGameButton.Radius = 5;
            this.downloadInstallGameButton.Size = new System.Drawing.Size(364, 34);
            this.downloadInstallGameButton.Stroke = true;
            this.downloadInstallGameButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.downloadInstallGameButton.TabIndex = 94;
            this.downloadInstallGameButton.Text = "Download and Install Game/Add To Queue ⮩ ";
            this.downloadInstallGameButton.Transparency = false;
            this.downloadInstallGameButton.Click += new System.EventHandler(this.downloadInstallGameButton_Click);
            this.downloadInstallGameButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.downloadInstallGameButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // MountButton
            // 
            this.MountButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MountButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MountButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MountButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.MountButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.Location = new System.Drawing.Point(393, 39);
            this.MountButton.Name = "MountButton";
            this.MountButton.Radius = 5;
            this.MountButton.Size = new System.Drawing.Size(76, 26);
            this.MountButton.Stroke = true;
            this.MountButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.MountButton.TabIndex = 95;
            this.MountButton.Text = "MOUNT";
            this.MountButton.Transparency = false;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            this.MountButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            // 
            // btnNoDevice
            // 
            this.btnNoDevice.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNoDevice.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNoDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNoDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNoDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNoDevice.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNoDevice.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNoDevice.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNoDevice.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNoDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnNoDevice.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.btnNoDevice.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNoDevice.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNoDevice.Location = new System.Drawing.Point(612, 34);
            this.btnNoDevice.Name = "btnNoDevice";
            this.btnNoDevice.Radius = 5;
            this.btnNoDevice.Size = new System.Drawing.Size(168, 28);
            this.btnNoDevice.Stroke = true;
            this.btnNoDevice.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnNoDevice.TabIndex = 99;
            this.btnNoDevice.Text = "Disable Sideloading";
            this.btnNoDevice.Transparency = false;
            this.btnNoDevice.Click += new System.EventHandler(this.btnNoDevice_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_cubes;
            this.ClientSize = new System.Drawing.Size(1175, 747);
            this.Controls.Add(this.favoriteSwitcher);
            this.Controls.Add(this.adbCmd_btnSend);
            this.Controls.Add(this.adbCmd_btnToggleUpdates);
            this.Controls.Add(this.ULLabel);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressDLbtnContainer);
            this.Controls.Add(this.MountButton);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.lblMirror);
            this.Controls.Add(this.adbCmd_CommandBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.adbCmd_Label);
            this.Controls.Add(this.freeDisclaimer);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.gamesQueueLabel);
            this.Controls.Add(this.gamesPictureBox);
            this.Controls.Add(this.remotesList);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.gamesQueListBox);
            this.Controls.Add(this.leftNavContainer);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.notesRichTextBox);
            this.Controls.Add(this.adbCmd_background);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.btnNoDevice);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1048, 760);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rookie Sideloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).EndInit();
            this.progressDLbtnContainer.ResumeLayout(false);
            this.progressDLbtnContainer.PerformLayout();
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            this.deviceDropContainer.ResumeLayout(false);
            this.sideloadContainer.ResumeLayout(false);
            this.installedAppsMenuContainer.ResumeLayout(false);
            this.backupContainer.ResumeLayout(false);
            this.otherContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.batteryLevImg)).EndInit();
            this.leftNavContainer.ResumeLayout(false);
            this.leftNavContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.favoriteGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label freeDisclaimer;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.ListBox gamesQueListBox;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox gamesPictureBox;
        private System.Windows.Forms.Label gamesQueueLabel;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.RichTextBox notesRichTextBox;
        private System.Windows.Forms.Label DragDropLbl;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label adbCmd_background;
        private System.Windows.Forms.Label lblUpdateAvailable;
        private System.Windows.Forms.Label lblUpToDate;
        private System.Windows.Forms.Label lblMirror;
        private System.Windows.Forms.TextBox adbCmd_CommandBox;
        private System.Windows.Forms.Label adbCmd_Label;
        public System.Windows.Forms.ComboBox remotesList;
        private System.Windows.Forms.Label lblNeedsDonate;
        public System.Windows.Forms.ColumnHeader GameNameIndex;
        public System.Windows.Forms.ColumnHeader ReleaseNameIndex;
        private System.Windows.Forms.ColumnHeader PackageNameIndex;
        private System.Windows.Forms.ColumnHeader VersionCodeIndex;
        private System.Windows.Forms.ColumnHeader ReleaseAPKPathIndex;
        public System.Windows.Forms.ColumnHeader VersionNameIndex;
        public System.Windows.Forms.ColumnHeader DownloadsIndex;
        private RoundButton downloadInstallGameButton;
        private RoundButton MountButton;
        private ToolTip startsideloadbutton_Tooltip;
        private ToolTip devicesbutton_Tooltip;
        private ToolTip obbcopybutton_Tooltip;
        private ToolTip backupadbbutton_Tooltip;
        private ToolTip backupbutton_Tooltip;
        private ToolTip restorebutton_Tooltip;
        private ToolTip getApkButton_Tooltip;
        private ToolTip uninstallAppButton_Tooltip;
        private ToolTip pullAppToDesktopBtn_Tooltip;
        private ToolTip copyBulkObbButton_Tooltip;
        private ToolTip aboutBtn_Tooltip;
        private ToolTip settingsButton_Tooltip;
        private ToolTip QuestOptionsButton_Tooltip;
        private ToolTip btnOpenDownloads_Tooltip;
        private ToolTip btnRunAdbCmd_Tooltip;
        private ToolTip ADBWirelessDisable_Tooltip;
        private ToolTip ADBWirelessEnable_Tooltip;
        private ToolTip UpdateGamesButton_Tooltip;
        private ToolTip listApkButton_Tooltip;
        private ToolTip speedLabel_Tooltip;
        private ToolTip etaLabel_Tooltip;
        private Panel progressDLbtnContainer;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label diskLabel;
        private Panel bottomContainer;
        private Button devicesbutton;
        private Button deviceDrop;
        private Panel deviceDropContainer;
        private Button sideloadDrop;
        private Panel sideloadContainer;
        private Button installedAppsMenu;
        private Panel installedAppsMenuContainer;
        private Button UpdateGamesButton;
        private Button listApkButton;
        private Button startsideloadbutton;
        private Button pullAppToDesktopBtn;
        private Button uninstallAppButton;
        private Button getApkButton;
        private Button copyBulkObbButton;
        private Button obbcopybutton;
        private Button backupDrop;
        private Panel backupContainer;
        private Button backupadbbutton;
        private Button backupbutton;
        private Button restorebutton;
        private Button otherDrop;
        private Panel otherContainer;
        private Button QuestOptionsButton;
        private Button ADBWirelessDisable;
        private Button ADBWirelessEnable;
        private Button settingsButton;
        private Button aboutBtn;
        private PictureBox batteryLevImg;
        private Label batteryLabel;
        private Label ULLabel;
        private Label verLabel;
        private Panel leftNavContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnOpenDownloads;
        private Button btnRunAdbCmd;
        private RoundButton btnNoDevice;
        private RoundButton adbCmd_btnToggleUpdates;
        private RoundButton adbCmd_btnSend;
        private ContextMenuStrip favoriteGame;
        private ToolStripMenuItem favoriteButton;
        private RoundButton favoriteSwitcher;
    }
}
