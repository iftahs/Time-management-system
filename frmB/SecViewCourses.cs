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
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class SecViewCourses : Form
    {
        PersonS user;
        public SecViewCourses(Person user)
        {
            this.user = new PersonS(user);
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dep=0, year=0, sem=0;
            DataTable dt = new DataTable();
            listBox1.Items.Clear();
            if (comboBox1.Text == "") MessageBox.Show("אפשרות לא נבחרה");
            else
            {
                if (comboBox3.Text == "תוכנה") dep =1;
                if (comboBox3.Text == "בניין") dep = 2;
                if (comboBox3.Text == "תעשייה וניהול") dep = 3;

                if (comboBox1.Text == "שנה א") year = 1;
                if (comboBox1.Text == "שנה ב") year = 2;
                if (comboBox1.Text == "שנה ג") year = 3;
                if (comboBox1.Text == "שנה ד") year = 4;

                if (comboBox2.Text == "סמסטר א") sem = 1;
                if (comboBox2.Text == "סמסטר ב") sem = 2;
                if (comboBox2.Text == "סמסטר קיץ") sem = 3;
                if (comboBox2.Text == "הכל")
                {
                    dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + year+"' and departmentId='"+ dep +"'");
                    if (dt.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listBox1.Items.Add(dt.Rows[i]["courseName"]);
                    }
                }

                else
                {
                    dt = DatabaseManager.Connect("select * from dbo.CourseBySyllabus where year='" + year + "' and semester='"+sem+"'and departmentId='" + dep + "'");
                    if (dt.Rows.Count == 0) listBox1.Items.Add("רשימה ריקה");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listBox1.Items.Add(dt.Rows[i]["courseName"]);
                    }
                }
            }
        }       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
