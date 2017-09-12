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
    public partial class frmAddLesson : Form
    {
        private int courseId;
        private CourseBySyllabus course;
        private Person[] lecturers;
        private Lesson[] lessons;
        private Constraints[] constraints;
        private ClassRoom[] classRooms;
        private ClassRequest[] classRequests;

        private Time startTime, endTime;
        int day;

        private List<int> aClassRoomsId;
        private List<string> aLecturersId;

        public frmAddLesson(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;

            course = CourseBySyllabus.getCourseById(courseId);
            lecturers = Person.getPersonsByRoll("lecturer");
            lessons = Lesson.getAllLessons();
            constraints = Constraints.getAllConstraints();
            classRooms = ClassRoom.getAllClassRooms();
            classRequests = ClassRequest.getRequestByApplicant(Program.person.ID);

            aClassRoomsId = new List<int>();
            aLecturersId = new List<string>();

            this.Text = "הוספת שיעור לקורס " + course.CourseName;
            label2.Text = "הוספת שיעור לקורס " + course.CourseName;
        }

        private void fillComboBoxes()
        {
            for (int i = 1; i <= 7; i++)
                cmbDay.Items.Add(i);
            
            for (int i = 8; i <= 22; i++)
            {
                string h;
                if (i < 10)
                    h = "0" + i.ToString();
                else
                    h = i.ToString();
                cmbStartHour.Items.Add(h);
                cmbEndHour.Items.Add(h);
            }

            for (int i = 0; i < 60; i += 15)
            {
                string m;
                if (i < 10)
                    m = "0" + i.ToString();
                else
                    m = i.ToString();
                cmbStartMinute.Items.Add(m);
                cmbEndMinute.Items.Add(m);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Clear the all lists
            aClassRoomsId.Clear();
            aLecturersId.Clear();
            cmbClassRoom.Items.Clear();
            cmbLecturer.Items.Clear();

            //Check if start time < end time.
            if (cmbDay.Text != "בחר" && cmbStartHour.Text != "בחר" && cmbStartMinute.Text != "בחר" && cmbEndHour.Text != "בחר" && cmbEndMinute.Text != "בחר")
            {
                day = int.Parse(cmbDay.Text);
                startTime = new Time(int.Parse(cmbStartHour.Text), int.Parse(cmbStartMinute.Text));
                endTime = new Time(int.Parse(cmbEndHour.Text), int.Parse(cmbEndMinute.Text));
                if (endTime <= startTime)
                {
                    MessageBox.Show("זמן סיום חייב להיות גדול מזמן התחלה", "Invalid time");
                }
                else
                {
                    //Check if there is avaliable lecturers and classrooms.
                    if (getAvaliableLecturers() && getAvaliableClasses())
                    {
                        cmbClassRoom.Enabled = true;
                        cmbLecturer.Enabled = true;
                        cmbDay.Enabled = false;
                        cmbStartHour.Enabled = false;
                        cmbStartMinute.Enabled = false;
                        cmbEndHour.Enabled = false;
                        cmbEndMinute.Enabled = false;
                        btnShow.Visible = false;
                        btnReselect.Visible = true;
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("לא נמצאו מרצים או כיתות פנויים", "Select another time");
                    }
                }
            }
            else
            {
                cmbClassRoom.Enabled = false;
                cmbLecturer.Enabled = false;
            }
        }

        private bool getAvaliableLecturers()
        {
            //Check which lecturer is available by his constraints.
            if (constraints != null)
            { 
                foreach (Constraints con in constraints)
                {
                    if (con.Day == day)
                    {
                        if (Time.containTime(con.StartTime, con.EndTime, startTime, endTime))
                            if (!aLecturersId.Contains(con.LecturerId))
                                aLecturersId.Add(con.LecturerId);
                    }
                }
            }

            //Check if the available lecturer don't teach in this hours.
            if (lessons != null)
            {
                foreach (Lesson les in lessons)
                {
                    if (aLecturersId.Contains(les.LecturerId))
                    {
                        if (les.IntWeekDay == day)
                        {
                            if (Time.coincidentTime(les.StartTime, les.EndTime, startTime, endTime))
                                aLecturersId.Remove(les.LecturerId);
                        }
                    }
                }
            }

            //fill lecturers in combobox
            int count = 0;
            if (lecturers != null)
            {
                foreach (Person lec in lecturers)
                {
                    if (aLecturersId.Contains(lec.ID))
                    {
                        Item i = new Item(lec.FirstName + " " + lec.LastName, int.Parse(lec.ID));
                        cmbLecturer.Items.Add(i);
                        count++;
                    }
                }
            }
            
            if (count > 0)
                return true;
            else
                return false;
        }

        private bool getAvaliableClasses()
        {
            //Check for avaliable classes from class requests that approved.
            if (classRequests != null)
            {
                foreach (ClassRequest req in classRequests)
                {
                    if (Time.containTime(req.StartTime, req.EndTime, startTime, endTime) && day == req.WeekDay && req.IsApproved == true)
                        if (!aClassRoomsId.Contains(req.ClassRoomId))
                            aClassRoomsId.Add(req.ClassRoomId);
                }
            }
           
            if (lessons != null)
            {
                //Check if avaliable class don't have a lesson in the selected hours.
                foreach (Lesson les in lessons)
                {
                    if (aClassRoomsId.Contains(les.ClassId))
                    {
                        if (les.IntWeekDay == day)
                        {
                            if (Time.coincidentTime(les.StartTime, les.EndTime, startTime, endTime))
                                aClassRoomsId.Remove(les.ClassId);
                        }
                    }
                }
            }
           

            //fill classes in combobox
            int count = 0;
            if (classRooms != null)
            {
                foreach (ClassRoom c in classRooms)
                {
                    if (aClassRoomsId.Contains(c.ClassRoomId))
                    {
                        Item i = new Item(c.Building + c.ClassNumber, c.ClassRoomId);
                        cmbClassRoom.Items.Add(i);
                        count++;
                    }
                }
            }
          
            if (count > 0)
                return true;
            else
                return false;
        }

        private void btnReselect_Click(object sender, EventArgs e)
        {
            cmbClassRoom.Text = "בחר";
            cmbClassRoom.Enabled = false;
            cmbLecturer.Text = "בחר";
            cmbLecturer.Enabled = false;

            cmbDay.Enabled = true;
            cmbStartHour.Enabled = true;
            cmbStartMinute.Enabled = true;
            cmbEndHour.Enabled = true;
            cmbEndMinute.Enabled = true;

            btnReselect.Visible = false;
            btnShow.Visible = true;

            btnAdd.Enabled = false;
        }

        private void cmbDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbStartHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbStartMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEndHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEndMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbLecturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbClassRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            aClassRoomsId.Clear();
            aLecturersId.Clear();

            cmbLecturer.Items.Clear();
            cmbLecturer.Text = "בחר";
            cmbLecturer.Enabled = false;

            cmbClassRoom.Items.Clear();
            cmbClassRoom.Text = "בחר";
            cmbClassRoom.Enabled = false;

            cmbDay.Text = "בחר";
            cmbStartHour.Text = "בחר";
            cmbStartMinute.Text = "בחר";
            cmbEndHour.Text = "בחר";
            cmbEndMinute.Text = "בחר";

            btnShow.Visible = true;
            btnReselect.Visible = false;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValidtion())
            {
                Lesson l = new Lesson();
                l.StartTime = startTime;
                l.EndTime = endTime;
                l.IntWeekDay = day;
                l.CourseId = courseId;
                l.ClassId = ((Item)cmbClassRoom.SelectedItem).Value;
 
                string id = ((Item)cmbLecturer.SelectedItem).Value.ToString();
                while (id.Length < 9)
                    id = "0" + id;
                l.LecturerId = id;

                bool success = true;
                try
                {
                    Lesson.AddToDatabase(l);
                }
                catch (Exception ex)
                {
                    Validations.ShowError(ex.Message);
                    success = false;
                }
                if (success == true) { 
                    MessageBox.Show("השיעור נוסף בהצלחה", "Success");
                    this.Close();
                }

            }
        }

        private bool checkValidtion()
        {
            bool valid = true;

            //Check class rooms combo box.
            if (cmbClassRoom.Text == "בחר")
            {
                errorProvider1.SetError(cmbClassRoom, "יש לבחור כיתה");
                valid = false;
            }

            //Check lecturers combo box.
            if (cmbLecturer.Text == "בחר")
            {
                errorProvider1.SetError(cmbLecturer, "יש לבחור מרצה");
                valid = false;
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddLesson_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
        }
    }
}
