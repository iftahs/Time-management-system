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
    public partial class StuViewCourses : Form
    {
        Person user;
        ScheduleC Sc = new ScheduleC();
        private DataTable dt, dl, dx;
        private int[] courseId = new int[6];
        public StuViewCourses(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();
            dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + user.Year + "' and semester='" + user.Semster + "'");
            DatabaseManager.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStudent back = new MainStudent(user);
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numCredit = 0;
            listBox1.Items.Clear();
            textBox1.Clear();
            List<Course> LCourse = new List<Course>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LCourse.Add(new Course(dt.Rows[i]));
            }
            if (comboBox1.Text == "שם")
            {
                LCourse.Sort((a, b) => a.CourseName.CompareTo(b.CourseName));

                if (dt.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox1.Items.Add(LCourse[i].CourseName);
                    numCredit += LCourse[i].Credits;

                }
            }

            if (comboBox1.Text == "דירוג מרצים")
            {


            }

            if (comboBox1.Text == "נקודות זכות")
            {

                if (dt.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
                LCourse.Sort((b, a) => a.Credits.CompareTo(b.Credits));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox1.Items.Add(LCourse[i].CourseName);
                    numCredit += LCourse[i].Credits;
                }
            }
            textBox1.Text += numCredit*250;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public float avgRating(int lecID)
        {
            int avg = 0;
            dl = new DataTable();
            dl = DatabaseManager.Connect("select * from dbo.Rating where lectureId='" + lecID + "'");
            for (int i = 0; i < dl.Rows.Count; i++)
                avg += (int)dl.Rows[i]["numOfRating"];
            return avg / (dl.Rows.Count + 1);

        }
    }
}
