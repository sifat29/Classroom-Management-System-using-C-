using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.flag_1 = 1;
            this.Hide();
            lg.Show();
        }

        private void Faculty_Click(object sender, EventArgs e)
        {
            Program.user = "Faculty";
            Login lg = new Login();
            lg.flag_1 = 2;
            this.Hide();
            lg.Show();
        }

        private void Club_President_Click(object sender, EventArgs e)
        {
            Program.user = "Club President";
            Login lg = new Login();
            lg.flag_1 = 3;
            this.Hide();
            lg.Show();
        }
    }
}
