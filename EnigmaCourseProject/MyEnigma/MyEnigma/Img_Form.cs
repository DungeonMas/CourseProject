using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnigma
{
    public partial class Img_Form : Form
    {
        public Img_Form()
        {
            InitializeComponent();
        }

        public void GiveZoomImage(PictureBox pictureBox)
        {
            user_image_pb.Image = pictureBox.Image;
        }

        private void user_image_pb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
