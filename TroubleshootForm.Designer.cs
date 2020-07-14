namespace AndroidSideloader
{
    partial class TroubleshootForm
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
            this.askTextBox = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askTextBox
            // 
            this.askTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.askTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.askTextBox.Location = new System.Drawing.Point(9, 10);
            this.askTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.askTextBox.Name = "askTextBox";
            this.askTextBox.Size = new System.Drawing.Size(582, 19);
            this.askTextBox.TabIndex = 0;
            this.askTextBox.Text = "Ask me any question about sideloading";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(582, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ask the software";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TroubleshootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(602, 72);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.askTextBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 111);
            this.MinimumSize = new System.Drawing.Size(618, 111);
            this.Name = "TroubleshootForm";
            this.ShowIcon = false;
            this.Text = "TroubleshootForm (WIP)";
            this.Load += new System.EventHandler(this.TroubleshootForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox askTextBox;
        private System.Windows.Forms.Button button1;
    }
}