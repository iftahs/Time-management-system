using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bs_Pro14.Utilities;
using Bs_Pro14.Persons;

namespace Bs_Pro14
{
    public partial class Form1 : Form
    {
        private Person person = new Person("034750984", "Iftah", "Saar");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            person.Head = true;
            person.Lecturer = true;
            person.Logistic = true;
            person.Secretary = true;
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            timer1.Start();
            foreach (TabPage tp in tabControl.TabPages)
                tabControl.TabPages.Remove(tp);
            lblName.Text = "משתמש: " + person.FirstName + " " + person.LastName;
            if (person.Student == true) tabControl.TabPages.Add(tabStudent);
            if (person.Head == true) tabControl.TabPages.Add(tabHead);
            if (person.Secretary == true) tabControl.TabPages.Add(tabSecretary);
            if (person.Logistic == true) tabControl.TabPages.Add(tabLogistic);
            if (person.Lecturer == true) tabControl.TabPages.Add(tabLecturer);
            משתמשToolStripMenuItem.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }       

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void התנתקToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.person = null;
            tabControl.TabPages.Remove(tabLecturer);
            tabControl.TabPages.Remove(tabHead);
            tabControl.TabPages.Remove(tabSecretary);
            tabControl.TabPages.Remove(tabStudent);
            tabControl.TabPages.Remove(tabLogistic);
            lblName.Text = "";
            משתמשToolStripMenuItem.Visible = false;
            this.Hide();
            Form2 form2 = new Bs_Pro14.Form2();
            form2.Show();
        }

        private void tabSecretary_Click(object sender, EventArgs e)
        {

        }

        private void btnSecretary_ManagerCoursesBySemester_Click(object sender, EventArgs e)
        {
            pnlSecretryMain.Visible = false;
            pnlSecretary_ManageCoursesBySemester.Location = new Point(pnlSecretryMain.Location.X, pnlSecretryMain.Location.Y);
            pnlSecretary_ManageCoursesBySemester.Visible = true;
        }

        private void btnSecretary_ManagerCoursesBySemester_Back_Click(object sender, EventArgs e)
        {
            pnlSecretary_ManageCoursesBySemester.Visible = false;
            pnlSecretryMain.Visible = true;
        }
    }
}
