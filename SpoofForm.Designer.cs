namespace AndroidSideloader
{
    partial class SpoofForm
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
            this.PackageNameTextBox = new System.Windows.Forms.TextBox();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SpoofButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PackageNameTextBox
            // 
            this.PackageNameTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.PackageNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PackageNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PackageNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PackageNameTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.PackageNameTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.PackageNameTextBox.Location = new System.Drawing.Point(13, 13);
            this.PackageNameTextBox.Name = "PackageNameTextBox";
            this.PackageNameTextBox.Size = new System.Drawing.Size(273, 24);
            this.PackageNameTextBox.TabIndex = 1;
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.RandomizeButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RandomizeButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RandomizeButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RandomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomizeButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.RandomizeButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.RandomizeButton.Location = new System.Drawing.Point(12, 72);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(110, 42);
            this.RandomizeButton.TabIndex = 2;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = false;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // SpoofButton
            // 
            this.SpoofButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.SpoofButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpoofButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.SpoofButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.SpoofButton.Location = new System.Drawing.Point(176, 72);
            this.SpoofButton.Name = "SpoofButton";
            this.SpoofButton.Size = new System.Drawing.Size(110, 42);
            this.SpoofButton.TabIndex = 4;
            this.SpoofButton.Text = "Spoof!";
            this.SpoofButton.UseVisualStyleBackColor = false;
            this.SpoofButton.Click += new System.EventHandler(this.SpoofButton_Click);
            // 
            // SpoofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(300, 131);
            this.Controls.Add(this.SpoofButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.PackageNameTextBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximumSize = new System.Drawing.Size(316, 170);
            this.MinimumSize = new System.Drawing.Size(316, 170);
            this.Name = "SpoofForm";
            this.Text = "SpoofForm";
            this.Load += new System.EventHandler(this.SpoofForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PackageNameTextBox;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SpoofButton;
    }
}