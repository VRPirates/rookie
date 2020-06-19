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
            this.instructionsbutton = new System.Windows.Forms.Button();
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.customadbcmdbutton = new System.Windows.Forms.Button();
            this.ListApps = new System.Windows.Forms.Button();
            this.getApkButton = new System.Windows.Forms.Button();
            this.listApkPermsButton = new System.Windows.Forms.Button();
            this.changePermsBtn = new System.Windows.Forms.Button();
            this.launchPackageTextBox = new System.Windows.Forms.TextBox();
            this.launchApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.Location = new System.Drawing.Point(12, 134);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(426, 21);
            this.m_combo.TabIndex = 16;
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.Location = new System.Drawing.Point(100, 13);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Size = new System.Drawing.Size(87, 33);
            this.startsideloadbutton.TabIndex = 2;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.UseVisualStyleBackColor = true;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.Location = new System.Drawing.Point(12, 12);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(82, 34);
            this.devicesbutton.TabIndex = 1;
            this.devicesbutton.Text = "Adb devices";
            this.devicesbutton.UseVisualStyleBackColor = true;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // instructionsbutton
            // 
            this.instructionsbutton.Location = new System.Drawing.Point(282, 12);
            this.instructionsbutton.Name = "instructionsbutton";
            this.instructionsbutton.Size = new System.Drawing.Size(87, 34);
            this.instructionsbutton.TabIndex = 4;
            this.instructionsbutton.Text = "Instructions";
            this.instructionsbutton.UseVisualStyleBackColor = true;
            this.instructionsbutton.Click += new System.EventHandler(this.instructionsbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.Location = new System.Drawing.Point(193, 12);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Size = new System.Drawing.Size(87, 34);
            this.obbcopybutton.TabIndex = 3;
            this.obbcopybutton.Text = "Copy Obb";
            this.obbcopybutton.UseVisualStyleBackColor = true;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.Location = new System.Drawing.Point(13, 52);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Size = new System.Drawing.Size(81, 34);
            this.backupbutton.TabIndex = 5;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.UseVisualStyleBackColor = true;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.Location = new System.Drawing.Point(100, 52);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Size = new System.Drawing.Size(87, 34);
            this.restorebutton.TabIndex = 6;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.UseVisualStyleBackColor = true;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // customadbcmdbutton
            // 
            this.customadbcmdbutton.Location = new System.Drawing.Point(193, 52);
            this.customadbcmdbutton.Name = "customadbcmdbutton";
            this.customadbcmdbutton.Size = new System.Drawing.Size(87, 34);
            this.customadbcmdbutton.TabIndex = 7;
            this.customadbcmdbutton.Text = "Run Adb Command";
            this.customadbcmdbutton.UseVisualStyleBackColor = true;
            this.customadbcmdbutton.Click += new System.EventHandler(this.customadbcmdbutton_Click);
            // 
            // ListApps
            // 
            this.ListApps.Location = new System.Drawing.Point(12, 92);
            this.ListApps.Name = "ListApps";
            this.ListApps.Size = new System.Drawing.Size(82, 34);
            this.ListApps.TabIndex = 8;
            this.ListApps.Text = "Refresh Apps";
            this.ListApps.UseVisualStyleBackColor = true;
            this.ListApps.Click += new System.EventHandler(this.ListApps_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.Location = new System.Drawing.Point(100, 92);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Size = new System.Drawing.Size(87, 34);
            this.getApkButton.TabIndex = 9;
            this.getApkButton.Text = "Get Apk";
            this.getApkButton.UseVisualStyleBackColor = true;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // listApkPermsButton
            // 
            this.listApkPermsButton.Location = new System.Drawing.Point(193, 92);
            this.listApkPermsButton.Name = "listApkPermsButton";
            this.listApkPermsButton.Size = new System.Drawing.Size(87, 34);
            this.listApkPermsButton.TabIndex = 10;
            this.listApkPermsButton.Text = "List Apk Perms";
            this.listApkPermsButton.UseVisualStyleBackColor = true;
            this.listApkPermsButton.Click += new System.EventHandler(this.listApkPermsButton_Click);
            // 
            // changePermsBtn
            // 
            this.changePermsBtn.Location = new System.Drawing.Point(282, 92);
            this.changePermsBtn.Name = "changePermsBtn";
            this.changePermsBtn.Size = new System.Drawing.Size(87, 34);
            this.changePermsBtn.TabIndex = 11;
            this.changePermsBtn.Text = "Change Permissions";
            this.changePermsBtn.UseVisualStyleBackColor = true;
            this.changePermsBtn.Click += new System.EventHandler(this.changePermsBtn_Click);
            // 
            // launchPackageTextBox
            // 
            this.launchPackageTextBox.Location = new System.Drawing.Point(446, 134);
            this.launchPackageTextBox.Name = "launchPackageTextBox";
            this.launchPackageTextBox.Size = new System.Drawing.Size(192, 20);
            this.launchPackageTextBox.TabIndex = 15;
            this.launchPackageTextBox.Text = "de.eye_interactive.atvl.settings";
            // 
            // launchApkButton
            // 
            this.launchApkButton.Location = new System.Drawing.Point(446, 161);
            this.launchApkButton.Name = "launchApkButton";
            this.launchApkButton.Size = new System.Drawing.Size(192, 20);
            this.launchApkButton.TabIndex = 13;
            this.launchApkButton.Text = "Launch Apk By Package Name";
            this.launchApkButton.UseVisualStyleBackColor = true;
            this.launchApkButton.Click += new System.EventHandler(this.launchApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.Location = new System.Drawing.Point(375, 92);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Size = new System.Drawing.Size(64, 34);
            this.uninstallAppButton.TabIndex = 12;
            this.uninstallAppButton.Text = "Uninstall app";
            this.uninstallAppButton.UseVisualStyleBackColor = true;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.uninstallAppButton);
            this.Controls.Add(this.launchApkButton);
            this.Controls.Add(this.launchPackageTextBox);
            this.Controls.Add(this.changePermsBtn);
            this.Controls.Add(this.listApkPermsButton);
            this.Controls.Add(this.getApkButton);
            this.Controls.Add(this.ListApps);
            this.Controls.Add(this.customadbcmdbutton);
            this.Controls.Add(this.restorebutton);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.backupbutton);
            this.Controls.Add(this.obbcopybutton);
            this.Controls.Add(this.instructionsbutton);
            this.Controls.Add(this.devicesbutton);
            this.Controls.Add(this.startsideloadbutton);
            this.MaximumSize = new System.Drawing.Size(666, 1000);
            this.MinimumSize = new System.Drawing.Size(466, 450);
            this.Name = "Form1";
            this.Text = "Rookie SideLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startsideloadbutton;
        private System.Windows.Forms.Button devicesbutton;
        private System.Windows.Forms.Button instructionsbutton;
        private System.Windows.Forms.Button obbcopybutton;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button customadbcmdbutton;
        private System.Windows.Forms.Button ListApps;
        private System.Windows.Forms.Button getApkButton;
        private System.Windows.Forms.Button listApkPermsButton;
        private System.Windows.Forms.Button changePermsBtn;
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.TextBox launchPackageTextBox;
        private System.Windows.Forms.Button launchApkButton;
        private System.Windows.Forms.Button uninstallAppButton;
    }
}

