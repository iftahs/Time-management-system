/*
 * לא גמור. צריך את יפתח שיגיד איך המרצים רשומים לקורסים 
 */

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
using Bs_Pro14.Class;


namespace Bs_Pro14
{
    public partial class LecViewStud : Form
    {
        private DataTable dt;
        private int[] courseId = new int[6];
        public LecViewStud()
        {
            InitializeComponent();
            dt = new DataTable();
            //dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where "); //למשוך את רשימת הקורסים שהמרצה רשום אליהם
            for (int i = 0; i < dt.Rows.Count; i++)                                    //TO DO 
            {
                courses.Items.Add(dt.Rows[i]["courseName"]);
                courseId[i] = (int)dt.Rows[i]["courseId"];
            }
            
            DatabaseManager.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecViewStud_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            time.Items.Clear();
            dt = new DataTable();
            string name = (string)courses.SelectedItem;
            for (int i = 0; i < courses.Items.Count; i++)
            {
                if (name == (string)courses.Items[i])
                {
                    dt = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + courseId[i] + "'");
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                time.Items.Add(dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + " " + dt.Rows[i]["weekDay"]);
            }
            DatabaseManager.CloseConnection();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
