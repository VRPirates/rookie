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
            this.launchPackageTextBox = new System.Windows.Forms.TextBox();
            this.launchApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.sideloadFolderButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.copyBulkObbButton = new System.Windows.Forms.Button();
            this.DragDropLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gamesComboBox = new SergeUtils.EasyCompletionComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.donateButton = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.checkHashButton = new System.Windows.Forms.Button();
            this.userjsonButton = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.ForeColor = System.Drawing.Color.White;
            this.m_combo.Location = new System.Drawing.Point(284, 13);
            this.m_combo.Margin = new System.Windows.Forms.Padding(4);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(568, 24);
            this.m_combo.TabIndex = 16;
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startsideloadbutton.FlatAppearance.BorderSize = 0;
            this.startsideloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsideloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsideloadbutton.ForeColor = System.Drawing.Color.White;
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 175);
            this.startsideloadbutton.Margin = new System.Windows.Forms.Padding(4);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(267, 35);
            this.startsideloadbutton.TabIndex = 4;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startsideloadbutton.UseVisualStyleBackColor = true;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesbutton.FlatAppearance.BorderSize = 0;
            this.devicesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.devicesbutton.Location = new System.Drawing.Point(0, 0);
            this.devicesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(267, 35);
            this.devicesbutton.TabIndex = 1;
            this.devicesbutton.Text = "ADB DEVICES";
            this.devicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesbutton.UseVisualStyleBackColor = true;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.obbcopybutton.FlatAppearance.BorderSize = 0;
            this.obbcopybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obbcopybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obbcopybutton.ForeColor = System.Drawing.Color.White;
            this.obbcopybutton.Location = new System.Drawing.Point(0, 0);
            this.obbcopybutton.Margin = new System.Windows.Forms.Padding(4);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(267, 35);
            this.obbcopybutton.TabIndex = 5;
            this.obbcopybutton.Text = "Copy Obb";
            this.obbcopybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obbcopybutton.UseVisualStyleBackColor = true;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbutton.ForeColor = System.Drawing.Color.White;
            this.backupbutton.Location = new System.Drawing.Point(0, 35);
            this.backupbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(267, 35);
            this.backupbutton.TabIndex = 9;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.UseVisualStyleBackColor = true;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restorebutton.ForeColor = System.Drawing.Color.White;
            this.restorebutton.Location = new System.Drawing.Point(0, 0);
            this.restorebutton.Margin = new System.Windows.Forms.Padding(4);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(267, 35);
            this.restorebutton.TabIndex = 10;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.UseVisualStyleBackColor = true;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.getApkButton.FlatAppearance.BorderSize = 0;
            this.getApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getApkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getApkButton.ForeColor = System.Drawing.Color.White;
            this.getApkButton.Location = new System.Drawing.Point(0, 70);
            this.getApkButton.Margin = new System.Windows.Forms.Padding(4);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(267, 35);
            this.getApkButton.TabIndex = 13;
            this.getApkButton.Text = "Get Apk";
            this.getApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getApkButton.UseVisualStyleBackColor = true;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // launchPackageTextBox
            // 
            this.launchPackageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.launchPackageTextBox.ForeColor = System.Drawing.Color.White;
            this.launchPackageTextBox.Location = new System.Drawing.Point(597, 113);
            this.launchPackageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.launchPackageTextBox.Name = "launchPackageTextBox";
            this.launchPackageTextBox.Size = new System.Drawing.Size(255, 22);
            this.launchPackageTextBox.TabIndex = 68;
            this.launchPackageTextBox.Text = "de.eye_interactive.atvl.settings";
            // 
            // launchApkButton
            // 
            this.launchApkButton.Location = new System.Drawing.Point(597, 140);
            this.launchApkButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchApkButton.Name = "launchApkButton";
            this.launchApkButton.Size = new System.Drawing.Size(255, 25);
            this.launchApkButton.TabIndex = 69;
            this.launchApkButton.Text = "Launch Apk By Package Name";
            this.launchApkButton.UseVisualStyleBackColor = true;
            this.launchApkButton.Click += new System.EventHandler(this.launchApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallAppButton.FlatAppearance.BorderSize = 0;
            this.uninstallAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallAppButton.ForeColor = System.Drawing.Color.White;
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 105);
            this.uninstallAppButton.Margin = new System.Windows.Forms.Padding(4);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(267, 35);
            this.uninstallAppButton.TabIndex = 14;
            this.uninstallAppButton.Text = "Uninstall App";
            this.uninstallAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallAppButton.UseVisualStyleBackColor = true;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // sideloadFolderButton
            // 
            this.sideloadFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadFolderButton.FlatAppearance.BorderSize = 0;
            this.sideloadFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideloadFolderButton.ForeColor = System.Drawing.Color.White;
            this.sideloadFolderButton.Location = new System.Drawing.Point(0, 140);
            this.sideloadFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.sideloadFolderButton.Name = "sideloadFolderButton";
            this.sideloadFolderButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.sideloadFolderButton.Size = new System.Drawing.Size(267, 35);
            this.sideloadFolderButton.TabIndex = 7;
            this.sideloadFolderButton.Text = "Sideload Folder";
            this.sideloadFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadFolderButton.UseVisualStyleBackColor = true;
            this.sideloadFolderButton.Click += new System.EventHandler(this.sideloadFolderButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Purple;
            this.progressBar1.Location = new System.Drawing.Point(286, 45);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 25);
            this.progressBar1.TabIndex = 23;
            // 
            // copyBulkObbButton
            // 
            this.copyBulkObbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyBulkObbButton.FlatAppearance.BorderSize = 0;
            this.copyBulkObbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBulkObbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBulkObbButton.ForeColor = System.Drawing.Color.White;
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 35);
            this.copyBulkObbButton.Margin = new System.Windows.Forms.Padding(4);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(267, 35);
            this.copyBulkObbButton.TabIndex = 8;
            this.copyBulkObbButton.Text = "Copy Bulk Obb";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton.UseVisualStyleBackColor = true;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = System.Drawing.Color.White;
            this.DragDropLbl.Location = new System.Drawing.Point(275, 486);
            this.DragDropLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(526, 91);
            this.DragDropLbl.TabIndex = 27;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 28);
            this.button1.TabIndex = 71;
            this.button1.Text = "Download Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamesComboBox
            // 
            this.gamesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gamesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesComboBox.ForeColor = System.Drawing.Color.White;
            this.gamesComboBox.Location = new System.Drawing.Point(284, 81);
            this.gamesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamesComboBox.Name = "gamesComboBox";
            this.gamesComboBox.Size = new System.Drawing.Size(568, 24);
            this.gamesComboBox.TabIndex = 72;
            this.gamesComboBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.donateButton);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.checkHashButton);
            this.panel1.Controls.Add(this.userjsonButton);
            this.panel1.Controls.Add(this.backupContainer);
            this.panel1.Controls.Add(this.backupDrop);
            this.panel1.Controls.Add(this.sideloadContainer);
            this.panel1.Controls.Add(this.sideloadDrop);
            this.panel1.Controls.Add(this.devicesbutton);
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
            this.donateButton.Location = new System.Drawing.Point(0, 556);
            this.donateButton.Margin = new System.Windows.Forms.Padding(4);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(267, 58);
            this.donateButton.TabIndex = 85;
            this.donateButton.Text = "DONATE";
            this.donateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutBtn.Location = new System.Drawing.Point(0, 521);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(267, 35);
            this.aboutBtn.TabIndex = 84;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.settingsButton.Location = new System.Drawing.Point(0, 486);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(267, 35);
            this.settingsButton.TabIndex = 83;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // checkHashButton
            // 
            this.checkHashButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkHashButton.FlatAppearance.BorderSize = 0;
            this.checkHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHashButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkHashButton.Location = new System.Drawing.Point(0, 451);
            this.checkHashButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkHashButton.Name = "checkHashButton";
            this.checkHashButton.Size = new System.Drawing.Size(267, 35);
            this.checkHashButton.TabIndex = 80;
            this.checkHashButton.Text = "VIEW HASH";
            this.checkHashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkHashButton.UseVisualStyleBackColor = true;
            this.checkHashButton.Click += new System.EventHandler(this.checkHashButton_Click);
            // 
            // userjsonButton
            // 
            this.userjsonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userjsonButton.FlatAppearance.BorderSize = 0;
            this.userjsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userjsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userjsonButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userjsonButton.Location = new System.Drawing.Point(0, 416);
            this.userjsonButton.Margin = new System.Windows.Forms.Padding(4);
            this.userjsonButton.Name = "userjsonButton";
            this.userjsonButton.Size = new System.Drawing.Size(267, 35);
            this.userjsonButton.TabIndex = 81;
            this.userjsonButton.Text = "USER.JSON";
            this.userjsonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userjsonButton.UseVisualStyleBackColor = true;
            this.userjsonButton.Click += new System.EventHandler(this.userjsonButton_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 333);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(267, 83);
            this.backupContainer.TabIndex = 76;
            // 
            // backupDrop
            // 
            this.backupDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupDrop.FlatAppearance.BorderSize = 0;
            this.backupDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupDrop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backupDrop.Location = new System.Drawing.Point(0, 298);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.backupDrop.Size = new System.Drawing.Size(267, 35);
            this.backupDrop.TabIndex = 75;
            this.backupDrop.Text = "BACKUP";
            this.backupDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupDrop.UseVisualStyleBackColor = true;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.sideloadFolderButton);
            this.sideloadContainer.Controls.Add(this.uninstallAppButton);
            this.sideloadContainer.Controls.Add(this.getApkButton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 70);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(267, 228);
            this.sideloadContainer.TabIndex = 74;
            // 
            // sideloadDrop
            // 
            this.sideloadDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadDrop.FlatAppearance.BorderSize = 0;
            this.sideloadDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideloadDrop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sideloadDrop.Location = new System.Drawing.Point(0, 35);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.sideloadDrop.Size = new System.Drawing.Size(267, 35);
            this.sideloadDrop.TabIndex = 2;
            this.sideloadDrop.Text = "SIDELOAD";
            this.sideloadDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadDrop.UseVisualStyleBackColor = true;
            this.sideloadDrop.Click += new System.EventHandler(this.sideloadContainer_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(862, 786);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamesComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.launchApkButton);
            this.Controls.Add(this.launchPackageTextBox);
            this.Controls.Add(this.m_combo);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(880, 1216);
            this.MinimumSize = new System.Drawing.Size(880, 539);
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
        private System.Windows.Forms.TextBox launchPackageTextBox;
        private System.Windows.Forms.Button launchApkButton;
        private System.Windows.Forms.Button uninstallAppButton;
        private System.Windows.Forms.Button sideloadFolderButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button copyBulkObbButton;
        private System.Windows.Forms.Label DragDropLbl;
        private System.Windows.Forms.Button button1;
        private SergeUtils.EasyCompletionComboBox gamesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button checkHashButton;
        private System.Windows.Forms.Button userjsonButton;
        private System.Windows.Forms.Panel backupContainer;
        private System.Windows.Forms.Button backupDrop;
        private System.Windows.Forms.Panel sideloadContainer;
        private System.Windows.Forms.Button sideloadDrop;
    }
}

