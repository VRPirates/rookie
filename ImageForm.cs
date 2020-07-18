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
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Shown(object sender, EventArgs e)
        {
            //this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            pictureBox1.Size = this.Size;

            pictureBox1.Image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\warning.png");
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }

        private void ImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 obj = (Form1)Application.OpenForms["Form1"];
            obj.Close();
        }
    }
}
