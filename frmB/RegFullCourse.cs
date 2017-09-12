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
    public partial class RegFullCourse : Form
    {
        PersonS user;
        ScheduleC Sc = new ScheduleC();
        private int[] courseId = new int[12];
        private DataTable dt;
        private DataTable st;
        public RegFullCourse(Person user)
        {
            this.user = new PersonS(user);
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            st = new DataTable();

            dt = DatabaseManager.Connect("select * from dbo.Person where personID ='" + textBox1.Text + "'");

            if (textBox1.Text.Length != 9)
                MessageBox.Show("ID length is wrong");
            else if (dt.Rows.Count == 0)
                MessageBox.Show("Student wasn't found");
            else
            {

                int year = (int)dt.Rows[0]["year"];
                int semester = (int)dt.Rows[0]["semester"];

                st = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + year + "' and semester='" + semester + "'");


                if (st.Rows.Count == 0) comboBox1.Items.Add("רשימה ריקה");
                else
                {
                    comboBox1.Items.Clear();
                    for (int i = 0; i < st.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(st.Rows[i]["courseName"]);
                        courseId[i] = (int)st.Rows[i]["courseId"];

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TrialCourse s = new TrialCourse(user);
            //s.fillComboBox(comboBox2, comboBox1);
            comboBox2.Items.Clear();
            DataTable ds = new DataTable();
            string name = (string)comboBox1.SelectedItem;

            if (comboBox1.Text == "") MessageBox.Show("אפשרות לא נבחרה");

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (name == (string)comboBox1.Items[i])
                {
                    ds = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + courseId[i] + "'");
                }
           }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Rows[i]["startTime"] + "-" + ds.Rows[i]["endTime"] + " " + ds.Rows[i]["weekDay"]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseName='" + comboBox1.SelectedItem + "'");
            CourseS c1 = new CourseS(dt.Rows[0]);
            flag = Sc.checkStdRegCourse(user, c1);
            if (Sc.checkNumCredit(user) != 26)
                flag = true;
            DataTable dl = new DataTable();
            dl = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + c1.CourseId + "'");

            for (int i = 0; i < dl.Rows.Count; i++)
            {
                if (String.Equals((dl.Rows[i]["startTime"] + "-" + dl.Rows[i]["endTime"] + " " + dl.Rows[i]["weekDay"]), comboBox2.SelectedItem))
                {
                    LessonS lesson = new LessonS(dl.Rows[i]);
                    flag = Sc.checkDupLesson(user, lesson);

                    if (flag == true) //לא נרשם לקורס הזה כבר
                        Sc.regCourseToData(user, lesson);

                    else
                    {
                        MessageBox.Show("הרישום לקורס נכשל, נסה שנית");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
