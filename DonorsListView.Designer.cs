
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
            this.components = new System.ComponentModel.Container();
            this.DonorsListView = new System.Windows.Forms.ListView();
            this.GameNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionCodeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateOrNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SkipButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bothdet = new System.Windows.Forms.Label();
            this.newdet = new System.Windows.Forms.Label();
            this.upddet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerDesc = new System.Windows.Forms.Label();
            this.DonateButton = new System.Windows.Forms.Button();
            this.DonationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonorsListView
            // 
            this.DonorsListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DonorsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            this.DonorsListView.Location = new System.Drawing.Point(5, 5);
            this.DonorsListView.Name = "DonorsListView";
            this.DonorsListView.RightToLeftLayout = true;
            this.DonorsListView.Size = new System.Drawing.Size(420, 223);
            this.DonorsListView.TabIndex = 0;
            this.DonorsListView.UseCompatibleStateImageBehavior = false;
            this.DonorsListView.View = System.Windows.Forms.View.Details;
            this.DonorsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DonorsListView_ItemChecked);
            this.DonorsListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.DonorsListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.DonorsListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // GameNameIndex
            // 
            this.GameNameIndex.Text = "Game Name";
            this.GameNameIndex.Width = 219;
            // 
            // PackageNameIndex
            // 
            this.PackageNameIndex.DisplayIndex = 2;
            this.PackageNameIndex.Text = "Packagename";
            this.PackageNameIndex.Width = 0;
            // 
            // VersionCodeIndex
            // 
            this.VersionCodeIndex.DisplayIndex = 3;
            this.VersionCodeIndex.Text = "Version";
            this.VersionCodeIndex.Width = 113;
            // 
            // UpdateOrNew
            // 
            this.UpdateOrNew.DisplayIndex = 1;
            this.UpdateOrNew.Text = "Donation Type";
            this.UpdateOrNew.Width = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.SkipButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bothdet);
            this.panel1.Controls.Add(this.newdet);
            this.panel1.Controls.Add(this.upddet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TimerDesc);
            this.panel1.Controls.Add(this.DonateButton);
            this.panel1.Location = new System.Drawing.Point(-7, -44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 400);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // SkipButton
            // 
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SkipButton.Location = new System.Drawing.Point(21, 322);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(101, 36);
            this.SkipButton.TabIndex = 1;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.DonorsListView);
            this.panel2.Location = new System.Drawing.Point(16, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 233);
            this.panel2.TabIndex = 7;
            // 
            // bothdet
            // 
            this.bothdet.AutoSize = true;
            this.bothdet.BackColor = System.Drawing.Color.Transparent;
            this.bothdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.bothdet.Location = new System.Drawing.Point(125, 47);
            this.bothdet.Name = "bothdet";
            this.bothdet.Size = new System.Drawing.Size(213, 17);
            this.bothdet.TabIndex = 3;
            this.bothdet.Text = "Updates/new apps detected!";
            this.bothdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bothdet.Visible = false;
            this.bothdet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.bothdet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.bothdet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // newdet
            // 
            this.newdet.AutoSize = true;
            this.newdet.BackColor = System.Drawing.Color.Transparent;
            this.newdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.newdet.Location = new System.Drawing.Point(156, 46);
            this.newdet.Name = "newdet";
            this.newdet.Size = new System.Drawing.Size(150, 17);
            this.newdet.TabIndex = 3;
            this.newdet.Text = "New apps detected!";
            this.newdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newdet.Visible = false;
            this.newdet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.newdet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.newdet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // upddet
            // 
            this.upddet.AutoSize = true;
            this.upddet.BackColor = System.Drawing.Color.Transparent;
            this.upddet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.upddet.Location = new System.Drawing.Point(163, 46);
            this.upddet.Name = "upddet";
            this.upddet.Size = new System.Drawing.Size(136, 17);
            this.upddet.TabIndex = 3;
            this.upddet.Text = "Updates detected";
            this.upddet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upddet.Visible = false;
            this.upddet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.upddet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.upddet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "All RSL apps are donated by users";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // TimerDesc
            // 
            this.TimerDesc.AutoSize = true;
            this.TimerDesc.BackColor = System.Drawing.Color.Transparent;
            this.TimerDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDesc.Location = new System.Drawing.Point(47, 363);
            this.TimerDesc.Name = "TimerDesc";
            this.TimerDesc.Size = new System.Drawing.Size(369, 15);
            this.TimerDesc.TabIndex = 3;
            this.TimerDesc.Text = "Don\'t share free apps. RSL will extract/upload apps in background.";
            this.TimerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.TimerDesc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.TimerDesc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            // 
            // DonateButton
            // 
            this.DonateButton.Enabled = false;
            this.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateButton.Location = new System.Drawing.Point(128, 322);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(313, 36);
            this.DonateButton.TabIndex = 1;
            this.DonateButton.Text = "Automatically share selected apps";
            this.DonateButton.UseVisualStyleBackColor = true;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // DonorsListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(449, 343);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DonorsListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DonorsListViewForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DonorsListViewForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DonorsListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DonateButton;
        private System.Windows.Forms.Label TimerDesc;
        private System.Windows.Forms.ColumnHeader GameNameIndex;
        private System.Windows.Forms.ColumnHeader PackageNameIndex;
        private System.Windows.Forms.ColumnHeader VersionCodeIndex;
        private System.Windows.Forms.ColumnHeader UpdateOrNew;
        public System.Windows.Forms.Timer DonationTimer;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bothdet;
        private System.Windows.Forms.Label newdet;
        private System.Windows.Forms.Label upddet;
    }
}