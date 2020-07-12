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
            this.copyMessageToClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.resetSettingsButton = new System.Windows.Forms.Button();
            this.deleteAfterInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkForUpdatesCheckBox
            // 
            this.checkForUpdatesCheckBox.AutoSize = true;
            this.checkForUpdatesCheckBox.Location = new System.Drawing.Point(17, 16);
            this.checkForUpdatesCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkForUpdatesCheckBox.Name = "checkForUpdatesCheckBox";
            this.checkForUpdatesCheckBox.Size = new System.Drawing.Size(145, 21);
            this.checkForUpdatesCheckBox.TabIndex = 0;
            this.checkForUpdatesCheckBox.Text = "Check for updates";
            this.checkForUpdatesCheckBox.UseVisualStyleBackColor = true;
            this.checkForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.checkForUpdatesCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.White;
            this.applyButton.ForeColor = System.Drawing.Color.Black;
            this.applyButton.Location = new System.Drawing.Point(476, 225);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // enableMessageBoxesCheckBox
            // 
            this.enableMessageBoxesCheckBox.AutoSize = true;
            this.enableMessageBoxesCheckBox.Location = new System.Drawing.Point(17, 44);
            this.enableMessageBoxesCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.enableMessageBoxesCheckBox.Name = "enableMessageBoxesCheckBox";
            this.enableMessageBoxesCheckBox.Size = new System.Drawing.Size(296, 21);
            this.enableMessageBoxesCheckBox.TabIndex = 2;
            this.enableMessageBoxesCheckBox.Text = "Enable Message Boxes on task completed";
            this.enableMessageBoxesCheckBox.UseVisualStyleBackColor = true;
            this.enableMessageBoxesCheckBox.CheckedChanged += new System.EventHandler(this.enableMessageBoxesCheckBox_CheckedChanged);
            // 
            // copyMessageToClipboardCheckBox
            // 
            this.copyMessageToClipboardCheckBox.AutoSize = true;
            this.copyMessageToClipboardCheckBox.Location = new System.Drawing.Point(17, 73);
            this.copyMessageToClipboardCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.copyMessageToClipboardCheckBox.Name = "copyMessageToClipboardCheckBox";
            this.copyMessageToClipboardCheckBox.Size = new System.Drawing.Size(201, 21);
            this.copyMessageToClipboardCheckBox.TabIndex = 3;
            this.copyMessageToClipboardCheckBox.Text = "Copy message to clipboard";
            this.copyMessageToClipboardCheckBox.UseVisualStyleBackColor = true;
            this.copyMessageToClipboardCheckBox.CheckedChanged += new System.EventHandler(this.copyMessageToClipboardCheckBox_CheckedChanged);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.BackColor = System.Drawing.Color.White;
            this.resetSettingsButton.ForeColor = System.Drawing.Color.Black;
            this.resetSettingsButton.Location = new System.Drawing.Point(341, 225);
            this.resetSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(127, 28);
            this.resetSettingsButton.TabIndex = 4;
            this.resetSettingsButton.Text = "Reset Settings";
            this.resetSettingsButton.UseVisualStyleBackColor = false;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // deleteAfterInstallCheckBox
            // 
            this.deleteAfterInstallCheckBox.AutoSize = true;
            this.deleteAfterInstallCheckBox.Location = new System.Drawing.Point(17, 102);
            this.deleteAfterInstallCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAfterInstallCheckBox.Name = "deleteAfterInstallCheckBox";
            this.deleteAfterInstallCheckBox.Size = new System.Drawing.Size(282, 21);
            this.deleteAfterInstallCheckBox.TabIndex = 6;
            this.deleteAfterInstallCheckBox.Text = "Delete games after download and install";
            this.deleteAfterInstallCheckBox.UseVisualStyleBackColor = true;
            this.deleteAfterInstallCheckBox.CheckedChanged += new System.EventHandler(this.deleteAfterInstallCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(592, 268);
            this.Controls.Add(this.deleteAfterInstallCheckBox);
            this.Controls.Add(this.resetSettingsButton);
            this.Controls.Add(this.copyMessageToClipboardCheckBox);
            this.Controls.Add(this.enableMessageBoxesCheckBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.checkForUpdatesCheckBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox copyMessageToClipboardCheckBox;
        private System.Windows.Forms.Button resetSettingsButton;
        private System.Windows.Forms.CheckBox deleteAfterInstallCheckBox;
    }
}