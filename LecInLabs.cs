using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Utilities;

namespace Bs_Pro14
{
    public partial class LecInLabs : Form
    {
        public LecInLabs()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.ClassRooms where labratory=1");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["classNumber"]);
            }
            DatabaseManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainMaintenance back = new MainMaintenance();
           // back.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DataTable dt = new DataTable();
            DataTable ct = new DataTable();
            DataTable at = new DataTable();

            try
            {
                ct = DatabaseManager.Connect("select * from dbo.ClassRooms where classNumber='" + comboBox2.Text + "'");
                for (int i = 0; i < ct.Rows.Count; i++)
                {
                    dt = DatabaseManager.Connect("select * from dbo.Lesson where classId='" + ct.Rows[i]["classRoomId"] + "'");
                    at = DatabaseManager.Connect("select * from dbo.Person where personId='" + dt.Rows[i]["lecturerid"] + "'");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("אין קורסים בכיתה או ביום זה");
            }
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < ct.Rows.Count; i++)
                {
                    listBox1.Items.Add("Lecturer Name: " + at.Rows[i]["firstName"] + " " + at.Rows[i]["lastName"] + "     Time:" + dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + "");
                }
            }
            DatabaseManager.CloseConnection();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
