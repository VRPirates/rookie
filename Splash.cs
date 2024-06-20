using System;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        public void UpdateBackgroundImage(Image newImage)
        {
            this.BackgroundImage = newImage;
        }
    }
}
