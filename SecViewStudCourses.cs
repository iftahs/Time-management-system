/*
 *מזכירה מכניסה תעודת זהות ורואה את כל הקורסים שהסטודנט רשום אליהם
 * לא גמור.
 * צריך להוסיף קורסים לסטודנט. 
 */
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
    public partial class SecViewStudCourses : Form
    {
        private DataTable dt;
        private DataTable st;
        Person user;
        private int[] courseId = new int[6];
        public SecViewStudCourses(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            st = new DataTable();

            dt = DatabaseManager.Connect("select * from dbo.Person where personID ='" + textBox1.Text + "'");

            if (textBox1.Text.Length != 9)
                MessageBox.Show("ID length is wrong");
            else if(dt.Rows.Count==0)
                MessageBox.Show("Student wasn't found");
                else
            {

                int year = (int)dt.Rows[0]["year"];
                int semester = (int)dt.Rows[0]["semester"];

                st = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + year + "' and semester='" + semester + "'");


                if (st.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
                else
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < st.Rows.Count; i++)
                    {
                        listBox1.Items.Add(st.Rows[i]["courseName"]);
                    }
                }


            }
            DatabaseManager.CloseConnection();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
