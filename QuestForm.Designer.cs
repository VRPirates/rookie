using System.Windows.Forms;

namespace AndroidSideloader
{
    partial class QuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DeleteShots = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CPUComboBox = new System.Windows.Forms.ComboBox();
            this.GPUComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.GlobalUsername = new System.Windows.Forms.TextBox();
            this.TextureResTextBox = new System.Windows.Forms.TextBox();
            this.RefreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new AndroidSideloader.RoundButton();
            this.questVids = new AndroidSideloader.RoundButton();
            this.questPics = new AndroidSideloader.RoundButton();
            this.button3 = new AndroidSideloader.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(72, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temporary Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(83, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reboot Quest to Reset";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCyan;
            this.label11.Location = new System.Drawing.Point(18, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Transfer screenshots to Desktop";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightCyan;
            this.label12.Location = new System.Drawing.Point(92, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Set Username";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // DeleteShots
            //
            this.DeleteShots.AutoSize = true;
            this.DeleteShots.BackColor = System.Drawing.Color.Transparent;
            this.DeleteShots.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteShots.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteShots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteShots.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteShots.Location = new System.Drawing.Point(33, 232);
            this.DeleteShots.Name = "DeleteShots";
            this.DeleteShots.Size = new System.Drawing.Size(242, 21);
            this.DeleteShots.TabIndex = 7;
            this.DeleteShots.Text = "Delete files on Quest after transfer";
            this.DeleteShots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteShots.UseVisualStyleBackColor = false;
            this.DeleteShots.CheckedChanged += new System.EventHandler(this.DeleteShots_CheckedChanged);
            //
            // splitter1
            //
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 486);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            //
            // label10
            //
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-4, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 3);
            this.label10.TabIndex = 15;
            //
            // label14
            //
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(-4, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 3);
            this.label14.TabIndex = 17;
            //
            // label16
            //
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label16.Location = new System.Drawing.Point(34, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Exports to: Desktop\\Quest Screenshots";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // CPUComboBox
            //
            this.CPUComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.CPUComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.CPUComboBox.FormattingEnabled = true;
            this.CPUComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.CPUComboBox.Location = new System.Drawing.Point(38, 383);
            this.CPUComboBox.Name = "CPUComboBox";
            this.CPUComboBox.Size = new System.Drawing.Size(232, 26);
            this.CPUComboBox.TabIndex = 2;
            this.CPUComboBox.Text = "Select CPU level (0 for default)";
            //
            // GPUComboBox
            //
            this.GPUComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPUComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.GPUComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.GPUComboBox.FormattingEnabled = true;
            this.GPUComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.GPUComboBox.Location = new System.Drawing.Point(38, 354);
            this.GPUComboBox.Name = "GPUComboBox";
            this.GPUComboBox.Size = new System.Drawing.Size(232, 26);
            this.GPUComboBox.TabIndex = 1;
            this.GPUComboBox.Text = "Select GPU level (0 for default)";
            //
            // ResolutionLabel
            //
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResolutionLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResolutionLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResolutionLabel.Location = new System.Drawing.Point(38, 413);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(153, 18);
            this.ResolutionLabel.TabIndex = 3;
            this.ResolutionLabel.Text = "Resolution (0=default)";
            //
            // GlobalUsername
            //
            this.GlobalUsername.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.GlobalUsername.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GlobalUsername.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GlobalUsername.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GlobalUsername.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.GlobalUsername.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.GlobalUsername.Location = new System.Drawing.Point(33, 39);
            this.GlobalUsername.Name = "GlobalUsername";
            this.GlobalUsername.Size = new System.Drawing.Size(142, 24);
            this.GlobalUsername.TabIndex = 12;
            this.GlobalUsername.TextChanged += new System.EventHandler(this.GlobalUsername_TextChanged);
            //
            // TextureResTextBox
            //
            this.TextureResTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.TextureResTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.TextureResTextBox.Location = new System.Drawing.Point(38, 436);
            this.TextureResTextBox.Name = "TextureResTextBox";
            this.TextureResTextBox.Size = new System.Drawing.Size(111, 24);
            this.TextureResTextBox.TabIndex = 3;
            this.TextureResTextBox.Text = "0";
            //
            // RefreshRateComboBox
            //
            this.RefreshRateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshRateComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.RefreshRateComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.RefreshRateComboBox.FormattingEnabled = true;
            this.RefreshRateComboBox.Items.AddRange(new object[] {
            "72",
            "90",
            "120"});
            this.RefreshRateComboBox.Location = new System.Drawing.Point(38, 325);
            this.RefreshRateComboBox.Name = "RefreshRateComboBox";
            this.RefreshRateComboBox.Size = new System.Drawing.Size(232, 26);
            this.RefreshRateComboBox.TabIndex = 0;
            this.RefreshRateComboBox.Text = "Select refresh rate";
            //
            // button1
            //
            this.button1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Location = new System.Drawing.Point(185, 434);
            this.button1.Name = "button1";
            this.button1.Radius = 5;
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.Stroke = true;
            this.button1.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.TabIndex = 19;
            this.button1.Text = "APPLY";
            this.button1.Transparency = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // questVids
            //
            this.questVids.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.questVids.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.questVids.BackColor = System.Drawing.Color.Transparent;
            this.questVids.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.questVids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.questVids.ForeColor = System.Drawing.Color.White;
            this.questVids.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.questVids.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.questVids.Location = new System.Drawing.Point(72, 178);
            this.questVids.Name = "questVids";
            this.questVids.Radius = 5;
            this.questVids.Size = new System.Drawing.Size(165, 25);
            this.questVids.Stroke = true;
            this.questVids.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.questVids.TabIndex = 21;
            this.questVids.Text = "RECORDINGS";
            this.questVids.Transparency = false;
            this.questVids.Click += new System.EventHandler(this.questVids_Click);
            //
            // questPics
            //
            this.questPics.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.questPics.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.questPics.BackColor = System.Drawing.Color.Transparent;
            this.questPics.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.questPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.questPics.ForeColor = System.Drawing.Color.White;
            this.questPics.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.questPics.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.questPics.Location = new System.Drawing.Point(72, 124);
            this.questPics.Name = "questPics";
            this.questPics.Radius = 5;
            this.questPics.Size = new System.Drawing.Size(165, 25);
            this.questPics.Stroke = true;
            this.questPics.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.questPics.TabIndex = 22;
            this.questPics.Text = "SCREENSHOTS";
            this.questPics.Transparency = false;
            this.questPics.Click += new System.EventHandler(this.questPics_Click);
            //
            // button3
            //
            this.button3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.Location = new System.Drawing.Point(194, 38);
            this.button3.Name = "button3";
            this.button3.Radius = 5;
            this.button3.Size = new System.Drawing.Size(81, 25);
            this.button3.Stroke = true;
            this.button3.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button3.TabIndex = 27;
            this.button3.Text = "APPLY";
            this.button3.Transparency = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(37, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Exports to: Desktop\\Quest Recordings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // QuestForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.ClientSize = new System.Drawing.Size(309, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.questPics);
            this.Controls.Add(this.questVids);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.DeleteShots);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUComboBox);
            this.Controls.Add(this.GPUComboBox);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.GlobalUsername);
            this.Controls.Add(this.TextureResTextBox);
            this.Controls.Add(this.RefreshRateComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(325, 525);
            this.MinimumSize = new System.Drawing.Size(325, 525);
            this.Name = "QuestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestForm_FormClosed);
            this.Load += new System.EventHandler(this.QuestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RefreshRateComboBox;
        private System.Windows.Forms.TextBox TextureResTextBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox GPUComboBox;
        private System.Windows.Forms.ComboBox CPUComboBox;
        private Label label1;
        private Label label2;
        private Label label11;
        private Label label12;
        private CheckBox DeleteShots;
        private Splitter splitter1;
        private Label label10;
        private Label label14;
        private Label label16;
        private TextBox GlobalUsername;
        private RoundButton button1;
        private RoundButton questVids;
        private RoundButton questPics;
        private RoundButton button3;
        private Label label3;
    }

}
