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
    public partial class LecViewCourses : Form
    {
        Person user;
        ScheduleC Sc = new ScheduleC();
        private DataTable dt=new DataTable();
        private DataTable dl=new DataTable();
        private int[] courseId = new int[6];
        public LecViewCourses(Person user)
        {
            InitializeComponent();
            this.user = new Person(user);
            List<Lesson> LCourse = new List<Lesson>();

            

            dt = new DataTable();
            dl = new DataTable();

            dt = DatabaseManager.Connect("select * from dbo.Lesson where lecturerid='" + user.ID + "'");

            listBox1.Items.Clear();

            if (dt.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
            for (int i = 0; i < dt.Rows.Count; i++) //Loop that fill the list of courses from dbo.Lesson
            {
                LCourse.Add(new Lesson(dt.Rows[i]));
                dl = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");
                listBox1.Items.Add("Course ID: " + LCourse[i].CourseId+"\tCourse Name: "+dl.Rows[0]["courseName"]);
            }
            
            DatabaseManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
