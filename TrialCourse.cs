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
    public partial class TrialCourse : Form
    {
        Person user;
        ScheduleC Sc = new ScheduleC();
        private int[] courseId = new int[12];
        public TrialCourse(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year=0 and semester=0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                course.Items.Add(dt.Rows[i]["courseName"]);
                courseId[i] = (int)dt.Rows[i]["courseId"];
            }
            DatabaseManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //להשלים בדיקות- חפיפות של קורסים מבחינת שעות, שלא נרשם כבר לקורס הנוכחי, יתרת נקז (שלא הגיע למכסה) וכמות סטודנטים הרשומים לקורס
            Boolean flag=true;
           
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseName='" + course.SelectedItem + "'");
            Course c1 = new Course(dt.Rows[0]);
            flag = Sc.checkStdRegCourse(user, c1);
            if (Sc.checkNumCredit(user) != 26)
                flag = true;
            if (Sc.checkNumOfStudents(c1) < c1.MaxOfStudent)
                flag = true;
            DataTable dl = new DataTable();
            dl = DatabaseManager.Connect("select * from dbo.Lesson where courseId='" + c1.CourseId + "'");

            for (int i = 0; i < dl.Rows.Count; i++)
            {
                if (String.Equals((dl.Rows[i]["startTime"] + "-" + dl.Rows[i]["endTime"] + " " + dl.Rows[i]["weekDay"]), comboBox2.SelectedItem))
                {
                   Lesson lesson = new Lesson(dl.Rows[i]);
                    flag = Sc.checkDupLesson(user, lesson);

                    if (flag == true) //לא נרשם לקורס הזה כבר
                        Sc.regCourseToData(user, lesson);

                    else
                    {
                        MessageBox.Show("הרישום לקורס נכשל, נסה שנית");
                        this.Hide();
                        DatabaseManager.CloseConnection();
                        MainStudent back1 = new MainStudent(user);
                        back1.Show();
                    }
                }
            }
          
            DatabaseManager.CloseConnection();
            MainStudent back = new MainStudent(user);
            back.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("הרישום לקורס ניסיון בוצע בהצלחה");
            this.Hide();
            MainStudent back = new MainStudent(user);
            back.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fillComboBox(comboBox2, course);
        }
        public void fillComboBox(ComboBox time, ComboBox courses)
        {
            time.Items.Clear();
            DataTable dt = new DataTable();
            string name = (string)courses.SelectedItem;
            if(courses.Text=="") MessageBox.Show("אפשרות לא נבחרה");
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

        private void TrialCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
