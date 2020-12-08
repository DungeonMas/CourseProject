using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Capcha : Form
    {
        Random rnd = new Random();

        public Capcha()
        {
            InitializeComponent();
        }

        private void GenerateCapcha()
        {
            string fullAlphabet = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            capcha_label.Text = "";
            for (int i = 0; i < 5; ++i)
                capcha_label.Text += fullAlphabet[rnd.Next(fullAlphabet.Length)];
        }

        private void complete_Button_Click(object sender, EventArgs e)
        {
            if(capcha_label.Text == capcha_textBox.Text)
            {
                this.Close();
            }
            else
            {
                GenerateCapcha();
                capcha_textBox.Clear();
            }
        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            GenerateCapcha();
        }

        private void reload_capcha_label_Click(object sender, EventArgs e)
        {
            GenerateCapcha();
        }

        
    }
}
