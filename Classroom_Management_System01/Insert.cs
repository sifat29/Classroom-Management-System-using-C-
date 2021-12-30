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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = class_room";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `room_information`(`Room_NO`, `Campus_Building`, `Day`, `Start_Time`, `End_Time`, `Status`, `Booked_By`) VALUES('"+ this.Room_notext.Text + "','" + this.Campus_Buildingtext.Text + "','" + this.textBox1.Text + "','" + this.Start_Timetext.Text + "','" + this.Finish_Timetext.Text + "','" + this.StatusBox.SelectedItem + "','" + this.Bookedbytext.Text + "')", DBconnect);
            MySqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Entry Successful");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            this.Hide();
            op.Show();
        }
    }
}
