using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnigma
{
    public partial class Information : Form
    {
        Img_Form img_Form = new Img_Form();

        public Information()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            img_Form.GiveZoomImage(pictureBox1);
            img_Form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            img_Form.GiveZoomImage(pictureBox2);
            img_Form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            img_Form.GiveZoomImage(pictureBox3);
            img_Form.ShowDialog();
        }

        private void reference_site_Label_Click(object sender, EventArgs e)
        {
            Process.Start("https://un-sci.com/ru/2019/06/22/istoriya-zagadochnoj-i-legendarnoj-enigma/");
        }
    }
}
