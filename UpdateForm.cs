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
        private bool mouseDown;
        private Point lastLocation;

        public UpdateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            CurVerLabel.Text += " " + Updater.LocalVersion;
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

        private void UpdateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UpdateForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void UpdateForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
