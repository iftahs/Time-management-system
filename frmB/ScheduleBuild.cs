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
using Bs_Pro14.Classes;


namespace Bs_Pro14
{
    public partial class ScheduleBuild : Form
    {
        DataTable dt,dl,db;
        private int[] courseId = new int[6];
        PersonS std;
        CourseS c1;
        ScheduleC Sc = new ScheduleC();
        public ScheduleBuild(PersonS user)
        {
            std = new PersonS(user);
            InitializeComponent();
            Sc.realtimeUpdateSch(Schdule, std);
            dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + user.Year + "' and semester='" + user.Semster + "'and practice='"+false+"'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                courses.Items.Add(dt.Rows[i]["courseName"]);
                courseId[i] = (int)dt.Rows[i]["courseId"];
            }
            Controls.Add(Schdule);
            textBox1.Clear();
            textBox1.AppendText(Sc.checkNumCredit(std).ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("נשלח להדפסה");
        }

        private void button5_Click(object sender, EventArgs e)/*בחירת קורס*/
         {
            if (time.SelectedItem!=null)
            {
                Label label = new Label();
                Label label1 = new Label();
                label.Text = (string)courses.Text;
                label1.Text = (string)courses.Text + " practice";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((string)time.SelectedItem == (string)time.Items[i])
                    {
                        ClearCourse();
                        Sc.fillCourseInSch("new", label, Sc.findDay(dt.Rows[i]["weekDay"].ToString()), Sc.findTime(dt.Rows[i]["startTime"].ToString()), Sc.findTime(dt.Rows[i]["endTime"].ToString()), Schdule);
                        Controls.Add(Schdule);
                    }
                    if (timeT.Items.Count != 0)
                    {
                        if(timeT.SelectedItem!=null)
                        {
                            if ((string)timeT.SelectedItem == (string)timeT.Items[i])
                            {
                                Sc.fillCourseInSch("new", label1, Sc.findDay(dl.Rows[i]["weekDay"].ToString()), Sc.findTime(dl.Rows[i]["startTime"].ToString()), Sc.findTime(dl.Rows[i]["endTime"].ToString()), Schdule);
                                Controls.Add(Schdule);
                            }
                        }
                        else MessageBox.Show("קורס נבחר לחץ שמור כי להרשם לקורס");
                    }

                }
                MessageBox.Show("קורס נבחר לחץ שמור כי להרשם לקורס");
            }
            else MessageBox.Show("!!לא נבחרו שעות נסה שוב");
        }

        private void button6_Click(object sender, EventArgs e)/*רענון זמנים*/
        {
            time.Items.Clear();
            timeT.Items.Clear();
            dt = new DataTable();
            dl = new DataTable();
            db = new DataTable();
            string name = (string)courses.SelectedItem;
            for (int i = 0; i < courses.Items.Count; i++)
            {
                if (name == (string)courses.Items[i])
                {
                    dt = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + courseId[i] + "'");
                }
            }
            db= DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseName='" + name +" T"+ "'");
            if(db.Rows.Count!=0)dl = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + db.Rows[0]["courseId"] + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                time.Items.Add(dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + " " + dt.Rows[i]["weekDay"]);
            }
            for (int i = 0; i < dl.Rows.Count; i++)
            {
                timeT.Items.Add(dl.Rows[i]["startTime"] + "-" + dl.Rows[i]["endTime"] + " " + dl.Rows[i]["weekDay"]);
            }
        }
        private void ClearCourse()/*clear from the schdule the course*/
        {
            int day, s, e;
            for (int i = 0; i < time.Items.Count; i++)
            {
                day = Sc.findDay(dt.Rows[i]["weekDay"].ToString());
                s = Sc.findTime(dt.Rows[i]["startTime"].ToString());
                e = Sc.findTime(dt.Rows[i]["endTime"].ToString());
                for (int j = s; j < e; j++)
                {
                    if (Schdule.GetControlFromPosition(day, j) != null)
                    {
                        Schdule.Controls.Remove(Schdule.GetControlFromPosition(day, j));
                    }
                }
            }
            for (int i = 0; i < timeT.Items.Count; i++)
            {
                day = Sc.findDay(dl.Rows[i]["weekDay"].ToString());
                s = Sc.findTime(dl.Rows[i]["startTime"].ToString());
                e = Sc.findTime(dl.Rows[i]["endTime"].ToString());
                for (int j = s; j < e; j++)
                {
                    if (Schdule.GetControlFromPosition(day, j) != null)
                    {
                        Schdule.Controls.Remove(Schdule.GetControlFromPosition(day, j));
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)/*רישום לקורס*/
        {
            db = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[0]["courseId"] + "'");
            c1 = new CourseS(db.Rows[0]);
           // db = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + std.ID + "'and courseId='"+c1.CourseId+ "'");
            if (time.SelectedItem != null && courses.SelectedItem != null)
            {
                if (!(Sc.checkStdRegCourse(std, c1)))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (String.Equals((dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + " " + dt.Rows[i]["weekDay"]), time.SelectedItem))
                        {
                            LessonS lesson = new LessonS(dt.Rows[i]);
                            if (Sc.checkDupLesson(std, lesson)) Sc.upCourseToData(std, lesson, (int)db.Rows[0]["regId"]);
                        }
                    }
                    for (int i = 0; i < dl.Rows.Count; i++)
                    {
                        if (String.Equals((dl.Rows[i]["startTime"] + "-" + dl.Rows[i]["endTime"] + " " + dl.Rows[i]["weekDay"]), timeT.SelectedItem))
                        {
                            LessonS lesson = new LessonS(dl.Rows[i]);
                            if (Sc.checkDupLesson(std, lesson)) Sc.upCourseToData(std, lesson, (int)db.Rows[0]["regId"]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (String.Equals((dt.Rows[i]["startTime"] + "-" + dt.Rows[i]["endTime"] + " " + dt.Rows[i]["weekDay"]), time.SelectedItem))
                        {
                            LessonS lesson = new LessonS(dt.Rows[i]);
                            if (Sc.checkDupLesson(std, lesson))Sc.regCourseToData(std,lesson);
                        }
                    }
                    for (int i = 0; i < dl.Rows.Count; i++)
                    {
                        if (String.Equals((dl.Rows[i]["startTime"] + "-" + dl.Rows[i]["endTime"] + " " + dl.Rows[i]["weekDay"]), timeT.SelectedItem))
                        {
                            LessonS lesson = new LessonS(dl.Rows[i]);
                            if (Sc.checkDupLesson(std, lesson)) Sc.regCourseToData(std, lesson);
                        }
                    }
                }
                Sc.realtimeUpdateSch(Schdule, std);
                textBox1.Clear();
                textBox1.AppendText(Sc.checkNumCredit(std).ToString());
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void time_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleBuild_Load(object sender, EventArgs e)
        {

        }
    }
}

