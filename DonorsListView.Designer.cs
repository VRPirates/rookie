
namespace AndroidSideloader
{
    partial class DonorsListViewForm
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
            this.DonorsListView = new System.Windows.Forms.ListView();
            this.GameNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionCodeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateOrNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CountdownLbl = new System.Windows.Forms.Label();
            this.SkipButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerDesc = new System.Windows.Forms.Label();
            this.DonateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonorsListView
            // 
            this.DonorsListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DonorsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DonorsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DonorsListView.CausesValidation = false;
            this.DonorsListView.CheckBoxes = true;
            this.DonorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameNameIndex,
            this.PackageNameIndex,
            this.VersionCodeIndex,
            this.UpdateOrNew});
            this.DonorsListView.ForeColor = System.Drawing.Color.White;
            this.DonorsListView.FullRowSelect = true;
            this.DonorsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DonorsListView.HideSelection = false;
            this.DonorsListView.Location = new System.Drawing.Point(11, 11);
            this.DonorsListView.Name = "DonorsListView";
            this.DonorsListView.RightToLeftLayout = true;
            this.DonorsListView.Size = new System.Drawing.Size(612, 370);
            this.DonorsListView.TabIndex = 0;
            this.DonorsListView.UseCompatibleStateImageBehavior = false;
            this.DonorsListView.View = System.Windows.Forms.View.Details;
            this.DonorsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DonorsListView_ItemChecked);
            // 
            // GameNameIndex
            // 
            this.GameNameIndex.Text = "Game Name";
            this.GameNameIndex.Width = 200;
            // 
            // PackageNameIndex
            // 
            this.PackageNameIndex.Text = "Packagename";
            this.PackageNameIndex.Width = 155;
            // 
            // VersionCodeIndex
            // 
            this.VersionCodeIndex.Text = "Version";
            this.VersionCodeIndex.Width = 130;
            // 
            // UpdateOrNew
            // 
            this.UpdateOrNew.Text = "Update/New App";
            this.UpdateOrNew.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.CountdownLbl);
            this.panel1.Controls.Add(this.SkipButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TimerDesc);
            this.panel1.Controls.Add(this.DonateButton);
            this.panel1.Controls.Add(this.DonorsListView);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 468);
            this.panel1.TabIndex = 1;
            // 
            // CountdownLbl
            // 
            this.CountdownLbl.AutoSize = true;
            this.CountdownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLbl.Location = new System.Drawing.Point(74, 419);
            this.CountdownLbl.Name = "CountdownLbl";
            this.CountdownLbl.Size = new System.Drawing.Size(57, 20);
            this.CountdownLbl.TabIndex = 6;
            this.CountdownLbl.Text = "label1";
            // 
            // SkipButton
            // 
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipButton.Location = new System.Drawing.Point(196, 419);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(123, 36);
            this.SkipButton.TabIndex = 5;
            this.SkipButton.Text = "Wait...";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Share at least 1 update to skip.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerDesc
            // 
            this.TimerDesc.AutoSize = true;
            this.TimerDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TimerDesc.Location = new System.Drawing.Point(22, 392);
            this.TimerDesc.Name = "TimerDesc";
            this.TimerDesc.Size = new System.Drawing.Size(591, 13);
            this.TimerDesc.TabIndex = 3;
            this.TimerDesc.Text = "NOTE: Rookie will do all of the work in the background while you use the program " +
    "as usual, the entire process is automated!";
            this.TimerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DonateButton
            // 
            this.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DonateButton.Location = new System.Drawing.Point(325, 419);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(298, 36);
            this.DonateButton.TabIndex = 1;
            this.DonateButton.Text = "Share selected apps in background.";
            this.DonateButton.UseVisualStyleBackColor = true;
            this.DonateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DonorsListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(636, 472);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DonorsListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DonorsListViewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DonorsListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DonateButton;
        private System.Windows.Forms.Label TimerDesc;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader GameNameIndex;
        private System.Windows.Forms.ColumnHeader PackageNameIndex;
        private System.Windows.Forms.ColumnHeader VersionCodeIndex;
        private System.Windows.Forms.ColumnHeader UpdateOrNew;
        private System.Windows.Forms.Label CountdownLbl;
    }
}