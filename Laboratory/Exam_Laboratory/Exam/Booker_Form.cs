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
    public partial class Booker_Form : Form
    {
        public Booker_Form()
        {
            InitializeComponent();
        }

        private void Booker_Form_Load(object sender, EventArgs e)
        {
            hello_label.Text = "Здравствуйте, " + Login.login;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
