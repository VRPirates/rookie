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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetQU = new System.Windows.Forms.Button();
            this.QUon = new System.Windows.Forms.CheckBox();
            this.CPUComboBox = new System.Windows.Forms.ComboBox();
            this.GPUComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.FOVy = new System.Windows.Forms.TextBox();
            this.FOVx = new System.Windows.Forms.TextBox();
            this.UsrBox = new System.Windows.Forms.TextBox();
            this.ResBox = new System.Windows.Forms.TextBox();
            this.TextureResTextBox = new System.Windows.Forms.TextBox();
            this.QUEnable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QURfrRt = new System.Windows.Forms.ComboBox();
            this.RefreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temporary settings for all Quest apps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(97, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reboot to reset. - Turn screen off, \r\nthen back on with hold button to apply.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Install -QU releases w/ custom settings ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(127, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Persists on device reboot. \r\nEnter 0 to reset any category.\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetQU
            // 
            this.ResetQU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetQU.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ResetQU.Location = new System.Drawing.Point(252, 606);
            this.ResetQU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetQU.Name = "ResetQU";
            this.ResetQU.Size = new System.Drawing.Size(225, 28);
            this.ResetQU.TabIndex = 8;
            this.ResetQU.Text = "Clear Settings";
            this.ResetQU.UseVisualStyleBackColor = false;
            this.ResetQU.Visible = false;
            this.ResetQU.Click += new System.EventHandler(this.Clear_click);
            // 
            // QUon
            // 
            this.QUon.AutoSize = true;
            this.QUon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QUon.Cursor = System.Windows.Forms.Cursors.Default;
            this.QUon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QUon.Location = new System.Drawing.Point(189, 389);
            this.QUon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QUon.Name = "QUon";
            this.QUon.Size = new System.Drawing.Size(95, 29);
            this.QUon.TabIndex = 9;
            this.QUon.Text = "Enable";
            this.QUon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QUon.UseVisualStyleBackColor = true;
            this.QUon.CheckedChanged += new System.EventHandler(this.QUon_CheckedChanged);
            // 
            // CPUComboBox
            // 
            this.CPUComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.CPUComboBox.Location = new System.Drawing.Point(17, 155);
            this.CPUComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CPUComboBox.Name = "CPUComboBox";
            this.CPUComboBox.Size = new System.Drawing.Size(459, 26);
            this.CPUComboBox.TabIndex = 5;
            this.CPUComboBox.Text = "Select CPU level (0 for default)";
            // 
            // GPUComboBox
            // 
            this.GPUComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.GPUComboBox.Location = new System.Drawing.Point(17, 119);
            this.GPUComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPUComboBox.Name = "GPUComboBox";
            this.GPUComboBox.Size = new System.Drawing.Size(459, 26);
            this.GPUComboBox.TabIndex = 4;
            this.GPUComboBox.Text = "Select GPU level (0 for default)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label7.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label7.Location = new System.Drawing.Point(17, 528);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fov - X";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label8.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label8.Location = new System.Drawing.Point(248, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fov - Y";
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label10.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label10.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label10.Location = new System.Drawing.Point(248, 582);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Clear all fields";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label9.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label9.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label9.Location = new System.Drawing.Point(15, 582);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Refresh Rate";
            this.label9.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label6.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label6.Location = new System.Drawing.Point(17, 475);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enter Custom Username";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label5.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label5.Location = new System.Drawing.Point(17, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Custom Resolution Width (Height auto calculated)";
            this.label5.Visible = false;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResolutionLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResolutionLabel.Location = new System.Drawing.Point(211, 191);
            this.ResolutionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(240, 20);
            this.ResolutionLabel.TabIndex = 3;
            this.ResolutionLabel.Text = "Resolution per eye (0 for default)";
            // 
            // FOVy
            // 
            this.FOVy.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.FOVy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVy.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVy.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.FOVy.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.FOVy.Location = new System.Drawing.Point(251, 553);
            this.FOVy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FOVy.Name = "FOVy";
            this.FOVy.Size = new System.Drawing.Size(225, 25);
            this.FOVy.TabIndex = 2;
            this.FOVy.Visible = false;
            this.FOVy.TextChanged += new System.EventHandler(this.FOVy_TextChanged);
            // 
            // FOVx
            // 
            this.FOVx.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.FOVx.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVx.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVx.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FOVx.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.FOVx.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.FOVx.Location = new System.Drawing.Point(17, 553);
            this.FOVx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FOVx.Name = "FOVx";
            this.FOVx.Size = new System.Drawing.Size(224, 25);
            this.FOVx.TabIndex = 2;
            this.FOVx.Visible = false;
            this.FOVx.TextChanged += new System.EventHandler(this.FOVx_TextChanged);
            // 
            // UsrBox
            // 
            this.UsrBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.UsrBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsrBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsrBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsrBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.UsrBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.UsrBox.Location = new System.Drawing.Point(17, 498);
            this.UsrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsrBox.Name = "UsrBox";
            this.UsrBox.Size = new System.Drawing.Size(459, 25);
            this.UsrBox.TabIndex = 2;
            this.UsrBox.Visible = false;
            this.UsrBox.TextChanged += new System.EventHandler(this.UsrBox_TextChanged);
            // 
            // ResBox
            // 
            this.ResBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.ResBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResBox.Location = new System.Drawing.Point(17, 446);
            this.ResBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(459, 25);
            this.ResBox.TabIndex = 2;
            this.ResBox.Visible = false;
            this.ResBox.TextChanged += new System.EventHandler(this.ResBox_TextChanged);
            // 
            // TextureResTextBox
            // 
            this.TextureResTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.TextureResTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.TextureResTextBox.Location = new System.Drawing.Point(17, 191);
            this.TextureResTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextureResTextBox.Name = "TextureResTextBox";
            this.TextureResTextBox.Size = new System.Drawing.Size(159, 25);
            this.TextureResTextBox.TabIndex = 2;
            this.TextureResTextBox.Text = "0";
            // 
            // QUEnable
            // 
            this.QUEnable.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.QUEnable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QUEnable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QUEnable.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QUEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QUEnable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QUEnable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QUEnable.Location = new System.Drawing.Point(361, 647);
            this.QUEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QUEnable.Name = "QUEnable";
            this.QUEnable.Size = new System.Drawing.Size(116, 42);
            this.QUEnable.TabIndex = 1;
            this.QUEnable.Text = "Apply";
            this.QUEnable.UseVisualStyleBackColor = false;
            this.QUEnable.Visible = false;
            this.QUEnable.Click += new System.EventHandler(this.QUEnable_Click);
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
            this.button1.Location = new System.Drawing.Point(361, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QURfrRt
            // 
            this.QURfrRt.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.QURfrRt.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QURfrRt.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QURfrRt.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QURfrRt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QURfrRt.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QURfrRt.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QURfrRt.FormattingEnabled = true;
            this.QURfrRt.Items.AddRange(new object[] {
            "",
            "0",
            "72",
            "90",
            "120"});
            this.QURfrRt.Location = new System.Drawing.Point(17, 606);
            this.QURfrRt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QURfrRt.Name = "QURfrRt";
            this.QURfrRt.Size = new System.Drawing.Size(224, 26);
            this.QURfrRt.TabIndex = 0;
            this.QURfrRt.Visible = false;
            this.QURfrRt.SelectedIndexChanged += new System.EventHandler(this.QURfrRt_SelectedIndexChanged);
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
            "90",
            "120"});
            this.RefreshRateComboBox.Location = new System.Drawing.Point(17, 84);
            this.RefreshRateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshRateComboBox.Name = "RefreshRateComboBox";
            this.RefreshRateComboBox.Size = new System.Drawing.Size(459, 26);
            this.RefreshRateComboBox.TabIndex = 0;
            this.RefreshRateComboBox.Text = "Select refresh rate";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(17, 647);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete custom settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(491, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QUon);
            this.Controls.Add(this.ResetQU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUComboBox);
            this.Controls.Add(this.GPUComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.FOVy);
            this.Controls.Add(this.FOVx);
            this.Controls.Add(this.UsrBox);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.TextureResTextBox);
            this.Controls.Add(this.QUEnable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QURfrRt);
            this.Controls.Add(this.RefreshRateComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(509, 741);
            this.MinimumSize = new System.Drawing.Size(509, 741);
            this.Name = "QuestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestForm_FormClosed);
            this.Load += new System.EventHandler(this.QuestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RefreshRateComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextureResTextBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox GPUComboBox;
        private System.Windows.Forms.ComboBox CPUComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox QURfrRt;
        private TextBox ResBox;
        private TextBox UsrBox;
        private TextBox FOVx;
        private TextBox FOVy;
        private Button QUEnable;
        private Button ResetQU;
        private CheckBox QUon;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
    }

}
