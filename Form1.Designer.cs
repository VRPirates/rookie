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
            this.selectapkbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startsideloadbutton = new System.Windows.Forms.Button();
            this.devicesbutton = new System.Windows.Forms.Button();
            this.instructionsbutton = new System.Windows.Forms.Button();
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.selectobbbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flashfirmwarebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectapkbutton
            // 
            this.selectapkbutton.Location = new System.Drawing.Point(12, 38);
            this.selectapkbutton.Name = "selectapkbutton";
            this.selectapkbutton.Size = new System.Drawing.Size(82, 34);
            this.selectapkbutton.TabIndex = 0;
            this.selectapkbutton.Text = "Select Apk";
            this.selectapkbutton.UseVisualStyleBackColor = true;
            this.selectapkbutton.Click += new System.EventHandler(this.selectapkbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 1;
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.Location = new System.Drawing.Point(298, 39);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Size = new System.Drawing.Size(87, 33);
            this.startsideloadbutton.TabIndex = 2;
            this.startsideloadbutton.Text = "Start Sideload";
            this.startsideloadbutton.UseVisualStyleBackColor = true;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.Location = new System.Drawing.Point(12, 78);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(82, 34);
            this.devicesbutton.TabIndex = 3;
            this.devicesbutton.Text = "Adb devices";
            this.devicesbutton.UseVisualStyleBackColor = true;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // instructionsbutton
            // 
            this.instructionsbutton.Location = new System.Drawing.Point(298, 79);
            this.instructionsbutton.Name = "instructionsbutton";
            this.instructionsbutton.Size = new System.Drawing.Size(88, 30);
            this.instructionsbutton.TabIndex = 4;
            this.instructionsbutton.Text = "Instructions";
            this.instructionsbutton.UseVisualStyleBackColor = true;
            this.instructionsbutton.Click += new System.EventHandler(this.instructionsbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.Location = new System.Drawing.Point(145, 75);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Size = new System.Drawing.Size(82, 34);
            this.obbcopybutton.TabIndex = 5;
            this.obbcopybutton.Text = "Copy Obb";
            this.obbcopybutton.UseVisualStyleBackColor = true;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // selectobbbutton
            // 
            this.selectobbbutton.Location = new System.Drawing.Point(145, 39);
            this.selectobbbutton.Name = "selectobbbutton";
            this.selectobbbutton.Size = new System.Drawing.Size(82, 34);
            this.selectobbbutton.TabIndex = 6;
            this.selectobbbutton.Text = "Select Obb";
            this.selectobbbutton.UseVisualStyleBackColor = true;
            this.selectobbbutton.Click += new System.EventHandler(this.selectobbbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // flashfirmwarebutton
            // 
            this.flashfirmwarebutton.Location = new System.Drawing.Point(12, 145);
            this.flashfirmwarebutton.Name = "flashfirmwarebutton";
            this.flashfirmwarebutton.Size = new System.Drawing.Size(82, 34);
            this.flashfirmwarebutton.TabIndex = 8;
            this.flashfirmwarebutton.Text = "Flash Firmware";
            this.flashfirmwarebutton.UseVisualStyleBackColor = true;
            this.flashfirmwarebutton.Click += new System.EventHandler(this.flashfirmwarebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 184);
            this.Controls.Add(this.flashfirmwarebutton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selectobbbutton);
            this.Controls.Add(this.obbcopybutton);
            this.Controls.Add(this.instructionsbutton);
            this.Controls.Add(this.devicesbutton);
            this.Controls.Add(this.startsideloadbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectapkbutton);
            this.Name = "Form1";
            this.Text = "Rookie SideLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectapkbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startsideloadbutton;
        private System.Windows.Forms.Button devicesbutton;
        private System.Windows.Forms.Button instructionsbutton;
        private System.Windows.Forms.Button obbcopybutton;
        private System.Windows.Forms.Button selectobbbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button flashfirmwarebutton;
    }
}

