using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Classes;
using Bs_Pro14.Utilities;

namespace Bs_Pro14
{
    public partial class frmShowFailStudent : Form
    {
        private string sqlCourseReg;
        public frmShowFailStudent()
        {
            InitializeComponent();
            sqlCourseReg = "SELECT * FROM dbo.CourseReg where passgrade = 'false'";
        }
        private void fillList()
        {

            DataTable dtCourseReg = DatabaseManager.Connect(sqlCourseReg);


            int count = dtCourseReg.Rows.Count;
            RegStudent[] rg = new RegStudent[count];
            for (int i = 0; i < count; i++)
            {
                rg[i] = new RegStudent(dtCourseReg.Rows[i]);
            }
            for (int i = 0; i < count; i++)
            {
                
                DataTable dtPerson = DatabaseManager.Connect("SELECT * FROM dbo.Person where personid ='" + rg[i].Studentid + "'");
                DataRow dr = dtPerson.Rows[0];
                rg[i].NameOfStudent = dr[0].ToString();
                DataTable dtCourseBySyllbus = DatabaseManager.Connect("SELECT * FROM dbo.CourseBySyllabus where courseid ='" + rg[i].Courseid + "'");
                dr = dtCourseBySyllbus.Rows[0];
                rg[i].NameOfCourse = dr[0].ToString();
                dgvShowFailStudent.Rows[i].Cells[0].Value = rg[i].NameOfCourse;
                dgvShowFailStudent.Rows[i].Cells[1].Value = rg[i].NameOfStudent;
                dgvShowFailStudent.Rows[i].Cells[2].Value = rg[i].Studentid;
                dgvShowFailStudent.Rows[i].Cells[3].Value = "אשר";
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult d = MessageBox.Show("האם ברצונך לאשר?", "Delete user", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                MessageBox.Show("התלמיד אושר להמשך לימודים!");
            }
        }

        private void frmShowFailStudent_Load(object sender, EventArgs e)
        {
            dgvShowFailStudent.Width = this.Width;
            fillList();
        }
    }
}
