using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Class;
using Bs_Pro14.Utilities;
using Bs_Pro14.Classes;


namespace Bs_Pro14
{
    public partial class autoSchStudent : Form
    {
        PersonS user;
        ScheduleC Sc = new ScheduleC();
        public autoSchStudent(Person user)
        {
            this.user = new PersonS(user);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonS std;
            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            DataTable dx = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.Person  where personId='" + textBox1.Text + "'");
            if (dt.Rows.Count == 0) MessageBox.Show("!!תעודת זהות שגויה נסה שוב");
            else
            {
                dx = DatabaseManager.Connect("select * from dbo.CourseReg  where personId='" + textBox1.Text + "'");
                if (dx.Rows.Count == 0)
                {
                    std = new PersonS(dt.Rows[0]);
                    dl = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + std.Year + "' and semester='" + std.Semster + "'");
                    for (int i = 0; i < dl.Rows.Count; i++)
                    {
                        dt =DatabaseManager.Connect("select * from dbo.Lesson  where courseId='" + dl.Rows[i]["courseId"] + "'");
                        LessonS L1 = new LessonS(dt.Rows[0]);
                        Sc.regCourseToData(std, L1);
                    }
                    dl = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + std.Year+"9" + "' and semester='" + std.Semster + "'");
                    for (int i = 0; i < dl.Rows.Count; i++)
                    {
                        dt = DatabaseManager.Connect("select * from dbo.Lesson  where courseId='" + dl.Rows[i]["courseId"] + "'");
                        LessonS L1 = new LessonS(dt.Rows[0]);
                        Sc.regCourseToData(std, L1);
                    }
                    MessageBox.Show("הרישום בוצע בהצלחה");
                }
                else MessageBox.Show("אין אפשרות לבצע פעולה זו לסטודנט יש מערכת");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
