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
    public partial class SecrViewSchedule : Form
    {
        Person user;
        ScheduleC Sc = new ScheduleC();

        private DataTable dt = new DataTable();
        private DataTable dl = new DataTable();
        private DataTable dc = new DataTable();

        public SecrViewSchedule(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();
        }

        private void a1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            b1.Controls.Clear();
            b2.Controls.Clear();
            b3.Controls.Clear();
            b4.Controls.Clear();
            b5.Controls.Clear();
            b6.Controls.Clear();

            dt = new DataTable();
            dl = new DataTable();
            dc = new DataTable();

            dt = DatabaseManager.Connect("select * from dbo.Person where personID ='" + textBox1.Text + "'");

            if (textBox1.Text.Length != 9)
                MessageBox.Show("ID length is wrong");
            else if (dt.Rows.Count == 0)
                MessageBox.Show("Student wasn't found");
            else
            {
                int s, end, day;
                dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + textBox1.Text + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dl = DatabaseManager.Connect("select * from dbo.Lesson where lessonId='" + dt.Rows[i]["lessonId"] + "'");
                    dc = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");

                    Label label = new Label();
                    label.Text = (string)dc.Rows[0]["courseName"];
                    day = Sc.findDay(dl.Rows[0]["weekDay"].ToString());
                    s = (Sc.findTime(dl.Rows[0]["startTime"].ToString()) - 1);
                    end = (Sc.findTime(dl.Rows[0]["endTime"].ToString()) - 1);

                    if (day == 5) Sc.fillCourseInSch("", label, 0, s, end, b1);
                    if (day == 4) Sc.fillCourseInSch("", label, 0, s, end, b2);
                    if (day == 3) Sc.fillCourseInSch("", label, 0, s, end, b3);
                    if (day == 2) Sc.fillCourseInSch("", label, 0, s, end, b4);
                    if (day == 1) Sc.fillCourseInSch("", label, 0, s, end, b5);
                    if (day == 0) Sc.fillCourseInSch("", label, 0, s, end, b6);


                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
