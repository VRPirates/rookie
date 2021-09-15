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

        public DonorsListViewForm()
        {
            InitializeComponent();

            Donors.initDonorGames();
            foreach (string column in Donors.donorGameProperties)
            {
                DonorsListView.Columns.Add(column, 150);
            }
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
            someupdates = false;
            foreach (ListViewItem DonatableApp in DonorsListView.Items)
            {
                if (DonatableApp.SubItems[Donors.UpdateOrNew].Equals("Newer version than RSL"))
                    someupdates = true;
            }
        }
        public bool someupdates = false;
        public static string DonorsLocal = MainForm.DonorApps;
        public bool timerdonetickedyahear = false;
        private System.Windows.Forms.Timer timer1;
        private int counter = 90;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            CountdownLbl.Text = counter.ToString();
        }
        private void DonorsListViewForm_Load(object sender, EventArgs e)
        {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 90000; // 1 min and 30 seconds
                timer1.Start();
                CountdownLbl.Text = counter.ToString();
        }
        private async void button1_Click(object sender, EventArgs e)
        {


            if (DonorsListView.CheckedItems.Count > 0)
            {

                int count = 0;
                count = DonorsListView.CheckedItems.Count;
                string[] gamesToUpload;
                gamesToUpload = new string[count];
                for (int i = 0; i < count; i++)
                {
                    if (DonorsListView.CheckedItems[i].SubItems[Donors.UpdateOrNew].Text.Equals("Newer version than RSL"))
                    {
                        Properties.Settings.Default.SubmittedUpdates += DonorsListView.CheckedItems[i].SubItems[Donors.PackageNameIndex].Text + ("\n");
                        Properties.Settings.Default.Save();
                    }
                    ulong vcode = Convert.ToUInt64(DonorsListView.CheckedItems[i].SubItems[Donors.VersionCodeIndex].Text);
                    await Program.form.extractAndPrepareGameToUploadAsync(DonorsListView.CheckedItems[i].SubItems[Donors.GameNameIndex].Text, DonorsListView.CheckedItems[i].SubItems[Donors.PackageNameIndex].Text, vcode);
                }
            }
            else if (someupdates)
            {
                MessageBox.Show("Please share at least one update to continue. Rookie would not exist without donations!");
            }
            foreach (ListViewItem listItem in DonorsListView.Items)
            {
                if (!listItem.Checked)
                {
                    if (listItem.SubItems[Donors.UpdateOrNew].Text.Equals("Not on RSL"))
                    {
                        DialogResult dialogResult = MessageBox.Show($"Is this a free/non-VR app:\n{listItem.SubItems[Donors.GameNameIndex].Text}", "Is this a free app?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Properties.Settings.Default.NonAppPackages += listItem.SubItems[Donors.PackageNameIndex].Text + ("\n");
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
            this.Close();
        } 

        private void DonorsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (DonorsListView.CheckedItems.Count == 0 && someupdates)
            {
                DonateButton.Enabled = false;
                MessageBox.Show("Please share at least one update to continue. Rookie would not exist without donations!");
            }
            else 
                DonateButton.Enabled = true;

        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            if (!timerdonetickedyahear)
            {
                MessageBox.Show("Nice try, FBI.\n(wait for the timer to tick or donate just ONE clean game!" +
    "\nCmon! Everyone's doing it!\nAlso Rookie just extracts the APK and OBB so no personal info or save gets transfered!");
            }
            else
            {
                this.Close();
            }

        }
    }
}
