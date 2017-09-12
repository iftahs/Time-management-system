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
    public partial class CoursesInLabs : Form
    {
        public CoursesInLabs()
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
                    at = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");

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
                    listBox1.Items.Add("Course: " + at.Rows[i]["courseName"] + "     Course ID: " + at.Rows[i]["courseId"] + "     Time:" + dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + "");
                }
            }
            DatabaseManager.CloseConnection();
        }
    }
}
