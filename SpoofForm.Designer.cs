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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SpoofButton = new AndroidSideloader.RoundButton();
            this.RandomizeButton = new AndroidSideloader.RoundButton();
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // SpoofButton
            // 
            this.SpoofButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SpoofButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SpoofButton.BackColor = System.Drawing.Color.Transparent;
            this.SpoofButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SpoofButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.SpoofButton.ForeColor = System.Drawing.Color.White;
            this.SpoofButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpoofButton.Location = new System.Drawing.Point(176, 72);
            this.SpoofButton.Name = "SpoofButton";
            this.SpoofButton.Radius = 5;
            this.SpoofButton.Size = new System.Drawing.Size(110, 42);
            this.SpoofButton.Stroke = true;
            this.SpoofButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.SpoofButton.TabIndex = 5;
            this.SpoofButton.Text = "Spoof!";
            this.SpoofButton.Transparency = false;
            this.SpoofButton.Click += new System.EventHandler(this.SpoofButton_Click);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RandomizeButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RandomizeButton.BackColor = System.Drawing.Color.Transparent;
            this.RandomizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RandomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RandomizeButton.ForeColor = System.Drawing.Color.White;
            this.RandomizeButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RandomizeButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RandomizeButton.Location = new System.Drawing.Point(12, 72);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Radius = 5;
            this.RandomizeButton.Size = new System.Drawing.Size(110, 42);
            this.RandomizeButton.Stroke = true;
            this.RandomizeButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.RandomizeButton.TabIndex = 6;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.Transparency = false;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // SpoofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.ClientSize = new System.Drawing.Size(300, 131);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.SpoofButton);
            this.Controls.Add(this.progressBar1);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private RoundButton SpoofButton;
        private RoundButton RandomizeButton;
    }
}