namespace AndroidSideloader
{
    partial class QuestForm
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
            this.RefreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextureResTextBox = new System.Windows.Forms.TextBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefreshRateComboBox
            // 
            this.RefreshRateComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshRateComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.RefreshRateComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.RefreshRateComboBox.FormattingEnabled = true;
            this.RefreshRateComboBox.Items.AddRange(new object[] {
            "72",
            "90"});
            this.RefreshRateComboBox.Location = new System.Drawing.Point(12, 12);
            this.RefreshRateComboBox.Name = "RefreshRateComboBox";
            this.RefreshRateComboBox.Size = new System.Drawing.Size(345, 26);
            this.RefreshRateComboBox.TabIndex = 0;
            this.RefreshRateComboBox.Text = "Select refresh rate";
            // 
            // button1
            // 
            this.button1.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.button1.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextureResTextBox
            // 
            this.TextureResTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.TextureResTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.TextureResTextBox.Location = new System.Drawing.Point(12, 43);
            this.TextureResTextBox.Name = "TextureResTextBox";
            this.TextureResTextBox.Size = new System.Drawing.Size(120, 24);
            this.TextureResTextBox.TabIndex = 2;
            this.TextureResTextBox.Text = "0";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResolutionLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResolutionLabel.Location = new System.Drawing.Point(135, 43);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(222, 18);
            this.ResolutionLabel.TabIndex = 3;
            this.ResolutionLabel.Text = "Resolution per eye (0 for default)";
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(371, 119);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.TextureResTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshRateComboBox);
            this.MaximumSize = new System.Drawing.Size(387, 158);
            this.MinimumSize = new System.Drawing.Size(387, 158);
            this.Name = "QuestForm";
            this.ShowIcon = false;
            this.Text = "QuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RefreshRateComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextureResTextBox;
        private System.Windows.Forms.Label ResolutionLabel;
    }
}