using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            CurrentVerLabel.Text += " " + Updater.LocalVersion;
            UpdateVerLabel.Text += " " + Updater.currentVersion;
            UpdateTextBox.Text = Updater.changelog;
        }

        private void YesUpdate_Click(object sender, EventArgs e)
        {
            Updater.doUpdate();
            this.Close();
        }

        private void SkipUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
