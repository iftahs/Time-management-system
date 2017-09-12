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
    public partial class MeSchBuild : Form
    {
        ScheduleC Sc = new ScheduleC();
        DataTable dt = new DataTable();
        public MeSchBuild()
        {
            InitializeComponent();
            dt = DatabaseManager.Connect("select * from dbo.Person where logistic='" + true + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1]+" "+dt.Rows[i][2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int day, time;
            String name;
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null) MessageBox.Show("לא נבחרה אחת מהאפשרויות נסה שוב");
            else
            {
                day = Sc.findDay(comboBox2.SelectedItem.ToString());
                time = Sc.findTime(comboBox3.SelectedItem.ToString())-1;
                name = comboBox1.SelectedItem.ToString();
                Label label = new Label();
                label.Text = name;
                if (day == 5) Sc.fillCourseInSch("", label, 1, time, time+1, a1);
                if (day == 4) Sc.fillCourseInSch("", label, 1, time, time+1, a2);
                if (day == 3) Sc.fillCourseInSch("", label, 1, time, time+1, a3);
                if (day == 2) Sc.fillCourseInSch("", label, 1, time, time+1, a4);
                if (day == 1) Sc.fillCourseInSch("", label, 1, time, time+1, a5);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 14; i++)
            {
                int num = rnd.Next(0, dt.Rows.Count);
                if (checkBox1.Checked == true)
                {
                    Label label = new Label();
                    label.Text = (String)dt.Rows[num][1] + " " + (String)dt.Rows[num][2];
                    Sc.fillCourseInSch("", label, 1, i, i + 1, a1);
                }
                if (checkBox2.Checked == true)
                {
                    Label label = new Label();
                    label.Text = (String)dt.Rows[num][1] + " " + (String)dt.Rows[num][2];
                    Sc.fillCourseInSch("", label, 1, i, i + 1, a2);
                }
                if (checkBox3.Checked == true)
                {
                    Label label = new Label();
                    label.Text = (String)dt.Rows[num][1] + " " + (String)dt.Rows[num][2];
                    Sc.fillCourseInSch("", label, 1, i, i + 1, a3);
                }
                if (checkBox4.Checked == true)
                {
                    Label label = new Label();
                    label.Text = (String)dt.Rows[num][1] + " " + (String)dt.Rows[num][2];
                    Sc.fillCourseInSch("", label, 1, i, i + 1, a4);
                }
                if (checkBox5.Checked == true)
                {
                    Label label = new Label();
                    label.Text = (String)dt.Rows[num][1] + " " + (String)dt.Rows[num][2];
                    Sc.fillCourseInSch("", label, 1, i, i + 1, a5);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("נשלח להדפסה");
        }

        private void a1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
