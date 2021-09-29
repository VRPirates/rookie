using AndroidSideloader.Utilities;
using JR.Utils.GUI.Forms;
using Newtonsoft.Json;
using SergeUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class DonorsListViewForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public DonorsListViewForm()
        {
            InitializeComponent();
            Donors.initDonorGames();
            List<ListViewItem> DGameList = new List<ListViewItem>();
            foreach (string[] release in Donors.donorGames)
            {
                ListViewItem DGame = new ListViewItem(release);
                DGameList.Add(DGame);
            }
            ListViewItem[] arr = DGameList.ToArray();
            DonorsListView.BeginUpdate();
            DonorsListView.Items.Clear();
            DonorsListView.Items.AddRange(arr);
            DonorsListView.EndUpdate();
        }

        public static string DonorsLocal = MainForm.DonorApps;
        public static bool ifuploads = false;
        public static string newAppsForList = "";


        private void DonorsListViewForm_Load(object sender, EventArgs e)
        {
            MainForm.updatesnotified = true;
            if (MainForm.updates && MainForm.newapps)
                bothdet.Visible = true;
            else if (MainForm.updates && !MainForm.newapps)
                upddet.Visible = true;
            else
                newdet.Visible = true;

            foreach (ListViewItem listItem in DonorsListView.Items)
            { 
                if (listItem.SubItems[Donors.UpdateOrNew].Text.Contains("Update"))
                    listItem.BackColor = Color.FromArgb(0, 79, 97);
            }

        }

        private async void DonateButton_Click(object sender, EventArgs e)
        {
            if (DonorsListView.CheckedItems.Count > 0)
            {
                bool uncheckednewapps = false;
                foreach (ListViewItem listItem in DonorsListView.Items)
                {
                    if (!listItem.Checked)
                    {
                        if (listItem.SubItems[Donors.UpdateOrNew].Text.Contains("New"))
                        {
                            uncheckednewapps = true;
                            newAppsForList += listItem.SubItems[Donors.GameNameIndex].Text + ";" + listItem.SubItems[Donors.PackageNameIndex].Text + "\n";
                        }
                    }
                }
                if (uncheckednewapps)
                {
     
                    NewApps NewAppForm = new NewApps();
                    NewAppForm.ShowDialog();
                    this.Hide();
                }
                else
                this.Hide();
                int count = 0;
                count = DonorsListView.CheckedItems.Count;
                string[] gamesToUpload;
                gamesToUpload = new string[count];
                for (int i = 0; i < count; i++)
                {
                    ulong vcode = Convert.ToUInt64(DonorsListView.CheckedItems[i].SubItems[Donors.VersionCodeIndex].Text);
                    if (DonorsListView.CheckedItems[i].SubItems[Donors.UpdateOrNew].Text.Contains("Update"))
                     await Program.form.extractAndPrepareGameToUploadAsync(DonorsListView.CheckedItems[i].SubItems[Donors.GameNameIndex].Text, DonorsListView.CheckedItems[i].SubItems[Donors.PackageNameIndex].Text, vcode, true);
                    else 
                     await Program.form.extractAndPrepareGameToUploadAsync(DonorsListView.CheckedItems[i].SubItems[Donors.GameNameIndex].Text, DonorsListView.CheckedItems[i].SubItems[Donors.PackageNameIndex].Text, vcode, false);
                    ifuploads = true;
                }
            }

            if (ifuploads)
            {
                MainForm.DoUpload();
            }
            this.Close();
        } 

        private void DonorsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (DonorsListView.CheckedItems.Count == 0)
            {
                SkipButton.Enabled = true;
                DonateButton.Enabled = false;
            }
            else
            {
                DonateButton.Enabled = true;
                SkipButton.Enabled = false;
            }
        }


        private void SkipButton_Click(object sender, EventArgs e)
        {
            bool uncheckednewapps = false;
            foreach (ListViewItem listItem in DonorsListView.Items)
            {
                if (!listItem.Checked)
                {
                    if (listItem.SubItems[Donors.UpdateOrNew].Text.Contains("New"))
                    {
                        uncheckednewapps = true;
                        newAppsForList += listItem.SubItems[Donors.GameNameIndex].Text + ";" + listItem.SubItems[Donors.PackageNameIndex].Text + "\n";
                    }
                }
            }
            if (uncheckednewapps)
            {
                NewApps NewAppForm = new NewApps();
                NewAppForm.ShowDialog();
            }
            this.Close();
        }

        private void DonorsListViewForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DonorsListViewForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void DonorsListViewForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
