﻿using System;
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
    public partial class scheduleChangeStudent : Form
    {
        PersonS user;
        public scheduleChangeStudent(Person user)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.Person where personID ='" + textBox1.Text + "'");
            if (dt.Rows.Count == 0) MessageBox.Show("!!תעודת זהות שגויה נסה שוב");
            else
            {
                this.user = new PersonS(dt.Rows[0]);
                ScheduleBuild next = new ScheduleBuild(user);
                next.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.Person where personID ='" + textBox1.Text + "'");
            if (dt.Rows.Count == 0) MessageBox.Show("!!תעודת זהות שגויה נסה שוב");
            else
            {
                this.user = new PersonS(dt.Rows[0]);
                Schedule next = new Schedule(user);
                next.Show();
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
