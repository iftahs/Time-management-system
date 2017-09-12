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
    public partial class CourseInfo : Form
    {
        private DataTable dt,dl,dx;

        public CourseInfo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                    comboBox3.Items.Add(dt.Rows[i]["courseName"]);

                }

            }
            DatabaseManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int blocker = 0;
            listBox1.Items.Clear();
            if (comboBox3.Text == "") MessageBox.Show("אנא בחר קורס");
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (comboBox3.SelectedItem == dt.Rows[i]["courseName"])
                    {
                        listBox1.Items.Add("Course: " + dt.Rows[i]["courseName"] + "     Course ID: " + dt.Rows[i]["courseId"]);
                        listBox1.Items.Add("Year: " + dt.Rows[i]["year"] + "\tSemester: " + dt.Rows[i]["semester"]);
                        listBox1.Items.Add("Credits: " + dt.Rows[i]["credits"]);
                        listBox1.Items.Add("Course Price: " + (int)dt.Rows[i]["credits"] * 250);

                        blocker = (int)dt.Rows[i]["blockerCourseId"];
                        if (blocker != 0)
                        {
                            dl = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where courseId='" + blocker + "'");
                            listBox1.Items.Add("Blocker Course: " + dl.Rows[0]["courseName"]);
                            DatabaseManager.CloseConnection();
                        }
                    }

                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (comboBox3.Text == "") MessageBox.Show("אנא בחר קורס");
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (comboBox3.SelectedItem == dt.Rows[i]["courseName"])
                    {
                       dl= DatabaseManager.Connect("select * from dbo.CourseReg where courseId='" + dt.Rows[i]["courseId"] + "'");
                        for (int j = 0; j < dl.Rows.Count; j++)
                        {
                            dx = DatabaseManager.Connect("select * from dbo.Person where personID='" + dl.Rows[j]["personId"] + "'");
                            listBox2.Items.Add(dx.Rows[0][1]+" "+ dx.Rows[0][2]);
                        }
                    }

                }
            }
        }
    }
}
