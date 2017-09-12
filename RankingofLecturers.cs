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
    public partial class RankingofLecturers : Form
    {
        private DataTable dt, dl, dx;
        Person user;
        List<Person> lec = new List<Person>();

        public RankingofLecturers(Person user)
        {
            this.user = new Person(user);
            InitializeComponent();
            dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.CourseReg where personId='" + user.ID + "'");
            dl = new DataTable();
            dx = new DataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dl = DatabaseManager.Connect("select * from dbo.Lesson where lessonId='" + dt.Rows[i]["lessonId"] + "'");
                dx = DatabaseManager.Connect("select * from dbo.Person where personid='" + dl.Rows[0]["lecturerid"] + "'");
                Person Lec = new Person(dx.Rows[0]);
                if (lec.Count == 0)
                {
                    comboBox1.Items.Add(dx.Rows[0]["firstName"] + " " + dx.Rows[0]["lastName"]);
                    lec.Add(Lec);
                }

                for (int j = 0; j < lec.Count; j++)
                {
                    if (lec[j].ID != Lec.ID)
                    {
                        comboBox1.Items.Add(dx.Rows[0]["firstName"] + " " + dx.Rows[0]["lastName"]);
                        lec.Add(Lec);
                    }
                }
            }

            DatabaseManager.CloseConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dx = new DataTable();
            dx = DatabaseManager.Connect("select * from dbo.Rating where lectureId='" + dl.Rows[0]["lecturerid"] + "' and studentId='" + user.ID + "'");
            if (dx.Rows.Count == 0)
            {
                SQLQuery query = new SQLQuery("dbo.Rating", "insert");
                query.AddToQuery("numOfRating", comboBox2.SelectedItem);
                query.AddToQuery("lectureId", lec[comboBox1.SelectedIndex].ID);
                query.AddToQuery("studentId", user.ID);
                DatabaseManager.ADURecord(query);
            }
            else MessageBox.Show("בוצעה כבר הצבעה עבור מרצה זה. בחר מרצה אחר.");

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStudent back = new MainStudent(user);
            back.Show();
        }

        private void RankingofLecturers_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
