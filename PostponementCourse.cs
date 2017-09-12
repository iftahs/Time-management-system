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
    public partial class PostponementCourse : Form
    {
        private DataTable dt;
        private DataTable st;
        public PostponementCourse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PostponementCourse_Load(object sender, EventArgs e)
        {

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
                    }
                }


            }
            DatabaseManager.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
