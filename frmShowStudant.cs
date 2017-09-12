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
    public partial class frmShowStudant : Form
    {
        private string sqlPerson;
        private string sqlCourseReg;
        private string sqlCourseBySyllbus;

        public frmShowStudant()
        {
            InitializeComponent();
            sqlPerson = "SELECT * FROM dbo.Person";
            sqlCourseReg = "SELECT * FROM dbo.CourseReg where passgrade = 'false'";
            sqlCourseBySyllbus = "SELECT * FROM dbo.CourseBySyllabus";
            /*
             * coursebysyllabus- courseid int and get coursename
             * courseReg- personid[1] and courseid[2] and passgrade(boolean)
             * person- get personid[0] and return firstname[1] and lastname[2]
             * */
        }
        private void fillList()
        {
          
            DataTable dtCourseReg = DatabaseManager.Connect(sqlCourseReg);
       

            int count = dtCourseReg.Rows.Count;
            RegStudent[] rg = new RegStudent[count];
            for(int i = 0; i < count; i++)
            {
                rg[i] = new RegStudent(dtCourseReg.Rows[i]);
            }
            for (int i = 0; i < count; i++)
            {
                DataTable dtPerson = DatabaseManager.Connect("SELECT * FROM dbo.Person where personid ='"+rg[i].Studentid+"'");
                DataRow dr = dtPerson.Rows[0];
                rg[i].NameOfStudent = dr[0].ToString();
                DataTable dtCourseBySyllbus = DatabaseManager.Connect("SELECT * FROM dbo.CourseBySyllabus where courseid ='"+rg[i].Courseid+"'");
                dr = dtCourseBySyllbus.Rows[0];
                rg[i].NameOfCourse = dr[0].ToString();
                //להשלים כאן את הכתיבה לרכיב הגרפי כמו בSHOWPERSONS
            }

        }



        private void frmShowStudant_Load(object sender, EventArgs e)
        {

        }
    }
}
