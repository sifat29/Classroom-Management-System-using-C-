using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Classroom_Management_System01
{
    public partial class Login : Form
    {
        public int flag_1;
        public Login()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = class_room";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            if (flag_1 == 1)
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From adminlogin where AUserName = '" + this.Usernametext.Text.Trim() + "'and APassword = '" + this.Passwordtext.Text.Trim() + " ' ", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Options op = new Options();
                    this.Hide();
                    op.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else if (flag_1 == 2)
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From facultylogin where FUserName = '" + this.Usernametext.Text.Trim() + "'and FPassword = '" + this.Passwordtext.Text.Trim() + " ' ", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Search sc = new Search();
                    this.Hide();
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else if (flag_1 == 3)
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From clubpresidentlogin where CUserName = '" + this.Usernametext.Text.Trim() + "'and Cpassword = '" + this.Passwordtext.Text.Trim() + " ' ", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Search sc = new Search();
                    this.Hide();
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.Show();
        }
    }
}
