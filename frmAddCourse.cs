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
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class frmAddCourse : Form
    {
        private int id;
        private bool edit = false;
        private CourseBySyllabus c;
        public frmAddCourse()
        {
            InitializeComponent();
            fillComboBoxes();
            c = new CourseBySyllabus();
        }

        public frmAddCourse(int id) : this()
        {
            btnAddClassroom.Text = "עדכן";
            btnCleanAddClassroom.Enabled = false;
            this.id = id;
            edit = true;
            c = CourseBySyllabus.getCourseById(id);
            fillDetails();
        }

        public void fillDetails()
        {
            txtCourseName.Text = c.CourseName;
            cmbCredits.SelectedIndex = cmbCredits.FindStringExact(c.Credits.ToString());
            cmbYear.SelectedIndex = cmbYear.FindStringExact(c.Year.ToString());
            cmbSemester.SelectedIndex = cmbSemester.FindStringExact(c.Semester);
            cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact(Department.getDepartmentName(c.DepartmentId));
            if (c.BlockerCourseId != 0)
                cmbBlockCourse.SelectedIndex = cmbBlockCourse.FindStringExact(CourseBySyllabus.getCourseName(c.BlockerCourseId));
            cmbMaxStudents.SelectedIndex = cmbMaxStudents.FindStringExact(c.MaxStudent.ToString());
            cmbSemesterId.SelectedIndex = cmbSemesterId.FindStringExact(Semester.getSemesterName(c.Semesterid));
            cbPractice.Checked = c.Practice;
        }

        private void fillComboBoxes()
        {
            //fill credits.
            for (int i = 0; i <= 6; i++)
                cmbCredits.Items.Add(i);

            //fill years.
            for (int i = 0; i <= 4; i++)
                cmbYear.Items.Add(i);

            //fill semesters
            for (int i = 0; i <= 3; i++)
                cmbSemester.Items.Add(i);

            //fill semeters by dates
            Semester.fillSemesters(ref cmbSemesterId);

            //fill max students
            for (int i = 10; i <= 200; i++)
                cmbMaxStudents.Items.Add(i);

            //fill departments
            Department[] departments = Department.getDepartmentsList();
            foreach (Department d in departments)
            {
                if (d.DepartmentId == Program.person.DepartmentId || d.General == true) { 
                    Item i = new Item(d.DepartmentName, d.DepartmentId);
                    cmbDepartment.Items.Add(i);
                    if (d.DepartmentId == Program.person.DepartmentId)
                        cmbDepartment.SelectedItem = cmbDepartment.Items[cmbDepartment.Items.Count - 1];
                }
            }

            //fill block courses
            CourseBySyllabus[] c = CourseBySyllabus.getCoursesList();
            if (c != null) { 
                foreach(CourseBySyllabus course in c)
                {
                    Item i = new Item(course.CourseName, course.CourseId);
                    cmbBlockCourse.Items.Add(i);
                }
            }
        }

        private void cmbCredits_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbBlockCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMaxStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSemesterId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancelAddClassroom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCleanAddClassroom_Click(object sender, EventArgs e)
        {
            txtCourseName.Text = "";
            cmbCredits.Text = "בחר";
            cmbYear.Text = "בחר";
            cmbSemester.Text = "בחר";
            cmbDepartment.Text = "בחר";
            cmbBlockCourse.Text = "בחר";
            cmbMaxStudents.Text = "בחר";
            cmbSemesterId.Text = "בחר";
        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                c.CourseName = txtCourseName.Text;
                c.Credits = int.Parse(cmbCredits.Text);
                c.Year = int.Parse(cmbYear.Text);
                c.Semester = cmbSemester.Text;
                c.DepartmentId = ((Item)cmbDepartment.SelectedItem).Value;
                if (cmbBlockCourse.Text == "בחר")
                    c.BlockerCourseId = 0;
                else
                    c.BlockerCourseId = ((Item)cmbBlockCourse.SelectedItem).Value;
                c.MaxStudent = int.Parse(cmbMaxStudents.Text);
                c.Semesterid = ((Item)cmbSemesterId.SelectedItem).Value;
                c.Practice = cbPractice.Checked;

                bool success = true;
                try
                {
                    if (edit == true)
                        CourseBySyllabus.UpdateInDataBase(c, c.CourseId);
                    else
                        CourseBySyllabus.AddToDatabase(c);
                }
                catch (Exception ex)
                {
                    Validations.ShowError(ex.Message);
                    success = false;
                }

                if (success == true)
                {
                    if (edit == true)
                        MessageBox.Show("הקורס עודכן בהצלחה", "Success");
                    else
                        MessageBox.Show("הקורס נוסף בהצלחה", "Success");
                    this.Close();
                }
            }
        }

        private bool checkValidation()
        {
            bool valid = true;

            //Check course name
            if (string.IsNullOrEmpty(txtCourseName.Text))
            {
                errorProvider1.SetError(txtCourseName, "חובה למלא שם הקורס");
                valid = false;
            }
            else
                errorProvider1.SetError(txtCourseName, null);

            //Check credits
            if (cmbCredits.Text == "בחר")
            {
                errorProvider1.SetError(cmbCredits, "יש לבחור נקודות זכות");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbCredits, null);

            //Check year
            if (cmbYear.Text == "בחר")
            {
                errorProvider1.SetError(cmbYear, "יש לבחור שנה");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbYear, null);

            //Check semester
            if (cmbSemester.Text == "בחר")
            {
                errorProvider1.SetError(cmbSemester, "יש לבחור סמסטר");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbSemester, null);

            //Check department
            if (cmbDepartment.Text == "בחר")
            {
                errorProvider1.SetError(cmbDepartment, "יש לבחור מחלקה");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbDepartment, null);

            //Check max Students
            if (cmbMaxStudents.Text == "בחר")
            {
                errorProvider1.SetError(cmbMaxStudents, "יש לבחור מקסימום סטודנטים");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbMaxStudents, null);

            //Check semester ID
            if (cmbSemesterId.Text == "בחר")
            {
                errorProvider1.SetError(cmbSemesterId, "יש לבחור סמסטר");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbSemesterId, null);

            return valid;
        }

        private void cbPractice_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCourseName.Text))
            {
                string name = txtCourseName.Text;
                if (cbPractice.Checked == true)
                {
                    if (!name.Contains(" T"))
                        name += " T";
                    txtCourseName.ReadOnly = true;
                }
                else
                {
                    if (name.Contains(" T"))
                        name = name.Substring(0, name.Length - 2);
                    txtCourseName.ReadOnly = false;
                }
                txtCourseName.Text = name;
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "")
            {
                cbPractice.Checked = false;
                cbPractice.Enabled = false;
            }
            else
                cbPractice.Enabled = true;
        }
    }
}
