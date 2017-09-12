using Bs_Pro14.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bs_Pro14
{
    public partial class frmShowLessonSemester : Form
    {
        private LessonInSemester[] lesson;
        private int semesterid;
        private string id;

        public int Semesterid
        {
            get
            {
                return semesterid;
            }

            set
            {
                semesterid = value;
            }
        }

        public frmShowLessonSemester(string Nid)
        {
            InitializeComponent();
            Semester.fillSemesters(ref cmbSemester);
            this.id = Nid;

        }
        public void fill()
        {
            Lesson[] l = Lesson.getLessonById(id);//brings all lessons according to the id of a particular lecturer
            CourseBySyllabus[] s = CourseBySyllabus.getCourseByYearASemid(this.semesterid);//brings all couers according  particular year and particular semester
            List<LessonInSemester> les = new List<LessonInSemester>();
            if (s != null && l != null)
            {
                for (int i = 0; i < l.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (l[i].CourseId == s[j].CourseId && s[j].Semesterid == this.semesterid)//chack the match between lectuer,lesson and semester id
                        {
                            les.Add(new LessonInSemester(s[j].CourseName, l[i].WeekDay, l[i].StartTime, l[i].EndTime));
                        }
                    }
                }
                if (les.Count == 0)
                {
                    MessageBox.Show("אינך מלמד בזמן זה");
                }
                else
                {
                    lesson = new LessonInSemester[les.Count];
                    les.CopyTo(lesson);//convert the List to LessonInSemester value
                    for (int n = 0; n < lesson.Length; n++)//print the data into dataGridView
                    {
                        DataGridViewRow dgvr = new DataGridViewRow();
                        dgvShowLesson.Rows.Add();
                        dgvShowLesson.Rows[n].Cells[0].Value = lesson[n].Day;
                        dgvShowLesson.Rows[n].Cells[1].Value = lesson[n].Name;
                        dgvShowLesson.Rows[n].Cells[2].Value = lesson[n].Start;
                        dgvShowLesson.Rows[n].Cells[3].Value = lesson[n].End;
                    }
                }
            }
            else
            {
                MessageBox.Show("אינך מלמד בזמן זה");
            }
        }//end fill
        public void RefreshList()
        {
            dgvShowLesson.Rows.Clear();
            dgvShowLesson.Width = this.pnlShowDateTime.Width;
            dgvShowLesson.Height = this.pnlShowDateTime.Height;
            dgvShowLesson.Refresh();
            fill();
        }

        private void ShowDataTime_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmShowLessonSemester_Load(object sender, EventArgs e)
        {
            dgvShowLesson.Width = this.Width;
            pnlShowDateTime.Width = this.Width;
        }
    }
}

