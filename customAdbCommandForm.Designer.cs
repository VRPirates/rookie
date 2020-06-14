namespace AndroidSideloader
{
    partial class customAdbCommandForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.runcustomadbcmdbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter your command here";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 365);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // runcustomadbcmdbutton
            // 
            this.runcustomadbcmdbutton.Location = new System.Drawing.Point(13, 410);
            this.runcustomadbcmdbutton.Name = "runcustomadbcmdbutton";
            this.runcustomadbcmdbutton.Size = new System.Drawing.Size(93, 28);
            this.runcustomadbcmdbutton.TabIndex = 2;
            this.runcustomadbcmdbutton.Text = "Run";
            this.runcustomadbcmdbutton.UseVisualStyleBackColor = true;
            this.runcustomadbcmdbutton.Click += new System.EventHandler(this.runcustomadbcmdbutton_Click);
            // 
            // customAdbCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runcustomadbcmdbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "customAdbCommandForm";
            this.Text = "customAdbCommandForm";
            this.Load += new System.EventHandler(this.customAdbCommandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button runcustomadbcmdbutton;
    }
}