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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestFormText = new System.Windows.Forms.Label();
            this.CPUBox = new System.Windows.Forms.ComboBox();
            this.GPUBox = new System.Windows.Forms.ComboBox();
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
            this.RefreshRateComboBox.Size = new System.Drawing.Size(345, 23);
            this.RefreshRateComboBox.TabIndex = 0;
            this.RefreshRateComboBox.Text = "Select refresh rate";
            this.RefreshRateComboBox.SelectedIndexChanged += new System.EventHandler(this.RefreshRateComboBox_SelectedIndexChanged);
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
            this.button1.Location = new System.Drawing.Point(125, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 26);
            this.button1.TabIndex = 4;
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
            this.TextureResTextBox.Location = new System.Drawing.Point(12, 41);
            this.TextureResTextBox.Name = "TextureResTextBox";
            this.TextureResTextBox.Size = new System.Drawing.Size(121, 21);
            this.TextureResTextBox.TabIndex = 1;
            this.TextureResTextBox.Text = "0";
            this.TextureResTextBox.TextChanged += new System.EventHandler(this.TextureResTextBox_TextChanged);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResolutionLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResolutionLabel.Location = new System.Drawing.Point(139, 46);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(234, 16);
            this.ResolutionLabel.TabIndex = 3;
            this.ResolutionLabel.Text = "Resolution per eye (0 for default)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label1.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label1.Location = new System.Drawing.Point(139, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU level (0 for default)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label2.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label2.Location = new System.Drawing.Point(139, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPU level (0 for default)";
            // 
            // QuestFormText
            // 
            this.QuestFormText.AutoSize = true;
            this.QuestFormText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.QuestFormText.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestFormText.Location = new System.Drawing.Point(39, 168);
            this.QuestFormText.Name = "QuestFormText";
            this.QuestFormText.Size = new System.Drawing.Size(292, 16);
            this.QuestFormText.TabIndex = 6;
            this.QuestFormText.Text = "NOTE: Settings will be reset upon reboot.";
            // 
            // CPUBox
            // 
            this.CPUBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CPUBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.CPUBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CPUBox.FormattingEnabled = true;
            this.CPUBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.CPUBox.Location = new System.Drawing.Point(12, 68);
            this.CPUBox.Name = "CPUBox";
            this.CPUBox.Size = new System.Drawing.Size(121, 23);
            this.CPUBox.TabIndex = 7;
            this.CPUBox.Text = "0";
            // 
            // GPUBox
            // 
            this.GPUBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GPUBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPUBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.GPUBox.ForeColor = System.Drawing.SystemColors.Window;
            this.GPUBox.FormattingEnabled = true;
            this.GPUBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.GPUBox.Location = new System.Drawing.Point(12, 97);
            this.GPUBox.Name = "GPUBox";
            this.GPUBox.Size = new System.Drawing.Size(121, 23);
            this.GPUBox.TabIndex = 8;
            this.GPUBox.Text = "0";
            this.GPUBox.SelectedIndexChanged += new System.EventHandler(this.GPUBox_SelectedIndexChanged);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(371, 184);
            this.Controls.Add(this.GPUBox);
            this.Controls.Add(this.CPUBox);
            this.Controls.Add(this.QuestFormText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.TextureResTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshRateComboBox);
            this.MaximumSize = new System.Drawing.Size(387, 250);
            this.MinimumSize = new System.Drawing.Size(387, 39);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuestFormText;
        private System.Windows.Forms.ComboBox CPUBox;
        private System.Windows.Forms.ComboBox GPUBox;
    }
}