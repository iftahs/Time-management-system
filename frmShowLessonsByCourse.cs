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
    public partial class frmShowLessonsByCourse : Form
    {
        private int courseId;
        private CourseBySyllabus course;
        private Lesson[] lessons;
        public frmShowLessonsByCourse(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
            course = CourseBySyllabus.getCourseById(courseId);
            lessons = Lesson.getLessonsByCourseId(courseId);
        }

        private void frmShowLessonsByCourse_Load(object sender, EventArgs e)
        {
            this.Text = "הצגת שיעורים לקורס " + course.CourseName;
            lblCourseName.Text = course.CourseName;
            fillData();
        }

        private void fillData()
        {
            dgvLessons.Rows.Clear();
            int i = 0;
            
            if (lessons != null)
            { 
                foreach(Lesson l in lessons)
                {
                    Person lecturer = Person.getPersonById(l.LecturerId);
                    dgvLessons.Rows.Add();
                    dgvLessons.Rows[i].Cells[0].Value = "מחיקה";
                    dgvLessons.Rows[i].Cells[1].Value = l.LessonId;
                    dgvLessons.Rows[i].Cells[2].Value = l.WeekDay;
                    dgvLessons.Rows[i].Cells[3].Value = l.StartTime;
                    dgvLessons.Rows[i].Cells[4].Value = l.EndTime;
                    dgvLessons.Rows[i].Cells[5].Value = lecturer.FirstName + " " + lecturer.LastName;
                    dgvLessons.Rows[i].Cells[6].Value = ClassRoom.getClassRoomName(l.ClassId);
                    i++;
                }
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            frmAddLesson frm = new frmAddLesson(courseId);
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lessons = Lesson.getLessonsByCourseId(courseId);
            fillData();
        }

        private void dgvLessons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = int.Parse(dgvLessons.Rows[e.RowIndex].Cells["clmID"].Value.ToString());
                if (e.ColumnIndex == 0)
                {
                    deleteLesson(id);
                }
            }
        }

        private void deleteLesson(int id)
        {

            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק שיעור זה", "Delete Lesson", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                Lesson.RemoveFromDataBase(id);
                MessageBox.Show("השיעור נמחק בהצלחה", "Delete lesson");
                foreach (DataGridViewRow row in dgvLessons.Rows)
                {
                    if (row.Cells["clmID"].Value.ToString() == id.ToString())
                    {
                        dgvLessons.Rows.Remove(row);
                    }
                }
            }

            
        }
    }
}
