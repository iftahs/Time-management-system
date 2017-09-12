using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bs_Pro14.Utilities;
using Bs_Pro14.Class;

namespace Bs_Pro14.Class
{
    public class ScheduleC
    {
        public int findDay(string day)
        {
            if (day == "א") return 5;
            if (day == "ב") return 4;
            if (day == "ג") return 3;
            if (day == "ד") return 2;
            if (day == "ה") return 1;
            if (day == "ו") return 0;
            return -1;
        }
        public int findTime(string time)
        {
            if (time == "08:00:00") return 1;
            if (time == "09:00:00") return 2;
            if (time == "10:00:00") return 3;
            if (time == "11:00:00") return 4;
            if (time == "12:00:00") return 5;
            if (time == "13:00:00") return 6;
            if (time == "14:00:00") return 7;
            if (time == "15:00:00") return 8;
            if (time == "16:00:00") return 9;
            if (time == "17:00:00") return 10;
            if (time == "18:00:00") return 11;
            if (time == "19:00:00") return 12;
            if (time == "20:00:00") return 13;
            if (time == "21:00:00") return 14;
            return -1;
        }
        public void fillCourseInSch(string choice, Label label, int day, int s, int e, TableLayoutPanel Schdule)
        {
            label.AutoSize = true;
           // int size = (s - 1) + (e - s);
            for (int i = s; i < e; i++)
            {
                if (Schdule.GetControlFromPosition(day, i) != null)
                {
                    Schdule.Controls.Remove(Schdule.GetControlFromPosition(day, i));
                }
                if (choice == "new")
                {
                    Panel color = new Panel();
                    color.BackColor = Color.LightBlue;
                    Schdule.Controls.Add(color, day, i);
                    if (i == s)
                    {
                        label.BackColor = Color.LightBlue;
                        color.Controls.Add(label);
                    }
                }
                else
                {
                    label.ForeColor = Color.Ivory;
                    Panel color = new Panel();
                    color.BackColor = Color.Gray;
                    Schdule.Controls.Add(color, day, i);
                    if (i == s)
                    {
                        label.BackColor = Color.Gray;
                        color.Controls.Add(label);
                    }
                }
            }
        }
        public void realtimeUpdateSch(TableLayoutPanel Schdule, PersonS user)
        {
            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            DataTable dc = new DataTable();
            int day, s, e;
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label label = new Label();
                dl = DatabaseManager.Connect("select * from dbo.Lesson where lessonId='" + dt.Rows[i]["lessonId"] + "'");
                dc = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");
                label.Text = (string)dc.Rows[0]["courseName"];
                day = findDay(dl.Rows[0]["weekDay"].ToString());
                s = findTime(dl.Rows[0]["startTime"].ToString());
                e = findTime(dl.Rows[0]["endTime"].ToString());
                if (day == -1 || s == -1 || e == -1)
                {
                    MessageBox.Show("יראה שגיאת מערכת הנתונים");
                    Application.Exit();
                }
                else fillCourseInSch("", label, day, s, e, Schdule);
            }
        }
        public int checkNumCredit(PersonS user)
        {
            int numCredit = 0;
            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dl = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");
                numCredit += (int)dl.Rows[0]["credits"];
            }
            return numCredit;
        }
        public bool checkPreCourse(PersonS user, CourseS course)
        {
            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + course.BlockerCourseId + "'");
            if (dt.Rows.Count != 0)
            {
                dl = DatabaseManager.Connect("select * from dbo.CourseReg where courseId='" + dt.Rows[0]["courseId"] + "and personId='" + user.ID + "'");
                if (dl.Rows.Count != 0 && (bool)dl.Rows[0]["passGrade"] != true)
                {
                    return false;
                }
            }
            return true;
        }
        public int checkNumOfStudents(CourseS course)
        {
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where courseId='" + course.CourseId + "'");
            return (dt.Rows.Count + 1);
        }
        public bool checkStdRegCourse(PersonS user, CourseS course)
        {
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'and  courseId='" + course.CourseId + "'");
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            MessageBox.Show("!!פעולה לא חוקית את/ה רשומים לקורס זה");
            return false;
        }
        public bool checkDupLesson(PersonS user, LessonS lesson)
        {
            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dl = DatabaseManager.Connect("select * from dbo.Lesson where lessonId='" + dt.Rows[i]["lessonId"] + "'");
                if ((lesson.WeekDay == (string)dl.Rows[0][6]))
                {
                    if(lesson.Start>= (TimeSpan)dl.Rows[0][1]&& lesson.Start <= (TimeSpan)dl.Rows[0][2])
                    {
                        if(lesson.End >= (TimeSpan)dl.Rows[0][1] && lesson.End <= (TimeSpan)dl.Rows[0][2])
                        {
                            MessageBox.Show("!!פעולה לא חוקית חפיפה בין שעות");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public void regCourseToData(PersonS std,LessonS lesson)/*reg course to data base*/
        {
            SQLQuery query = new SQLQuery("dbo.CourseReg", "insert");
            query.AddToQuery("personId", std.ID);
            query.AddToQuery("courseId", lesson.CourseId);
            query.AddToQuery("passGrade", true);
            query.AddToQuery("lessonId", lesson.LessonId);
            DatabaseManager.ADURecord(query);
            MessageBox.Show("נרשמת לקורס בהצלחה");
        }
        public void upCourseToData(PersonS std, LessonS lesson,int regId)/*up course to data base*/
        {
            SQLQuery query = new SQLQuery("dbo.CourseReg", "update", "regId", regId.ToString());
            query.AddToQuery("lessonId", lesson.LessonId);
            DatabaseManager.ADURecord(query);
            MessageBox.Show("עודכן קורס בהצלחה");
        }
    }
}
