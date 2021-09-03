
namespace AndroidSideloader
{
    partial class UpdateForm
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
            this.YesUpdate = new System.Windows.Forms.Button();
            this.SkipUpdate = new System.Windows.Forms.Label();
            this.UpdateTextBox = new System.Windows.Forms.RichTextBox();
            this.CurrentVerLabel = new System.Windows.Forms.Label();
            this.UpdateVerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YesUpdate
            // 
            this.YesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.YesUpdate.ForeColor = System.Drawing.Color.White;
            this.YesUpdate.Location = new System.Drawing.Point(281, 246);
            this.YesUpdate.Name = "YesUpdate";
            this.YesUpdate.Size = new System.Drawing.Size(166, 31);
            this.YesUpdate.TabIndex = 0;
            this.YesUpdate.Text = "Install Update";
            this.YesUpdate.UseVisualStyleBackColor = false;
            this.YesUpdate.Click += new System.EventHandler(this.YesUpdate_Click);
            // 
            // SkipUpdate
            // 
            this.SkipUpdate.AutoSize = true;
            this.SkipUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.SkipUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SkipUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SkipUpdate.Location = new System.Drawing.Point(383, 280);
            this.SkipUpdate.Name = "SkipUpdate";
            this.SkipUpdate.Size = new System.Drawing.Size(64, 13);
            this.SkipUpdate.TabIndex = 4;
            this.SkipUpdate.Text = "skip for now";
            this.SkipUpdate.Click += new System.EventHandler(this.SkipUpdate_Click);
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UpdateTextBox.ForeColor = System.Drawing.Color.White;
            this.UpdateTextBox.Location = new System.Drawing.Point(17, 15);
            this.UpdateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.ReadOnly = true;
            this.UpdateTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.UpdateTextBox.Size = new System.Drawing.Size(432, 222);
            this.UpdateTextBox.TabIndex = 1;
            this.UpdateTextBox.Text = "";
            // 
            // CurrentVerLabel
            // 
            this.CurrentVerLabel.AutoSize = true;
            this.CurrentVerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CurrentVerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CurrentVerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CurrentVerLabel.Location = new System.Drawing.Point(12, 246);
            this.CurrentVerLabel.Name = "CurrentVerLabel";
            this.CurrentVerLabel.Size = new System.Drawing.Size(94, 15);
            this.CurrentVerLabel.TabIndex = 2;
            this.CurrentVerLabel.Text = "Current Version:";
            // 
            // UpdateVerLabel
            // 
            this.UpdateVerLabel.AutoSize = true;
            this.UpdateVerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.UpdateVerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdateVerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateVerLabel.Location = new System.Drawing.Point(12, 262);
            this.UpdateVerLabel.Name = "UpdateVerLabel";
            this.UpdateVerLabel.Size = new System.Drawing.Size(94, 15);
            this.UpdateVerLabel.TabIndex = 3;
            this.UpdateVerLabel.Text = "Update Version:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UpdateVerLabel);
            this.panel1.Controls.Add(this.YesUpdate);
            this.panel1.Controls.Add(this.CurrentVerLabel);
            this.panel1.Controls.Add(this.SkipUpdate);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 297);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 227);
            this.panel2.TabIndex = 0;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(466, 301);
            this.ControlBox = false;
            this.Controls.Add(this.UpdateTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesUpdate;
        private System.Windows.Forms.Label SkipUpdate;
        private System.Windows.Forms.RichTextBox UpdateTextBox;
        private System.Windows.Forms.Label CurrentVerLabel;
        private System.Windows.Forms.Label UpdateVerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}