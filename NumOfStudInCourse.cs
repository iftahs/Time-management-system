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

namespace Bs_Pro14
{
    public partial class NumOfStudInCourse : Form
    {
        private DataTable dt; //CoursesBySyllabus
        private DataTable st = new DataTable(); //Lesson
        
        private DataTable at; //CourseReg

        public NumOfStudInCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();
            at = DatabaseManager.Connect("select * from dbo.CourseReg where courseId='" + dt.Rows[0]["courseId"]+"'");
            if (comboBox3.Text == "") MessageBox.Show("אנא בחר קורס");
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < st.Rows.Count; j++)
                    {
                        at = DatabaseManager.Connect("select * from dbo.CourseReg where courseId='" + dt.Rows[i]["courseId"] + "'");
                        if (string.Equals(comboBox3.SelectedItem, dt.Rows[i]["courseName"] + ": " + st.Rows[j]["startTime"] + "-" + st.Rows[j]["endTime"] + " " + st.Rows[j]["weekDay"]))// בעיה. לא ניצן להשוות בין הטקסט בוקס לDT.ROWS
                        {
                            listBox1.Items.Add("Course: " + dt.Rows[i]["courseName"] + "     Course ID: " + dt.Rows[i]["courseId"]);
                            for (int m = 0; m < at.Rows.Count; m++)
                            {
                                listBox1.Items.Add(at.Rows[m]["regId"] + "\tID: " + at.Rows[m]["personId"]);
                                count++;
                            }
                                
                        }
                    }

                    textBox1.Text = count.ToString();
                }
            }
            DatabaseManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int dep = 0, year = 0;
            listBox1.Items.Clear();
            comboBox3.Items.Clear();

            if (comboBox1.Text == "" || comboBox2.Text == "") MessageBox.Show("אפשרות לא נבחרה");
            else
            {
                if (comboBox1.Text == "תוכנה") dep = 1;
                if (comboBox1.Text == "בניין") dep = 2;
                if (comboBox1.Text == "תעשייה וניהול") dep = 3;

                if (comboBox2.Text == "א'") year = 1;
                if (comboBox2.Text == "ב'") year = 2;
                if (comboBox2.Text == "ג'") year = 3;
                if (comboBox2.Text == "ד'") year = 4;


                dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + year + "' and departmentId='" + dep + "'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st = DatabaseManager.Connect("select * from dbo.Lesson where courseId = '" + dt.Rows[i]["courseId"] + "'");
                    for (int j = 0; j < st.Rows.Count; j++)
                    {
                        comboBox3.Items.Add(dt.Rows[i]["courseName"] + ": " + st.Rows[j]["startTime"] + "-" + st.Rows[j]["endTime"] + " " + st.Rows[j]["weekDay"]);       
                    }
                }

            }
        }
    }
}
