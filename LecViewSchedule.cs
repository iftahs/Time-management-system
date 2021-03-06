﻿using System;
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
    public partial class LecViewSchedule : Form
    {
        Person user;
        ScheduleC Sc = new ScheduleC();
        public LecViewSchedule(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();

            DataTable dt = new DataTable();
            DataTable dl = new DataTable();
            DataTable dc = new DataTable();
            int s, e, day;
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dl = DatabaseManager.Connect("select * from dbo.Lesson where lessonId='" + dt.Rows[i]["lessonId"] + "'");
                dc = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + dt.Rows[i]["courseId"] + "'");

                Label label = new Label();
                label.Text = (string)dc.Rows[0]["courseName"];
                day = Sc.findDay(dl.Rows[0]["weekDay"].ToString());
                s = (Sc.findTime(dl.Rows[0]["startTime"].ToString()) - 1);
                e = (Sc.findTime(dl.Rows[0]["endTime"].ToString()) - 1);

                if (day == 5) Sc.fillCourseInSch("", label, 1, s, e, a1);
                if (day == 4) Sc.fillCourseInSch("", label, 1, s, e, a2);
                if (day == 3) Sc.fillCourseInSch("", label, 1, s, e, a3);
                if (day == 2) Sc.fillCourseInSch("", label, 1, s, e, a4);
                if (day == 1) Sc.fillCourseInSch("", label, 1, s, e, a5);
                if (day == 0) Sc.fillCourseInSch("", label, 1, s, e, a6);
            }

            DatabaseManager.CloseConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
