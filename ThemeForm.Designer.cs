namespace AndroidSideloader
{
    partial class ThemeForm
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SetBGcolorButton = new System.Windows.Forms.Button();
            this.SetPanelColorButton = new System.Windows.Forms.Button();
            this.SetButtonColorButton = new System.Windows.Forms.Button();
            this.SetComboBoxColorButton = new System.Windows.Forms.Button();
            this.SetTextBoxColorButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SetBGpicButton = new System.Windows.Forms.Button();
            this.SetFontStyleButton = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SetFontColorButton = new System.Windows.Forms.Button();
            this.SetSubBoxColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // SetBGcolorButton
            // 
            this.SetBGcolorButton.Location = new System.Drawing.Point(17, 15);
            this.SetBGcolorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetBGcolorButton.Name = "SetBGcolorButton";
            this.SetBGcolorButton.Size = new System.Drawing.Size(171, 28);
            this.SetBGcolorButton.TabIndex = 0;
            this.SetBGcolorButton.Text = "Set backgorund color";
            this.SetBGcolorButton.UseVisualStyleBackColor = true;
            this.SetBGcolorButton.Click += new System.EventHandler(this.SetBGcolorButton_Click);
            // 
            // SetPanelColorButton
            // 
            this.SetPanelColorButton.Location = new System.Drawing.Point(17, 84);
            this.SetPanelColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetPanelColorButton.Name = "SetPanelColorButton";
            this.SetPanelColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetPanelColorButton.TabIndex = 2;
            this.SetPanelColorButton.Text = "Set panel color";
            this.SetPanelColorButton.UseVisualStyleBackColor = true;
            this.SetPanelColorButton.Click += new System.EventHandler(this.SetPanelColorButton_Click);
            // 
            // SetButtonColorButton
            // 
            this.SetButtonColorButton.Location = new System.Drawing.Point(17, 187);
            this.SetButtonColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetButtonColorButton.Name = "SetButtonColorButton";
            this.SetButtonColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetButtonColorButton.TabIndex = 5;
            this.SetButtonColorButton.Text = "Set button color";
            this.SetButtonColorButton.UseVisualStyleBackColor = true;
            this.SetButtonColorButton.Click += new System.EventHandler(this.SetButtonColorButton_Click);
            // 
            // SetComboBoxColorButton
            // 
            this.SetComboBoxColorButton.Location = new System.Drawing.Point(17, 256);
            this.SetComboBoxColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetComboBoxColorButton.Name = "SetComboBoxColorButton";
            this.SetComboBoxColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetComboBoxColorButton.TabIndex = 7;
            this.SetComboBoxColorButton.Text = "Set combobox color";
            this.SetComboBoxColorButton.UseVisualStyleBackColor = true;
            this.SetComboBoxColorButton.Click += new System.EventHandler(this.SetComboBoxColorButton_Click);
            // 
            // SetTextBoxColorButton
            // 
            this.SetTextBoxColorButton.Location = new System.Drawing.Point(17, 290);
            this.SetTextBoxColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetTextBoxColorButton.Name = "SetTextBoxColorButton";
            this.SetTextBoxColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetTextBoxColorButton.TabIndex = 8;
            this.SetTextBoxColorButton.Text = "Set textbox color";
            this.SetTextBoxColorButton.UseVisualStyleBackColor = true;
            this.SetTextBoxColorButton.Click += new System.EventHandler(this.SetTextBoxColorButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(247, 14);
            this.SaveSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(124, 100);
            this.SaveSettingsButton.TabIndex = 9;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetSettingsButton.Location = new System.Drawing.Point(247, 121);
            this.ResetSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(124, 98);
            this.ResetSettingsButton.TabIndex = 10;
            this.ResetSettingsButton.Text = "Reset Settings";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Images|*.png;*.jpg;*.bmp;*.gif";
            // 
            // SetBGpicButton
            // 
            this.SetBGpicButton.Location = new System.Drawing.Point(17, 49);
            this.SetBGpicButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetBGpicButton.Name = "SetBGpicButton";
            this.SetBGpicButton.Size = new System.Drawing.Size(171, 28);
            this.SetBGpicButton.TabIndex = 1;
            this.SetBGpicButton.Text = "Set background picture";
            this.SetBGpicButton.UseVisualStyleBackColor = true;
            this.SetBGpicButton.Click += new System.EventHandler(this.SetBGpicButton_Click);
            // 
            // SetFontStyleButton
            // 
            this.SetFontStyleButton.Location = new System.Drawing.Point(17, 153);
            this.SetFontStyleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetFontStyleButton.Name = "SetFontStyleButton";
            this.SetFontStyleButton.Size = new System.Drawing.Size(171, 28);
            this.SetFontStyleButton.TabIndex = 4;
            this.SetFontStyleButton.Text = "Set font style";
            this.SetFontStyleButton.UseVisualStyleBackColor = true;
            this.SetFontStyleButton.Click += new System.EventHandler(this.SetFontStyleButton_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.Color.White;
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // SetFontColorButton
            // 
            this.SetFontColorButton.Location = new System.Drawing.Point(17, 118);
            this.SetFontColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetFontColorButton.Name = "SetFontColorButton";
            this.SetFontColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetFontColorButton.TabIndex = 3;
            this.SetFontColorButton.Text = "Set font color";
            this.SetFontColorButton.UseVisualStyleBackColor = true;
            this.SetFontColorButton.Click += new System.EventHandler(this.SetFontColorButton_Click);
            // 
            // SetSubBoxColorButton
            // 
            this.SetSubBoxColorButton.Location = new System.Drawing.Point(17, 222);
            this.SetSubBoxColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetSubBoxColorButton.Name = "SetSubBoxColorButton";
            this.SetSubBoxColorButton.Size = new System.Drawing.Size(171, 28);
            this.SetSubBoxColorButton.TabIndex = 6;
            this.SetSubBoxColorButton.Text = "Set sub-button color";
            this.SetSubBoxColorButton.UseVisualStyleBackColor = true;
            this.SetSubBoxColorButton.Click += new System.EventHandler(this.SetSubBoxColorButton_Click);
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(387, 335);
            this.Controls.Add(this.SetSubBoxColorButton);
            this.Controls.Add(this.SetFontColorButton);
            this.Controls.Add(this.SetFontStyleButton);
            this.Controls.Add(this.SetBGpicButton);
            this.Controls.Add(this.ResetSettingsButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.SetTextBoxColorButton);
            this.Controls.Add(this.SetComboBoxColorButton);
            this.Controls.Add(this.SetButtonColorButton);
            this.Controls.Add(this.SetPanelColorButton);
            this.Controls.Add(this.SetBGcolorButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemeForm";
            this.Text = "Create Your Theme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button SetBGcolorButton;
        private System.Windows.Forms.Button SetPanelColorButton;
        private System.Windows.Forms.Button SetButtonColorButton;
        private System.Windows.Forms.Button SetComboBoxColorButton;
        private System.Windows.Forms.Button SetTextBoxColorButton;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Button ResetSettingsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button SetBGpicButton;
        private System.Windows.Forms.Button SetFontStyleButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button SetFontColorButton;
        private System.Windows.Forms.Button SetSubBoxColorButton;
    }
}