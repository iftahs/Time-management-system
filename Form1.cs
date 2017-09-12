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
using Bs_Pro14.Classes;
using Bs_Pro14.Class;

namespace Bs_Pro14
{
    public partial class Form1 : Form
    {
        private Person person = new Person(Program.person);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

            if (Program.person.FacebookID == "0")
                התחברלחשבוןFacebookToolStripMenuItem.Visible = true;

            if (Program.person.Logistic == true || Program.person.Secretary == true || Program.person.Head == true)
            {
                הצגאתכלהמשתמשיםToolStripMenuItem.Visible = true;
                הוספתמשתמשלמערכתToolStripMenuItem.Visible = true;
            }
            else
            {
                הצגאתכלהמשתמשיםToolStripMenuItem.Visible = false;
                הוספתמשתמשלמערכתToolStripMenuItem.Visible = false;
            }
               
        }
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                this.Name = name;
                this.Value = value;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }       

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSecretary_ManagerCoursesBySyallbus_Click(object sender, EventArgs e)
        {
            pnlSecretryMain.Visible = false;
            pnlSecretary_ManageCoursesBySyallbus.Location = new Point(pnlSecretryMain.Location.X, pnlSecretryMain.Location.Y);
            pnlSecretary_ManageCoursesBySyallbus.Visible = true;
        }

        private void btnSecretary_CoursesBySyllabus_Back_Click(object sender, EventArgs e)
        {
            pnlSecretary_ManageCoursesBySyallbus.Visible = false;
            pnlSecretryMain.Visible = true;
        }

        private void btnSecretary_ManageLecturers_Click(object sender, EventArgs e)
        {
            pnlSecretryMain.Visible = false;
            pnlSecretary_ManageLecturers.Visible = true;
            pnlSecretary_ManageLecturers.Location = new Point(pnlSecretryMain.Location.X, pnlSecretryMain.Location.Y);
        }

        private void btnSecretary_Lecturers_Back_Click(object sender, EventArgs e)
        {
            pnlSecretary_ManageLecturers.Visible = false;
            pnlSecretryMain.Visible = true;
        }

        private void btnSecretary_ManagerClasses_Click(object sender, EventArgs e)
        {
            pnlSecretryMain.Visible = false;
            pnlSecretary_ManageClasses.Visible = true;
            pnlSecretary_ManageClasses.Location = new Point(pnlSecretryMain.Location.X, pnlSecretryMain.Location.Y);
        }

        private void btnSecretary_ClassesManager_Back_Click(object sender, EventArgs e)
        {
            pnlSecretary_ManageClasses.Visible = false;
            pnlSecretryMain.Visible = true;
        }

        private void btnLogisticManager_ManageClassrooms_Click(object sender, EventArgs e)
        {
            pnlLogisticMain.Visible = false;
            pnlLogisticManageClasses.Visible = true;
            pnlLogisticManageClasses.Location = new Point(pnlLogisticMain.Location.X, pnlLogisticMain.Location.Y);

        }

        private void btnLogisticManager_Back_Click(object sender, EventArgs e)
        {
            pnlLogisticManageClasses.Visible = false;
            pnlLogisticMain.Visible = true;
        }

        private void btnLec_ManageConstraints_Click(object sender, EventArgs e)
        {
            pnlLecturerMain.Visible = false;
            pnlLecManageConstraints.Visible = true;
            pnlLecManageConstraints.Location = new Point(pnlLecturerMain.Location.X, pnlLecturerMain.Location.Y);
        }

        private void btnLec_Back_Click(object sender, EventArgs e)
        {
            pnlLecManageConstraints.Visible = false;
            pnlLecturerMain.Visible = true;
            pnlLecturer.Controls.Clear();
        }

        private void btnLecWeeklyConstraintsSystem_Click(object sender, EventArgs e)
        {
            if (Constraints.hasConstrain(person.ID))
            {
                pnlLecturer.Controls.Clear();
                frmShowConstriant frm = new frmShowConstriant(person.ID);
                frm.TopLevel = false;
                pnlLecturer.Controls.Add(frm);
                frm.Width = pnlLecturer.Width;
                frm.Height = pnlLecturer.Height;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {

            MessageBox.Show("אין נתונים במערכת");
            }
        }

        private void btnLec_ManageCourses_Click(object sender, EventArgs e)
        {
            pnlLecturerMain.Visible = false;
            pnlLecCoursesManagment.Visible = true;
            pnlLecCoursesManagment.Location = new Point(pnlLecturerMain.Location.X, pnlLecturerMain.Location.Y);
        }

        private void btnLecCouresesManage_Back_Click(object sender, EventArgs e)
        {
            pnlLecCoursesManagment.Visible = false;
            pnlLecturerMain.Visible = true;
            pnlLecturer.Controls.Clear();
        }

        private void btnHead_ManageLecturers_Click(object sender, EventArgs e)
        {
            pnlHeadMain.Visible = false;
            pnlHead_ManageLectuers.Visible = true;
            pnlHead_ManageLectuers.Location = new Point(pnlHeadMain.Location.X, pnlHeadMain.Location.Y);
        }

        private void btnHead_ManagerLecturers_Back_Click(object sender, EventArgs e)
        {
            pnlHead_ManageLectuers.Visible = false;
            pnlHead.Controls.Clear();
            pnlHeadMain.Visible = true;
        }

        private void btnHead_ManageCourses_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();

            frmShowCourses frm = new frmShowCourses();
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_ManageStudents_Click(object sender, EventArgs e)
        {
            pnlHeadMain.Visible = false;
            pnlHead_ManageStudents.Visible = true;
            pnlHead_ManageStudents.Location = new Point(pnlHeadMain.Location.X, pnlHeadMain.Location.Y);
        }

        private void btnHead_ManageStudents_Back_Click(object sender, EventArgs e)
        {
            pnlHead_ManageStudents.Visible = false;
            pnlHead.Controls.Clear();
            pnlHeadMain.Visible = true;
        }

        private void btnSecretary_AddLecturer_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmAddPerson frm = new frmAddPerson("lecturer");
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLecManageConstraints.Visible = true;
        }

        private void btnSecretary_LecturersList_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmShowPersons frm = new frmShowPersons("lecturer");
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLecCoursesList_Click(object sender, EventArgs e)
        {
            pnlLecturer.Controls.Clear();
            frmShowLessonSemester frm = new frmShowLessonSemester(person.ID);
            frm.TopLevel = false;
            pnlLecturer.Controls.Add(frm);
            frm.Width = pnlLecturer.Width;
            frm.Height = pnlLecturer.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void btnLogisticManager_ClassroomsList_Click(object sender, EventArgs e)
        {
            
            pnlLogisticManager.Controls.Clear();
            frmShowClassRooms frm = new frmShowClassRooms();
            frm.TopLevel = false;
            pnlLogisticManager.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlLogisticManager.Width;
            frm.Height = pnlLogisticManager.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogisticManager_AddClassroom_Click(object sender, EventArgs e)
        {
            pnlLogisticManager.Controls.Clear();
            frmAddClassRoom frm = new frmAddClassRoom(false);
            frm.TopLevel = false;
            pnlLogisticManager.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSecretary_ClassRequest_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmCreateClassRequest frm = new frmCreateClassRequest();
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSecretry_AssignedClasses_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmAssignedClassRooms frm = new frmAssignedClassRooms();
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_LecturersList_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();
            frmShowPersons frm = new frmShowPersons("lecturer");
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_AddLecturer_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();
            frmAddPerson frm = new frmAddPerson("lecturer");
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_StudentsList_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();
            frmShowPersons frm = new frmShowPersons("student");
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogisticManager_ManageSecretaryRequest_Click_1(object sender, EventArgs e)
        {
            pnlLogisticMain.Visible = false;
            pnlLogisticManageClasseRequest.Visible = true;
            pnlLogisticManageClasseRequest.Location = new Point(pnlLogisticMain.Location.X, pnlLogisticMain.Location.Y);
        }

        private void btnLogisticManager_ClassroomRequestList_Click_1(object sender, EventArgs e)
        {
            pnlLogisticManager.Controls.Clear();
            frmShowClassRequest frm = new frmShowClassRequest();
            frm.TopLevel = false;
            pnlLogisticManager.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlLogisticManager.Width;
            frm.Height = pnlLogisticManager.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogisticManager_ClassRequest_Back_Click(object sender, EventArgs e)
        {
            pnlLogisticManageClasseRequest.Visible = false;
            pnlLogisticMain.Visible = true;
        }

        private void btnHead_CoursesBySemester_Click(object sender, EventArgs e)
        {

            pnlHead.Controls.Clear();
            frmShowCourses frm = new frmShowCourses();
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_FailStudents_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();
            frmShowFailStudent frm = new frmShowFailStudent();
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLecAddContrain_Click(object sender, EventArgs e)
        {
            pnlLecturer.Controls.Clear();
            frmAddConstraint frm = new frmAddConstraint();
            frm.TopLevel = false;
            pnlLecturer.Controls.Add(frm);
            frm.Width = pnlLecturer.Width;
            frm.Height = pnlLecturer.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSecretary_CoursesBySyllabus_Add_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmAddCourse frm = new frmAddCourse();
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSecretary_CoursesBySyllabus_List_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            frmShowCourses frm = new frmShowCourses();
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHead_ManageConstraints_Click(object sender, EventArgs e)
        {
            pnlHead.Controls.Clear();
            frmManageConstants frm = new frmManageConstants();
            frm.TopLevel = false;
            pnlHead.Controls.Add(frm);
            frm.Width = pnlHead.Width;
            frm.Height = pnlHead.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlSecretryMain.Visible = false;
            pnlSecretary_ManageStudent.Visible = true;
            pnlSecretary_ManageStudent.Location = new Point(pnlSecretryMain.Location.X, pnlSecretryMain.Location.Y);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            autoSchStudent frm = new autoSchStudent(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            PostponementCourse frm = new PostponementCourse(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            RegFullCourse frm = new RegFullCourse(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            SecViewCourses frm = new SecViewCourses(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            SecViewStudCourses frm = new SecViewStudCourses(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            scheduleChangeStudent frm = new scheduleChangeStudent(person);
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pnlLogisticManager.Controls.Clear();
            MeSchBuild frm = new MeSchBuild();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlLogisticManager.Controls.Clear();
            CoursesInLabs frm = new CoursesInLabs();
            frm.TopLevel = false;
            pnlLogisticManager.Controls.Add(frm);
            frm.Width = pnlLogisticManager.Width;
            frm.Height = pnlLogisticManager.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pnlLogisticManager.Controls.Clear();
            LecInLabs frm = new LecInLabs();
            frm.TopLevel = false;
            pnlLogisticManager.Controls.Add(frm);
            frm.Width = pnlLogisticManager.Width;
            frm.Height = pnlLogisticManager.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DailySchdule frm = new DailySchdule(person);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CourseInfo frm = new CourseInfo();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StuViewCourses frm = new StuViewCourses(person);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrialCourse frm = new TrialCourse(person);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            RankingofLecturers frm = new RankingofLecturers(person);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pnlLecturer.Controls.Clear();
            LecViewCourses frm = new LecViewCourses(person);
            frm.TopLevel = false;
            pnlLecturer.Controls.Add(frm);
            frm.Width = pnlLecturer.Width;
            frm.Height = pnlLecturer.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pnlLecturer.Controls.Clear();
            LecViewStud frm = new LecViewStud();
            frm.TopLevel = false;
            pnlLecturer.Controls.Add(frm);
            frm.Width = pnlLecturer.Width;
            frm.Height = pnlLecturer.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pnlLecturer.Controls.Clear();
            LecViewSchedule frm = new LecViewSchedule(person);
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            float rating = 0;
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect("select * from dbo.Rating where lectureId='" + person.ID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                rating += (int)dt.Rows[i]["numOfRating"];
            }
            rating /= (float)dt.Rows.Count;
            MessageBox.Show("Your rating is: " + rating);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PersonS stu = new PersonS(person);
            ScheduleBuild frm = new ScheduleBuild(stu);
            frm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PersonS stu = new PersonS(person);
            Schedule frm = new Schedule(stu);
            frm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pnlSecretary.Controls.Clear();
            NumOfStudInCourse frm = new NumOfStudInCourse();
            frm.TopLevel = false;
            pnlSecretary.Controls.Add(frm);
            frm.Width = pnlSecretary.Width;
            frm.Height = pnlSecretary.Height;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlSecretary_ManageStudent.Visible = false;
            pnlSecretryMain.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void התחברלחשבוןFacebookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFacebookLogin frm = new frmFacebookLogin();
            frm.Show();
            this.Hide();
        }

        private void התנתקToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void הוספתמשתמשלמערכתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson("all");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void הצגאתכלהמשתמשיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersons frm = new frmShowPersons();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void אודותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }
    }
}
