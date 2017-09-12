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
    public partial class frmShowCourses : Form
    {
        private CourseBySyllabus[] courses;
        int departmentId, semesterId;
        private Lesson[] lessons;
        private List<int> coursesWithLessons;

        public frmShowCourses()
        {
            InitializeComponent();
            courses = CourseBySyllabus.getCoursesList();
            lessons = Lesson.getAllLessons();
            coursesWithLessons = new List<int>();

            foreach (Lesson lesson in lessons)
            {
                if (!coursesWithLessons.Contains(lesson.CourseId))
                    coursesWithLessons.Add(lesson.CourseId);
            }
        }

        private void frmShowCoursesSecretary_Load(object sender, EventArgs e)
        {
            Semester.fillSemesters(ref cmbSemester);
            fillDepartments();
            departmentId = ((Item)cmbDepartment.SelectedItem).Value;
            semesterId = ((Item)cmbSemester.SelectedItem).Value;
            fillData();
            dgvCourses.Width = this.Width;
        }

        private void fillData()
        {
            dgvCourses.Rows.Clear();
            int i = 0;

            foreach(CourseBySyllabus c in courses)
            {
                if (c.DepartmentId == departmentId && c.Semesterid == semesterId)
                { 
                    dgvCourses.Rows.Add();
                    dgvCourses.Rows[i].Cells[0].Value = "מחיקה";
                    dgvCourses.Rows[i].Cells[1].Value = "עריכה";
                    dgvCourses.Rows[i].Cells[2].Value = "הצג";
                    if (coursesWithLessons.Contains(c.CourseId))
                        dgvCourses.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvCourses.Rows[i].Cells[3].Value = c.CourseId;
                    dgvCourses.Rows[i].Cells[4].Value = c.CourseName;
                    dgvCourses.Rows[i].Cells[5].Value = c.Credits;
                    dgvCourses.Rows[i].Cells[6].Value = c.Year;
                    dgvCourses.Rows[i].Cells[7].Value = c.Semester;
                    dgvCourses.Rows[i].Cells[8].Value = c.MaxStudent;
                    i++;
                }
            }
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            departmentId = ((Item)cmbDepartment.SelectedItem).Value;
            semesterId = ((Item)cmbSemester.SelectedItem).Value;
            fillData();
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = int.Parse(dgvCourses.Rows[e.RowIndex].Cells["clmID"].Value.ToString());
                if (e.ColumnIndex == 0)
                {
                    deleteCourse(id);
                }
                else if (e.ColumnIndex == 1)
                {
                    frmAddCourse frm = new frmAddCourse(id);
                    frm.Show();
                    frm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                }
                else if (e.ColumnIndex == 2)
                {
                    frmShowLessonsByCourse frm = new frmShowLessonsByCourse(id);
                    frm.Show();
                    frm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                }
            }
        }

        private void deleteCourse(int id)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הקורס", "Delete Course", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                Lesson.removeFromDataBaseByCourseId(id);
                CourseBySyllabus.RemoveFromDataBase(id);
                MessageBox.Show("הקורס נמחק בהצלחה", "Delete user");
                foreach (DataGridViewRow row in dgvCourses.Rows)
                {
                    if (row.Cells["clmID"].Value.ToString() == id.ToString())
                    {
                        dgvCourses.Rows.Remove(row);
                    }
                }
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            courses = CourseBySyllabus.getCoursesList();
            departmentId = ((Item)cmbDepartment.SelectedItem).Value;
            semesterId = ((Item)cmbSemester.SelectedItem).Value;
            fillData();
        }

        private void fillDepartments()
        {
            Department[] departments = Department.getDepartmentsList();
            foreach (Department d in departments)
            {
                if (d.DepartmentId == Program.person.DepartmentId || d.General == true)
                {
                    Item i = new Item(d.DepartmentName, d.DepartmentId);
                    cmbDepartment.Items.Add(i);
                    if (d.DepartmentId == Program.person.DepartmentId)
                        cmbDepartment.SelectedItem = cmbDepartment.Items[cmbDepartment.Items.Count - 1];
                }
            }
        }
    }
}
