using Bs_Pro14.Classes;
using System;
using System.Windows.Forms;

namespace Bs_Pro14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.קובץToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.משתמשToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.התחברלחשבוןFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמשלמערכתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגאתכלהמשתמשיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.משתמשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגפרטיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עזרהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אודותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSecretary = new System.Windows.Forms.TabPage();
            this.pnlSecretary_ManageStudent = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlSecretary_ManageCoursesBySyallbus = new System.Windows.Forms.Panel();
            this.btnSecretary_CoursesBySyllabus_Back = new System.Windows.Forms.Button();
            this.btnSecretary_CoursesBySyllabus_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSecretary_CoursesBySyllabus_List = new System.Windows.Forms.Button();
            this.pnlSecretary_ManageLecturers = new System.Windows.Forms.Panel();
            this.btnSecretary_Lecturers_Back = new System.Windows.Forms.Button();
            this.btnSecretary_AddLecturer = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSecretary_LecturersList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSecretary_ManageClasses = new System.Windows.Forms.Panel();
            this.btnSecretary_ClassesManager_Back = new System.Windows.Forms.Button();
            this.btnSecretary_ClassRequest = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSecretry_AssignedClasses = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSecretary = new System.Windows.Forms.Panel();
            this.pnlSecretryMain = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSecretary_ManagerCoursesBySyallbus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSecretary_ManagerClasses = new System.Windows.Forms.Button();
            this.btnSecretary_ManageLecturers = new System.Windows.Forms.Button();
            this.tabLogistic = new System.Windows.Forms.TabPage();
            this.pnlLogisticManageClasseRequest = new System.Windows.Forms.Panel();
            this.btnLogisticManager_ClassRequest_Back = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLogisticManager_ClassroomRequestList = new System.Windows.Forms.Button();
            this.pnlLogisticManager = new System.Windows.Forms.Panel();
            this.pnlLogisticManageClasses = new System.Windows.Forms.Panel();
            this.btnLogisticManager_Back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogisticManager_ClassroomsList = new System.Windows.Forms.Button();
            this.btnLogisticManager_AddClassroom = new System.Windows.Forms.Button();
            this.pnlLogisticMain = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogisticManager_ManageClassrooms = new System.Windows.Forms.Button();
            this.btnLogisticManager_ManageSecretaryRequest = new System.Windows.Forms.Button();
            this.tabLecturer = new System.Windows.Forms.TabPage();
            this.pnlLecturer = new System.Windows.Forms.Panel();
            this.pnlLecCoursesManagment = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnLecCouresesManage_Back = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlLecManageConstraints = new System.Windows.Forms.Panel();
            this.btnLecAddContrain = new System.Windows.Forms.Button();
            this.btnLec_ConstraintsManageBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLecWeeklyConstraintsSystem = new System.Windows.Forms.Button();
            this.pnlLecturerMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLec_ManageConstraints = new System.Windows.Forms.Button();
            this.btnLec_ManageCourses = new System.Windows.Forms.Button();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabHead = new System.Windows.Forms.TabPage();
            this.pnlHead_ManageLectuers = new System.Windows.Forms.Panel();
            this.btnHead_ManageConstraints = new System.Windows.Forms.Button();
            this.btnHead_ManagerLecturers_Back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHead_LecturersList = new System.Windows.Forms.Button();
            this.btnHead_AddLecturer = new System.Windows.Forms.Button();
            this.pnlHead_ManageStudents = new System.Windows.Forms.Panel();
            this.btnHead_ManageStudents_Back = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHead_StudentsList = new System.Windows.Forms.Button();
            this.btnHead_FailStudents = new System.Windows.Forms.Button();
            this.pnlHeadMain = new System.Windows.Forms.Panel();
            this.btnHead_ManageStudents = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHead_ManageLecturers = new System.Windows.Forms.Button();
            this.btnHead_ManageCourses = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSecretary.SuspendLayout();
            this.pnlSecretary_ManageStudent.SuspendLayout();
            this.pnlSecretary_ManageCoursesBySyallbus.SuspendLayout();
            this.pnlSecretary_ManageLecturers.SuspendLayout();
            this.pnlSecretary_ManageClasses.SuspendLayout();
            this.pnlSecretryMain.SuspendLayout();
            this.tabLogistic.SuspendLayout();
            this.pnlLogisticManageClasseRequest.SuspendLayout();
            this.pnlLogisticManageClasses.SuspendLayout();
            this.pnlLogisticMain.SuspendLayout();
            this.tabLecturer.SuspendLayout();
            this.pnlLecCoursesManagment.SuspendLayout();
            this.pnlLecManageConstraints.SuspendLayout();
            this.pnlLecturerMain.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabHead.SuspendLayout();
            this.pnlHead_ManageLectuers.SuspendLayout();
            this.pnlHead_ManageStudents.SuspendLayout();
            this.pnlHeadMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.קובץToolStripMenuItem,
            this.משתמשToolStripMenuItem1,
            this.משתמשToolStripMenuItem,
            this.עזרהToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // קובץToolStripMenuItem
            // 
            this.קובץToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.יציאהToolStripMenuItem});
            this.קובץToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.קובץToolStripMenuItem.Name = "קובץToolStripMenuItem";
            this.קובץToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.קובץToolStripMenuItem.Text = "קובץ";
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.יציאהToolStripMenuItem.Text = "יציאה";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // משתמשToolStripMenuItem1
            // 
            this.משתמשToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.התנתקToolStripMenuItem1,
            this.התחברלחשבוןFacebookToolStripMenuItem,
            this.הוספתמשתמשלמערכתToolStripMenuItem,
            this.הצגאתכלהמשתמשיםToolStripMenuItem});
            this.משתמשToolStripMenuItem1.Name = "משתמשToolStripMenuItem1";
            this.משתמשToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.משתמשToolStripMenuItem1.Text = "משתמש";
            // 
            // התנתקToolStripMenuItem1
            // 
            this.התנתקToolStripMenuItem1.Name = "התנתקToolStripMenuItem1";
            this.התנתקToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.התנתקToolStripMenuItem1.Text = "התנתק";
            this.התנתקToolStripMenuItem1.Click += new System.EventHandler(this.התנתקToolStripMenuItem1_Click);
            // 
            // התחברלחשבוןFacebookToolStripMenuItem
            // 
            this.התחברלחשבוןFacebookToolStripMenuItem.Name = "התחברלחשבוןFacebookToolStripMenuItem";
            this.התחברלחשבוןFacebookToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.התחברלחשבוןFacebookToolStripMenuItem.Text = "התחבר לחשבון Facebook";
            this.התחברלחשבוןFacebookToolStripMenuItem.Visible = false;
            this.התחברלחשבוןFacebookToolStripMenuItem.Click += new System.EventHandler(this.התחברלחשבוןFacebookToolStripMenuItem_Click_1);
            // 
            // הוספתמשתמשלמערכתToolStripMenuItem
            // 
            this.הוספתמשתמשלמערכתToolStripMenuItem.Name = "הוספתמשתמשלמערכתToolStripMenuItem";
            this.הוספתמשתמשלמערכתToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.הוספתמשתמשלמערכתToolStripMenuItem.Text = "הוספת משתמש למערכת";
            this.הוספתמשתמשלמערכתToolStripMenuItem.Visible = false;
            this.הוספתמשתמשלמערכתToolStripMenuItem.Click += new System.EventHandler(this.הוספתמשתמשלמערכתToolStripMenuItem_Click);
            // 
            // הצגאתכלהמשתמשיםToolStripMenuItem
            // 
            this.הצגאתכלהמשתמשיםToolStripMenuItem.Name = "הצגאתכלהמשתמשיםToolStripMenuItem";
            this.הצגאתכלהמשתמשיםToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.הצגאתכלהמשתמשיםToolStripMenuItem.Text = "הצג את כל המשתמשים";
            this.הצגאתכלהמשתמשיםToolStripMenuItem.Click += new System.EventHandler(this.הצגאתכלהמשתמשיםToolStripMenuItem_Click);
            // 
            // משתמשToolStripMenuItem
            // 
            this.משתמשToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הצגפרטיםToolStripMenuItem,
            this.התנתקToolStripMenuItem});
            this.משתמשToolStripMenuItem.Name = "משתמשToolStripMenuItem";
            this.משתמשToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // הצגפרטיםToolStripMenuItem
            // 
            this.הצגפרטיםToolStripMenuItem.Name = "הצגפרטיםToolStripMenuItem";
            this.הצגפרטיםToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            // 
            // התנתקToolStripMenuItem
            // 
            this.התנתקToolStripMenuItem.Name = "התנתקToolStripMenuItem";
            this.התנתקToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.התנתקToolStripMenuItem.Text = "התנתק";
            // 
            // עזרהToolStripMenuItem
            // 
            this.עזרהToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.אודותToolStripMenuItem});
            this.עזרהToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.עזרהToolStripMenuItem.Name = "עזרהToolStripMenuItem";
            this.עזרהToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.עזרהToolStripMenuItem.Text = "עזרה";
            // 
            // אודותToolStripMenuItem
            // 
            this.אודותToolStripMenuItem.Name = "אודותToolStripMenuItem";
            this.אודותToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.אודותToolStripMenuItem.Text = "אודות";
            this.אודותToolStripMenuItem.Click += new System.EventHandler(this.אודותToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "DateTIme";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSecretary);
            this.tabControl.Controls.Add(this.tabLogistic);
            this.tabControl.Controls.Add(this.tabLecturer);
            this.tabControl.Controls.Add(this.tabStudent);
            this.tabControl.Controls.Add(this.tabHead);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(949, 396);
            this.tabControl.TabIndex = 10;
            // 
            // tabSecretary
            // 
            this.tabSecretary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSecretary.Controls.Add(this.pnlSecretary_ManageStudent);
            this.tabSecretary.Controls.Add(this.pnlSecretary_ManageCoursesBySyallbus);
            this.tabSecretary.Controls.Add(this.pnlSecretary_ManageLecturers);
            this.tabSecretary.Controls.Add(this.pnlSecretary_ManageClasses);
            this.tabSecretary.Controls.Add(this.pnlSecretary);
            this.tabSecretary.Controls.Add(this.pnlSecretryMain);
            this.tabSecretary.Location = new System.Drawing.Point(4, 22);
            this.tabSecretary.Name = "tabSecretary";
            this.tabSecretary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecretary.Size = new System.Drawing.Size(941, 370);
            this.tabSecretary.TabIndex = 1;
            this.tabSecretary.Text = "מזכירה";
            // 
            // pnlSecretary_ManageStudent
            // 
            this.pnlSecretary_ManageStudent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSecretary_ManageStudent.Controls.Add(this.button23);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button11);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button10);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button9);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button8);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button5);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button6);
            this.pnlSecretary_ManageStudent.Controls.Add(this.label15);
            this.pnlSecretary_ManageStudent.Controls.Add(this.panel7);
            this.pnlSecretary_ManageStudent.Controls.Add(this.button7);
            this.pnlSecretary_ManageStudent.Location = new System.Drawing.Point(716, 144);
            this.pnlSecretary_ManageStudent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretary_ManageStudent.Name = "pnlSecretary_ManageStudent";
            this.pnlSecretary_ManageStudent.Size = new System.Drawing.Size(220, 227);
            this.pnlSecretary_ManageStudent.TabIndex = 17;
            this.pnlSecretary_ManageStudent.Visible = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.Menu;
            this.button23.Location = new System.Drawing.Point(7, 171);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(210, 23);
            this.button23.TabIndex = 20;
            this.button23.Text = "רשימת סטודנטים הרשומים לקורס";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Menu;
            this.button11.Location = new System.Drawing.Point(6, 145);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(210, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "הצגה\\שינוי מערכת שעות סטודנט";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Menu;
            this.button10.Location = new System.Drawing.Point(6, 119);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(210, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "רשימת קורסים של סטודנט";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Menu;
            this.button9.Location = new System.Drawing.Point(6, 93);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(210, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "רשימת קורסים לפי סמסטר";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Menu;
            this.button8.Location = new System.Drawing.Point(6, 67);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(210, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "רישום לקורס מלא";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Location = new System.Drawing.Point(6, 200);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "חזור";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Location = new System.Drawing.Point(6, 41);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "דחיית קורס לסטודנט";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Right;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(131, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "ניהול סטודנטים";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(503, 123);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(162, 161);
            this.panel7.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.Location = new System.Drawing.Point(6, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "בניית מערכת שעות אוטומטית";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnlSecretary_ManageCoursesBySyallbus
            // 
            this.pnlSecretary_ManageCoursesBySyallbus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSecretary_ManageCoursesBySyallbus.Controls.Add(this.btnSecretary_CoursesBySyllabus_Back);
            this.pnlSecretary_ManageCoursesBySyallbus.Controls.Add(this.btnSecretary_CoursesBySyllabus_Add);
            this.pnlSecretary_ManageCoursesBySyallbus.Controls.Add(this.label5);
            this.pnlSecretary_ManageCoursesBySyallbus.Controls.Add(this.panel4);
            this.pnlSecretary_ManageCoursesBySyallbus.Controls.Add(this.btnSecretary_CoursesBySyllabus_List);
            this.pnlSecretary_ManageCoursesBySyallbus.Location = new System.Drawing.Point(717, 114);
            this.pnlSecretary_ManageCoursesBySyallbus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretary_ManageCoursesBySyallbus.Name = "pnlSecretary_ManageCoursesBySyallbus";
            this.pnlSecretary_ManageCoursesBySyallbus.Size = new System.Drawing.Size(220, 93);
            this.pnlSecretary_ManageCoursesBySyallbus.TabIndex = 16;
            this.pnlSecretary_ManageCoursesBySyallbus.Visible = false;
            // 
            // btnSecretary_CoursesBySyllabus_Back
            // 
            this.btnSecretary_CoursesBySyllabus_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_CoursesBySyllabus_Back.Location = new System.Drawing.Point(6, 67);
            this.btnSecretary_CoursesBySyllabus_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_CoursesBySyllabus_Back.Name = "btnSecretary_CoursesBySyllabus_Back";
            this.btnSecretary_CoursesBySyllabus_Back.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_CoursesBySyllabus_Back.TabIndex = 15;
            this.btnSecretary_CoursesBySyllabus_Back.Text = "חזור";
            this.btnSecretary_CoursesBySyllabus_Back.UseVisualStyleBackColor = false;
            this.btnSecretary_CoursesBySyllabus_Back.Click += new System.EventHandler(this.btnSecretary_CoursesBySyllabus_Back_Click);
            // 
            // btnSecretary_CoursesBySyllabus_Add
            // 
            this.btnSecretary_CoursesBySyllabus_Add.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_CoursesBySyllabus_Add.Location = new System.Drawing.Point(6, 41);
            this.btnSecretary_CoursesBySyllabus_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_CoursesBySyllabus_Add.Name = "btnSecretary_CoursesBySyllabus_Add";
            this.btnSecretary_CoursesBySyllabus_Add.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_CoursesBySyllabus_Add.TabIndex = 14;
            this.btnSecretary_CoursesBySyllabus_Add.Text = "הוספת קורס חדש";
            this.btnSecretary_CoursesBySyllabus_Add.UseVisualStyleBackColor = false;
            this.btnSecretary_CoursesBySyllabus_Add.Click += new System.EventHandler(this.btnSecretary_CoursesBySyllabus_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(99, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ניהול קורסים למחלקה";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(503, 123);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 161);
            this.panel4.TabIndex = 12;
            // 
            // btnSecretary_CoursesBySyllabus_List
            // 
            this.btnSecretary_CoursesBySyllabus_List.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_CoursesBySyllabus_List.Location = new System.Drawing.Point(6, 15);
            this.btnSecretary_CoursesBySyllabus_List.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_CoursesBySyllabus_List.Name = "btnSecretary_CoursesBySyllabus_List";
            this.btnSecretary_CoursesBySyllabus_List.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_CoursesBySyllabus_List.TabIndex = 11;
            this.btnSecretary_CoursesBySyllabus_List.Text = "רשימת קורסים";
            this.btnSecretary_CoursesBySyllabus_List.UseVisualStyleBackColor = false;
            this.btnSecretary_CoursesBySyllabus_List.Click += new System.EventHandler(this.btnSecretary_CoursesBySyllabus_List_Click);
            // 
            // pnlSecretary_ManageLecturers
            // 
            this.pnlSecretary_ManageLecturers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSecretary_ManageLecturers.Controls.Add(this.btnSecretary_Lecturers_Back);
            this.pnlSecretary_ManageLecturers.Controls.Add(this.btnSecretary_AddLecturer);
            this.pnlSecretary_ManageLecturers.Controls.Add(this.panel6);
            this.pnlSecretary_ManageLecturers.Controls.Add(this.btnSecretary_LecturersList);
            this.pnlSecretary_ManageLecturers.Controls.Add(this.label6);
            this.pnlSecretary_ManageLecturers.Location = new System.Drawing.Point(716, 251);
            this.pnlSecretary_ManageLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretary_ManageLecturers.Name = "pnlSecretary_ManageLecturers";
            this.pnlSecretary_ManageLecturers.Size = new System.Drawing.Size(220, 93);
            this.pnlSecretary_ManageLecturers.TabIndex = 17;
            this.pnlSecretary_ManageLecturers.Visible = false;
            // 
            // btnSecretary_Lecturers_Back
            // 
            this.btnSecretary_Lecturers_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_Lecturers_Back.Location = new System.Drawing.Point(6, 67);
            this.btnSecretary_Lecturers_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_Lecturers_Back.Name = "btnSecretary_Lecturers_Back";
            this.btnSecretary_Lecturers_Back.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_Lecturers_Back.TabIndex = 15;
            this.btnSecretary_Lecturers_Back.Text = "חזור";
            this.btnSecretary_Lecturers_Back.UseVisualStyleBackColor = false;
            this.btnSecretary_Lecturers_Back.Click += new System.EventHandler(this.btnSecretary_Lecturers_Back_Click);
            // 
            // btnSecretary_AddLecturer
            // 
            this.btnSecretary_AddLecturer.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_AddLecturer.Location = new System.Drawing.Point(6, 41);
            this.btnSecretary_AddLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_AddLecturer.Name = "btnSecretary_AddLecturer";
            this.btnSecretary_AddLecturer.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_AddLecturer.TabIndex = 14;
            this.btnSecretary_AddLecturer.Text = "הוספת מרצה";
            this.btnSecretary_AddLecturer.UseVisualStyleBackColor = false;
            this.btnSecretary_AddLecturer.Click += new System.EventHandler(this.btnSecretary_AddLecturer_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(503, 123);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 161);
            this.panel6.TabIndex = 12;
            // 
            // btnSecretary_LecturersList
            // 
            this.btnSecretary_LecturersList.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_LecturersList.Location = new System.Drawing.Point(6, 15);
            this.btnSecretary_LecturersList.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_LecturersList.Name = "btnSecretary_LecturersList";
            this.btnSecretary_LecturersList.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_LecturersList.TabIndex = 11;
            this.btnSecretary_LecturersList.Text = "רשימת מרצים";
            this.btnSecretary_LecturersList.UseVisualStyleBackColor = false;
            this.btnSecretary_LecturersList.Click += new System.EventHandler(this.btnSecretary_LecturersList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(96, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ניהול מרצים ומתרגלים";
            // 
            // pnlSecretary_ManageClasses
            // 
            this.pnlSecretary_ManageClasses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSecretary_ManageClasses.Controls.Add(this.btnSecretary_ClassesManager_Back);
            this.pnlSecretary_ManageClasses.Controls.Add(this.btnSecretary_ClassRequest);
            this.pnlSecretary_ManageClasses.Controls.Add(this.panel5);
            this.pnlSecretary_ManageClasses.Controls.Add(this.btnSecretry_AssignedClasses);
            this.pnlSecretary_ManageClasses.Controls.Add(this.label7);
            this.pnlSecretary_ManageClasses.Location = new System.Drawing.Point(716, 72);
            this.pnlSecretary_ManageClasses.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretary_ManageClasses.Name = "pnlSecretary_ManageClasses";
            this.pnlSecretary_ManageClasses.Size = new System.Drawing.Size(220, 93);
            this.pnlSecretary_ManageClasses.TabIndex = 18;
            this.pnlSecretary_ManageClasses.Visible = false;
            // 
            // btnSecretary_ClassesManager_Back
            // 
            this.btnSecretary_ClassesManager_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_ClassesManager_Back.Location = new System.Drawing.Point(6, 67);
            this.btnSecretary_ClassesManager_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_ClassesManager_Back.Name = "btnSecretary_ClassesManager_Back";
            this.btnSecretary_ClassesManager_Back.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_ClassesManager_Back.TabIndex = 15;
            this.btnSecretary_ClassesManager_Back.Text = "חזור";
            this.btnSecretary_ClassesManager_Back.UseVisualStyleBackColor = false;
            this.btnSecretary_ClassesManager_Back.Click += new System.EventHandler(this.btnSecretary_ClassesManager_Back_Click);
            // 
            // btnSecretary_ClassRequest
            // 
            this.btnSecretary_ClassRequest.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_ClassRequest.Location = new System.Drawing.Point(6, 41);
            this.btnSecretary_ClassRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_ClassRequest.Name = "btnSecretary_ClassRequest";
            this.btnSecretary_ClassRequest.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_ClassRequest.TabIndex = 14;
            this.btnSecretary_ClassRequest.Text = "בקשה להקצאת כיתה";
            this.btnSecretary_ClassRequest.UseVisualStyleBackColor = false;
            this.btnSecretary_ClassRequest.Click += new System.EventHandler(this.btnSecretary_ClassRequest_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(503, 123);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 161);
            this.panel5.TabIndex = 12;
            // 
            // btnSecretry_AssignedClasses
            // 
            this.btnSecretry_AssignedClasses.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretry_AssignedClasses.Location = new System.Drawing.Point(6, 15);
            this.btnSecretry_AssignedClasses.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretry_AssignedClasses.Name = "btnSecretry_AssignedClasses";
            this.btnSecretry_AssignedClasses.Size = new System.Drawing.Size(210, 23);
            this.btnSecretry_AssignedClasses.TabIndex = 11;
            this.btnSecretry_AssignedClasses.Text = "כיתות שהוקצו למחלקה";
            this.btnSecretry_AssignedClasses.UseVisualStyleBackColor = false;
            this.btnSecretry_AssignedClasses.Click += new System.EventHandler(this.btnSecretry_AssignedClasses_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(150, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ניהול כיתות";
            // 
            // pnlSecretary
            // 
            this.pnlSecretary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSecretary.Location = new System.Drawing.Point(0, 0);
            this.pnlSecretary.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretary.Name = "pnlSecretary";
            this.pnlSecretary.Size = new System.Drawing.Size(714, 372);
            this.pnlSecretary.TabIndex = 19;
            // 
            // pnlSecretryMain
            // 
            this.pnlSecretryMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSecretryMain.Controls.Add(this.button4);
            this.pnlSecretryMain.Controls.Add(this.btnSecretary_ManagerCoursesBySyallbus);
            this.pnlSecretryMain.Controls.Add(this.label4);
            this.pnlSecretryMain.Controls.Add(this.btnSecretary_ManagerClasses);
            this.pnlSecretryMain.Controls.Add(this.btnSecretary_ManageLecturers);
            this.pnlSecretryMain.Location = new System.Drawing.Point(718, 5);
            this.pnlSecretryMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSecretryMain.Name = "pnlSecretryMain";
            this.pnlSecretryMain.Size = new System.Drawing.Size(220, 122);
            this.pnlSecretryMain.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Location = new System.Drawing.Point(6, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "ניהול סטודנטים";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSecretary_ManagerCoursesBySyallbus
            // 
            this.btnSecretary_ManagerCoursesBySyallbus.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_ManagerCoursesBySyallbus.Location = new System.Drawing.Point(6, 15);
            this.btnSecretary_ManagerCoursesBySyallbus.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_ManagerCoursesBySyallbus.Name = "btnSecretary_ManagerCoursesBySyallbus";
            this.btnSecretary_ManagerCoursesBySyallbus.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_ManagerCoursesBySyallbus.TabIndex = 6;
            this.btnSecretary_ManagerCoursesBySyallbus.Text = "ניהול קורסים";
            this.btnSecretary_ManagerCoursesBySyallbus.UseVisualStyleBackColor = false;
            this.btnSecretary_ManagerCoursesBySyallbus.Click += new System.EventHandler(this.btnSecretary_ManagerCoursesBySyallbus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(150, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "תפריט ראשי";
            // 
            // btnSecretary_ManagerClasses
            // 
            this.btnSecretary_ManagerClasses.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_ManagerClasses.Location = new System.Drawing.Point(6, 67);
            this.btnSecretary_ManagerClasses.Name = "btnSecretary_ManagerClasses";
            this.btnSecretary_ManagerClasses.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_ManagerClasses.TabIndex = 8;
            this.btnSecretary_ManagerClasses.Text = "ניהול כיתות";
            this.btnSecretary_ManagerClasses.UseVisualStyleBackColor = false;
            this.btnSecretary_ManagerClasses.Click += new System.EventHandler(this.btnSecretary_ManagerClasses_Click);
            // 
            // btnSecretary_ManageLecturers
            // 
            this.btnSecretary_ManageLecturers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecretary_ManageLecturers.Location = new System.Drawing.Point(6, 41);
            this.btnSecretary_ManageLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecretary_ManageLecturers.Name = "btnSecretary_ManageLecturers";
            this.btnSecretary_ManageLecturers.Size = new System.Drawing.Size(210, 23);
            this.btnSecretary_ManageLecturers.TabIndex = 7;
            this.btnSecretary_ManageLecturers.Text = "ניהול מרצים ומתרגלים";
            this.btnSecretary_ManageLecturers.UseVisualStyleBackColor = false;
            this.btnSecretary_ManageLecturers.Click += new System.EventHandler(this.btnSecretary_ManageLecturers_Click);
            // 
            // tabLogistic
            // 
            this.tabLogistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabLogistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLogistic.Controls.Add(this.pnlLogisticManageClasseRequest);
            this.tabLogistic.Controls.Add(this.pnlLogisticManager);
            this.tabLogistic.Controls.Add(this.pnlLogisticManageClasses);
            this.tabLogistic.Controls.Add(this.pnlLogisticMain);
            this.tabLogistic.Location = new System.Drawing.Point(4, 22);
            this.tabLogistic.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogistic.Name = "tabLogistic";
            this.tabLogistic.Padding = new System.Windows.Forms.Padding(2);
            this.tabLogistic.Size = new System.Drawing.Size(941, 370);
            this.tabLogistic.TabIndex = 2;
            this.tabLogistic.Text = "לוגיסטיקה";
            // 
            // pnlLogisticManageClasseRequest
            // 
            this.pnlLogisticManageClasseRequest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLogisticManageClasseRequest.Controls.Add(this.btnLogisticManager_ClassRequest_Back);
            this.pnlLogisticManageClasseRequest.Controls.Add(this.label14);
            this.pnlLogisticManageClasseRequest.Controls.Add(this.btnLogisticManager_ClassroomRequestList);
            this.pnlLogisticManageClasseRequest.Location = new System.Drawing.Point(718, 248);
            this.pnlLogisticManageClasseRequest.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogisticManageClasseRequest.Name = "pnlLogisticManageClasseRequest";
            this.pnlLogisticManageClasseRequest.Size = new System.Drawing.Size(220, 70);
            this.pnlLogisticManageClasseRequest.TabIndex = 13;
            this.pnlLogisticManageClasseRequest.Visible = false;
            // 
            // btnLogisticManager_ClassRequest_Back
            // 
            this.btnLogisticManager_ClassRequest_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_ClassRequest_Back.Location = new System.Drawing.Point(6, 41);
            this.btnLogisticManager_ClassRequest_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_ClassRequest_Back.Name = "btnLogisticManager_ClassRequest_Back";
            this.btnLogisticManager_ClassRequest_Back.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_ClassRequest_Back.TabIndex = 16;
            this.btnLogisticManager_ClassRequest_Back.Text = "חזור";
            this.btnLogisticManager_ClassRequest_Back.UseVisualStyleBackColor = false;
            this.btnLogisticManager_ClassRequest_Back.Click += new System.EventHandler(this.btnLogisticManager_ClassRequest_Back_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Right;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(106, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "ניהול בקשות מזכירה";
            // 
            // btnLogisticManager_ClassroomRequestList
            // 
            this.btnLogisticManager_ClassroomRequestList.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_ClassroomRequestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogisticManager_ClassroomRequestList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogisticManager_ClassroomRequestList.Location = new System.Drawing.Point(6, 15);
            this.btnLogisticManager_ClassroomRequestList.Name = "btnLogisticManager_ClassroomRequestList";
            this.btnLogisticManager_ClassroomRequestList.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_ClassroomRequestList.TabIndex = 5;
            this.btnLogisticManager_ClassroomRequestList.Text = "רשימת בקשות מזכירה";
            this.btnLogisticManager_ClassroomRequestList.UseVisualStyleBackColor = false;
            this.btnLogisticManager_ClassroomRequestList.Click += new System.EventHandler(this.btnLogisticManager_ClassroomRequestList_Click_1);
            // 
            // pnlLogisticManager
            // 
            this.pnlLogisticManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogisticManager.Location = new System.Drawing.Point(0, 0);
            this.pnlLogisticManager.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogisticManager.Name = "pnlLogisticManager";
            this.pnlLogisticManager.Size = new System.Drawing.Size(714, 372);
            this.pnlLogisticManager.TabIndex = 12;
            // 
            // pnlLogisticManageClasses
            // 
            this.pnlLogisticManageClasses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLogisticManageClasses.Controls.Add(this.btnLogisticManager_Back);
            this.pnlLogisticManageClasses.Controls.Add(this.label8);
            this.pnlLogisticManageClasses.Controls.Add(this.btnLogisticManager_ClassroomsList);
            this.pnlLogisticManageClasses.Controls.Add(this.btnLogisticManager_AddClassroom);
            this.pnlLogisticManageClasses.Location = new System.Drawing.Point(718, 160);
            this.pnlLogisticManageClasses.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogisticManageClasses.Name = "pnlLogisticManageClasses";
            this.pnlLogisticManageClasses.Size = new System.Drawing.Size(220, 93);
            this.pnlLogisticManageClasses.TabIndex = 11;
            this.pnlLogisticManageClasses.Visible = false;
            // 
            // btnLogisticManager_Back
            // 
            this.btnLogisticManager_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_Back.Location = new System.Drawing.Point(6, 67);
            this.btnLogisticManager_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_Back.Name = "btnLogisticManager_Back";
            this.btnLogisticManager_Back.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_Back.TabIndex = 16;
            this.btnLogisticManager_Back.Text = "חזור";
            this.btnLogisticManager_Back.UseVisualStyleBackColor = false;
            this.btnLogisticManager_Back.Click += new System.EventHandler(this.btnLogisticManager_Back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(150, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ניהול כיתות";
            // 
            // btnLogisticManager_ClassroomsList
            // 
            this.btnLogisticManager_ClassroomsList.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_ClassroomsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogisticManager_ClassroomsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogisticManager_ClassroomsList.Location = new System.Drawing.Point(6, 15);
            this.btnLogisticManager_ClassroomsList.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_ClassroomsList.Name = "btnLogisticManager_ClassroomsList";
            this.btnLogisticManager_ClassroomsList.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_ClassroomsList.TabIndex = 5;
            this.btnLogisticManager_ClassroomsList.Text = "רשימת כיתות";
            this.btnLogisticManager_ClassroomsList.UseVisualStyleBackColor = false;
            this.btnLogisticManager_ClassroomsList.Click += new System.EventHandler(this.btnLogisticManager_ClassroomsList_Click);
            // 
            // btnLogisticManager_AddClassroom
            // 
            this.btnLogisticManager_AddClassroom.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_AddClassroom.Location = new System.Drawing.Point(6, 41);
            this.btnLogisticManager_AddClassroom.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_AddClassroom.Name = "btnLogisticManager_AddClassroom";
            this.btnLogisticManager_AddClassroom.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_AddClassroom.TabIndex = 6;
            this.btnLogisticManager_AddClassroom.Text = "הוספת כיתה";
            this.btnLogisticManager_AddClassroom.UseVisualStyleBackColor = false;
            this.btnLogisticManager_AddClassroom.Click += new System.EventHandler(this.btnLogisticManager_AddClassroom_Click);
            // 
            // pnlLogisticMain
            // 
            this.pnlLogisticMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLogisticMain.Controls.Add(this.button14);
            this.pnlLogisticMain.Controls.Add(this.button13);
            this.pnlLogisticMain.Controls.Add(this.button12);
            this.pnlLogisticMain.Controls.Add(this.label2);
            this.pnlLogisticMain.Controls.Add(this.btnLogisticManager_ManageClassrooms);
            this.pnlLogisticMain.Controls.Add(this.btnLogisticManager_ManageSecretaryRequest);
            this.pnlLogisticMain.Location = new System.Drawing.Point(718, 5);
            this.pnlLogisticMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogisticMain.Name = "pnlLogisticMain";
            this.pnlLogisticMain.Size = new System.Drawing.Size(220, 152);
            this.pnlLogisticMain.TabIndex = 10;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Menu;
            this.button14.Location = new System.Drawing.Point(6, 119);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(210, 23);
            this.button14.TabIndex = 9;
            this.button14.Text = "רשימת מרצים שרשומים למעבדות";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Menu;
            this.button13.Location = new System.Drawing.Point(6, 93);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(210, 23);
            this.button13.TabIndex = 8;
            this.button13.Text = "רשימת קורסים שרשומים למעבדות";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Menu;
            this.button12.Location = new System.Drawing.Point(6, 67);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(210, 23);
            this.button12.TabIndex = 7;
            this.button12.Text = "בניית מערכת שעות עבודה\\אוטומטית";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(150, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "תפריט ראשי";
            // 
            // btnLogisticManager_ManageClassrooms
            // 
            this.btnLogisticManager_ManageClassrooms.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_ManageClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogisticManager_ManageClassrooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogisticManager_ManageClassrooms.Location = new System.Drawing.Point(6, 15);
            this.btnLogisticManager_ManageClassrooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_ManageClassrooms.Name = "btnLogisticManager_ManageClassrooms";
            this.btnLogisticManager_ManageClassrooms.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_ManageClassrooms.TabIndex = 5;
            this.btnLogisticManager_ManageClassrooms.Text = "ניהול כיתות";
            this.btnLogisticManager_ManageClassrooms.UseVisualStyleBackColor = false;
            this.btnLogisticManager_ManageClassrooms.Click += new System.EventHandler(this.btnLogisticManager_ManageClassrooms_Click);
            // 
            // btnLogisticManager_ManageSecretaryRequest
            // 
            this.btnLogisticManager_ManageSecretaryRequest.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogisticManager_ManageSecretaryRequest.Location = new System.Drawing.Point(6, 41);
            this.btnLogisticManager_ManageSecretaryRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogisticManager_ManageSecretaryRequest.Name = "btnLogisticManager_ManageSecretaryRequest";
            this.btnLogisticManager_ManageSecretaryRequest.Size = new System.Drawing.Size(210, 23);
            this.btnLogisticManager_ManageSecretaryRequest.TabIndex = 6;
            this.btnLogisticManager_ManageSecretaryRequest.Text = "ניהול בקשות מזכירה";
            this.btnLogisticManager_ManageSecretaryRequest.UseVisualStyleBackColor = false;
            this.btnLogisticManager_ManageSecretaryRequest.Click += new System.EventHandler(this.btnLogisticManager_ManageSecretaryRequest_Click_1);
            // 
            // tabLecturer
            // 
            this.tabLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabLecturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLecturer.Controls.Add(this.pnlLecturer);
            this.tabLecturer.Controls.Add(this.pnlLecCoursesManagment);
            this.tabLecturer.Controls.Add(this.pnlLecManageConstraints);
            this.tabLecturer.Controls.Add(this.pnlLecturerMain);
            this.tabLecturer.Location = new System.Drawing.Point(4, 22);
            this.tabLecturer.Name = "tabLecturer";
            this.tabLecturer.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturer.Size = new System.Drawing.Size(941, 370);
            this.tabLecturer.TabIndex = 3;
            this.tabLecturer.Text = "מרצה / מתרגל";
            // 
            // pnlLecturer
            // 
            this.pnlLecturer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLecturer.Location = new System.Drawing.Point(0, 0);
            this.pnlLecturer.Name = "pnlLecturer";
            this.pnlLecturer.Size = new System.Drawing.Size(714, 372);
            this.pnlLecturer.TabIndex = 17;
            // 
            // pnlLecCoursesManagment
            // 
            this.pnlLecCoursesManagment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLecCoursesManagment.Controls.Add(this.button20);
            this.pnlLecCoursesManagment.Controls.Add(this.button19);
            this.pnlLecCoursesManagment.Controls.Add(this.button18);
            this.pnlLecCoursesManagment.Controls.Add(this.button17);
            this.pnlLecCoursesManagment.Controls.Add(this.btnLecCouresesManage_Back);
            this.pnlLecCoursesManagment.Controls.Add(this.label10);
            this.pnlLecCoursesManagment.Location = new System.Drawing.Point(718, 184);
            this.pnlLecCoursesManagment.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLecCoursesManagment.Name = "pnlLecCoursesManagment";
            this.pnlLecCoursesManagment.Size = new System.Drawing.Size(220, 160);
            this.pnlLecCoursesManagment.TabIndex = 13;
            this.pnlLecCoursesManagment.Visible = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.Menu;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(6, 94);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(210, 23);
            this.button20.TabIndex = 12;
            this.button20.Text = "הצגת דירוג ";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Menu;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(6, 68);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(210, 23);
            this.button19.TabIndex = 11;
            this.button19.Text = "הצגת מערכת שעות ";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.Menu;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(6, 42);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(210, 23);
            this.button18.TabIndex = 10;
            this.button18.Text = "רשימת סטודנטים הרשומים לקורס";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.Menu;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(6, 16);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(210, 23);
            this.button17.TabIndex = 9;
            this.button17.Text = "צפייה בקורסים למרצה";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btnLecCouresesManage_Back
            // 
            this.btnLecCouresesManage_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLecCouresesManage_Back.Location = new System.Drawing.Point(6, 128);
            this.btnLecCouresesManage_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnLecCouresesManage_Back.Name = "btnLecCouresesManage_Back";
            this.btnLecCouresesManage_Back.Size = new System.Drawing.Size(210, 23);
            this.btnLecCouresesManage_Back.TabIndex = 8;
            this.btnLecCouresesManage_Back.Text = "חזור";
            this.btnLecCouresesManage_Back.UseVisualStyleBackColor = false;
            this.btnLecCouresesManage_Back.Click += new System.EventHandler(this.btnLecCouresesManage_Back_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(144, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ניהול קורסים";
            // 
            // pnlLecManageConstraints
            // 
            this.pnlLecManageConstraints.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLecManageConstraints.Controls.Add(this.btnLecAddContrain);
            this.pnlLecManageConstraints.Controls.Add(this.btnLec_ConstraintsManageBack);
            this.pnlLecManageConstraints.Controls.Add(this.label9);
            this.pnlLecManageConstraints.Controls.Add(this.btnLecWeeklyConstraintsSystem);
            this.pnlLecManageConstraints.Location = new System.Drawing.Point(718, 107);
            this.pnlLecManageConstraints.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLecManageConstraints.Name = "pnlLecManageConstraints";
            this.pnlLecManageConstraints.Size = new System.Drawing.Size(220, 98);
            this.pnlLecManageConstraints.TabIndex = 12;
            this.pnlLecManageConstraints.Visible = false;
            // 
            // btnLecAddContrain
            // 
            this.btnLecAddContrain.Location = new System.Drawing.Point(6, 41);
            this.btnLecAddContrain.Name = "btnLecAddContrain";
            this.btnLecAddContrain.Size = new System.Drawing.Size(210, 23);
            this.btnLecAddContrain.TabIndex = 8;
            this.btnLecAddContrain.Text = "הוסף אילוץ";
            this.btnLecAddContrain.UseVisualStyleBackColor = true;
            this.btnLecAddContrain.Click += new System.EventHandler(this.btnLecAddContrain_Click);
            // 
            // btnLec_ConstraintsManageBack
            // 
            this.btnLec_ConstraintsManageBack.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLec_ConstraintsManageBack.Location = new System.Drawing.Point(6, 67);
            this.btnLec_ConstraintsManageBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnLec_ConstraintsManageBack.Name = "btnLec_ConstraintsManageBack";
            this.btnLec_ConstraintsManageBack.Size = new System.Drawing.Size(210, 23);
            this.btnLec_ConstraintsManageBack.TabIndex = 7;
            this.btnLec_ConstraintsManageBack.Text = "חזור";
            this.btnLec_ConstraintsManageBack.UseVisualStyleBackColor = false;
            this.btnLec_ConstraintsManageBack.Click += new System.EventHandler(this.btnLec_Back_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(137, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ניהול אילוצים";
            // 
            // btnLecWeeklyConstraintsSystem
            // 
            this.btnLecWeeklyConstraintsSystem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLecWeeklyConstraintsSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLecWeeklyConstraintsSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecWeeklyConstraintsSystem.Location = new System.Drawing.Point(6, 15);
            this.btnLecWeeklyConstraintsSystem.Name = "btnLecWeeklyConstraintsSystem";
            this.btnLecWeeklyConstraintsSystem.Size = new System.Drawing.Size(210, 23);
            this.btnLecWeeklyConstraintsSystem.TabIndex = 5;
            this.btnLecWeeklyConstraintsSystem.Text = "מערכת אילוצים שבועית";
            this.btnLecWeeklyConstraintsSystem.UseVisualStyleBackColor = false;
            this.btnLecWeeklyConstraintsSystem.Click += new System.EventHandler(this.btnLecWeeklyConstraintsSystem_Click);
            // 
            // pnlLecturerMain
            // 
            this.pnlLecturerMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLecturerMain.Controls.Add(this.label3);
            this.pnlLecturerMain.Controls.Add(this.btnLec_ManageConstraints);
            this.pnlLecturerMain.Controls.Add(this.btnLec_ManageCourses);
            this.pnlLecturerMain.Location = new System.Drawing.Point(718, 5);
            this.pnlLecturerMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLecturerMain.Name = "pnlLecturerMain";
            this.pnlLecturerMain.Size = new System.Drawing.Size(220, 70);
            this.pnlLecturerMain.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "תפריט ראשי";
            // 
            // btnLec_ManageConstraints
            // 
            this.btnLec_ManageConstraints.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLec_ManageConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLec_ManageConstraints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLec_ManageConstraints.Location = new System.Drawing.Point(6, 15);
            this.btnLec_ManageConstraints.Name = "btnLec_ManageConstraints";
            this.btnLec_ManageConstraints.Size = new System.Drawing.Size(210, 23);
            this.btnLec_ManageConstraints.TabIndex = 5;
            this.btnLec_ManageConstraints.Text = "ניהול אילוצים";
            this.btnLec_ManageConstraints.UseVisualStyleBackColor = false;
            this.btnLec_ManageConstraints.Click += new System.EventHandler(this.btnLec_ManageConstraints_Click);
            // 
            // btnLec_ManageCourses
            // 
            this.btnLec_ManageCourses.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLec_ManageCourses.Location = new System.Drawing.Point(6, 41);
            this.btnLec_ManageCourses.Name = "btnLec_ManageCourses";
            this.btnLec_ManageCourses.Size = new System.Drawing.Size(210, 23);
            this.btnLec_ManageCourses.TabIndex = 6;
            this.btnLec_ManageCourses.Text = "ניהול קורסים";
            this.btnLec_ManageCourses.UseVisualStyleBackColor = false;
            this.btnLec_ManageCourses.Click += new System.EventHandler(this.btnLec_ManageCourses_Click);
            // 
            // tabStudent
            // 
            this.tabStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabStudent.Controls.Add(this.panel2);
            this.tabStudent.Controls.Add(this.panel1);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(941, 370);
            this.tabStudent.TabIndex = 5;
            this.tabStudent.Text = "סטודנט";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(719, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 366);
            this.panel2.TabIndex = 21;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.Menu;
            this.button22.Location = new System.Drawing.Point(7, 178);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(210, 23);
            this.button22.TabIndex = 12;
            this.button22.Text = "הצגת מערכת שעות";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.Menu;
            this.button21.Location = new System.Drawing.Point(7, 149);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(210, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "בניית מערכת שעות";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Menu;
            this.button16.Location = new System.Drawing.Point(6, 119);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(210, 23);
            this.button16.TabIndex = 10;
            this.button16.Text = "דירוג מרצים";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Menu;
            this.button15.Location = new System.Drawing.Point(6, 93);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(210, 23);
            this.button15.TabIndex = 9;
            this.button15.Text = "רישום לקורס בחירה";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(150, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "תפריט ראשי";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(6, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "הצגת קורסים";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(6, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "מידע על קורס\\סטודנטים הרשומים";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(6, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "מערכת שעות יומית";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 372);
            this.panel1.TabIndex = 20;
            // 
            // tabHead
            // 
            this.tabHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHead.Controls.Add(this.pnlHead_ManageLectuers);
            this.tabHead.Controls.Add(this.pnlHead_ManageStudents);
            this.tabHead.Controls.Add(this.pnlHeadMain);
            this.tabHead.Controls.Add(this.pnlHead);
            this.tabHead.Location = new System.Drawing.Point(4, 22);
            this.tabHead.Name = "tabHead";
            this.tabHead.Padding = new System.Windows.Forms.Padding(2);
            this.tabHead.Size = new System.Drawing.Size(941, 370);
            this.tabHead.TabIndex = 4;
            this.tabHead.Text = "ראש מחלקה";
            // 
            // pnlHead_ManageLectuers
            // 
            this.pnlHead_ManageLectuers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlHead_ManageLectuers.Controls.Add(this.btnHead_ManageConstraints);
            this.pnlHead_ManageLectuers.Controls.Add(this.btnHead_ManagerLecturers_Back);
            this.pnlHead_ManageLectuers.Controls.Add(this.label12);
            this.pnlHead_ManageLectuers.Controls.Add(this.btnHead_LecturersList);
            this.pnlHead_ManageLectuers.Controls.Add(this.btnHead_AddLecturer);
            this.pnlHead_ManageLectuers.Location = new System.Drawing.Point(717, 193);
            this.pnlHead_ManageLectuers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHead_ManageLectuers.Name = "pnlHead_ManageLectuers";
            this.pnlHead_ManageLectuers.Size = new System.Drawing.Size(220, 144);
            this.pnlHead_ManageLectuers.TabIndex = 13;
            this.pnlHead_ManageLectuers.Visible = false;
            // 
            // btnHead_ManageConstraints
            // 
            this.btnHead_ManageConstraints.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManageConstraints.Location = new System.Drawing.Point(5, 81);
            this.btnHead_ManageConstraints.Name = "btnHead_ManageConstraints";
            this.btnHead_ManageConstraints.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManageConstraints.TabIndex = 8;
            this.btnHead_ManageConstraints.Text = "ניהול אילוצים";
            this.btnHead_ManageConstraints.UseVisualStyleBackColor = false;
            this.btnHead_ManageConstraints.Click += new System.EventHandler(this.btnHead_ManageConstraints_Click);
            // 
            // btnHead_ManagerLecturers_Back
            // 
            this.btnHead_ManagerLecturers_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManagerLecturers_Back.Location = new System.Drawing.Point(5, 110);
            this.btnHead_ManagerLecturers_Back.Name = "btnHead_ManagerLecturers_Back";
            this.btnHead_ManagerLecturers_Back.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManagerLecturers_Back.TabIndex = 7;
            this.btnHead_ManagerLecturers_Back.Text = "חזור";
            this.btnHead_ManagerLecturers_Back.UseVisualStyleBackColor = false;
            this.btnHead_ManagerLecturers_Back.Click += new System.EventHandler(this.btnHead_ManagerLecturers_Back_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(149, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "ניהול מרצים";
            // 
            // btnHead_LecturersList
            // 
            this.btnHead_LecturersList.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_LecturersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHead_LecturersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHead_LecturersList.Location = new System.Drawing.Point(5, 22);
            this.btnHead_LecturersList.Name = "btnHead_LecturersList";
            this.btnHead_LecturersList.Size = new System.Drawing.Size(210, 23);
            this.btnHead_LecturersList.TabIndex = 5;
            this.btnHead_LecturersList.Text = "רשימת מרצים";
            this.btnHead_LecturersList.UseVisualStyleBackColor = false;
            this.btnHead_LecturersList.Click += new System.EventHandler(this.btnHead_LecturersList_Click);
            // 
            // btnHead_AddLecturer
            // 
            this.btnHead_AddLecturer.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_AddLecturer.Location = new System.Drawing.Point(5, 51);
            this.btnHead_AddLecturer.Name = "btnHead_AddLecturer";
            this.btnHead_AddLecturer.Size = new System.Drawing.Size(210, 23);
            this.btnHead_AddLecturer.TabIndex = 6;
            this.btnHead_AddLecturer.Text = "הוספת מרצה";
            this.btnHead_AddLecturer.UseVisualStyleBackColor = false;
            this.btnHead_AddLecturer.Click += new System.EventHandler(this.btnHead_AddLecturer_Click);
            // 
            // pnlHead_ManageStudents
            // 
            this.pnlHead_ManageStudents.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlHead_ManageStudents.Controls.Add(this.btnHead_ManageStudents_Back);
            this.pnlHead_ManageStudents.Controls.Add(this.label13);
            this.pnlHead_ManageStudents.Controls.Add(this.btnHead_StudentsList);
            this.pnlHead_ManageStudents.Controls.Add(this.btnHead_FailStudents);
            this.pnlHead_ManageStudents.Location = new System.Drawing.Point(718, 170);
            this.pnlHead_ManageStudents.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHead_ManageStudents.Name = "pnlHead_ManageStudents";
            this.pnlHead_ManageStudents.Size = new System.Drawing.Size(217, 117);
            this.pnlHead_ManageStudents.TabIndex = 15;
            this.pnlHead_ManageStudents.Visible = false;
            // 
            // btnHead_ManageStudents_Back
            // 
            this.btnHead_ManageStudents_Back.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManageStudents_Back.Location = new System.Drawing.Point(4, 81);
            this.btnHead_ManageStudents_Back.Name = "btnHead_ManageStudents_Back";
            this.btnHead_ManageStudents_Back.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManageStudents_Back.TabIndex = 7;
            this.btnHead_ManageStudents_Back.Text = "חזור";
            this.btnHead_ManageStudents_Back.UseVisualStyleBackColor = false;
            this.btnHead_ManageStudents_Back.Click += new System.EventHandler(this.btnHead_ManageStudents_Back_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(128, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "ניהול סטודנטים";
            // 
            // btnHead_StudentsList
            // 
            this.btnHead_StudentsList.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_StudentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHead_StudentsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHead_StudentsList.Location = new System.Drawing.Point(5, 22);
            this.btnHead_StudentsList.Name = "btnHead_StudentsList";
            this.btnHead_StudentsList.Size = new System.Drawing.Size(210, 23);
            this.btnHead_StudentsList.TabIndex = 5;
            this.btnHead_StudentsList.Text = "רשימת סטודנטים של המחלקה";
            this.btnHead_StudentsList.UseVisualStyleBackColor = false;
            this.btnHead_StudentsList.Click += new System.EventHandler(this.btnHead_StudentsList_Click);
            // 
            // btnHead_FailStudents
            // 
            this.btnHead_FailStudents.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_FailStudents.Location = new System.Drawing.Point(5, 51);
            this.btnHead_FailStudents.Name = "btnHead_FailStudents";
            this.btnHead_FailStudents.Size = new System.Drawing.Size(210, 23);
            this.btnHead_FailStudents.TabIndex = 6;
            this.btnHead_FailStudents.Text = "סטודנטים שנכשלו בקורסים חוסמים";
            this.btnHead_FailStudents.UseVisualStyleBackColor = false;
            this.btnHead_FailStudents.Click += new System.EventHandler(this.btnHead_FailStudents_Click);
            // 
            // pnlHeadMain
            // 
            this.pnlHeadMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlHeadMain.Controls.Add(this.btnHead_ManageStudents);
            this.pnlHeadMain.Controls.Add(this.label11);
            this.pnlHeadMain.Controls.Add(this.btnHead_ManageLecturers);
            this.pnlHeadMain.Controls.Add(this.btnHead_ManageCourses);
            this.pnlHeadMain.Location = new System.Drawing.Point(718, 5);
            this.pnlHeadMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeadMain.Name = "pnlHeadMain";
            this.pnlHeadMain.Size = new System.Drawing.Size(220, 114);
            this.pnlHeadMain.TabIndex = 12;
            // 
            // btnHead_ManageStudents
            // 
            this.btnHead_ManageStudents.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManageStudents.Location = new System.Drawing.Point(4, 81);
            this.btnHead_ManageStudents.Name = "btnHead_ManageStudents";
            this.btnHead_ManageStudents.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManageStudents.TabIndex = 7;
            this.btnHead_ManageStudents.Text = "ניהול סטודנטים";
            this.btnHead_ManageStudents.UseVisualStyleBackColor = false;
            this.btnHead_ManageStudents.Click += new System.EventHandler(this.btnHead_ManageStudents_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(150, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "תפריט ראשי";
            // 
            // btnHead_ManageLecturers
            // 
            this.btnHead_ManageLecturers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManageLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHead_ManageLecturers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHead_ManageLecturers.Location = new System.Drawing.Point(5, 22);
            this.btnHead_ManageLecturers.Name = "btnHead_ManageLecturers";
            this.btnHead_ManageLecturers.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManageLecturers.TabIndex = 5;
            this.btnHead_ManageLecturers.Text = "ניהול מרצים";
            this.btnHead_ManageLecturers.UseVisualStyleBackColor = false;
            this.btnHead_ManageLecturers.Click += new System.EventHandler(this.btnHead_ManageLecturers_Click);
            // 
            // btnHead_ManageCourses
            // 
            this.btnHead_ManageCourses.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHead_ManageCourses.Location = new System.Drawing.Point(5, 51);
            this.btnHead_ManageCourses.Name = "btnHead_ManageCourses";
            this.btnHead_ManageCourses.Size = new System.Drawing.Size(210, 23);
            this.btnHead_ManageCourses.TabIndex = 6;
            this.btnHead_ManageCourses.Text = "ניהול קורסים למחלקה";
            this.btnHead_ManageCourses.UseVisualStyleBackColor = false;
            this.btnHead_ManageCourses.Click += new System.EventHandler(this.btnHead_ManageCourses_Click);
            // 
            // pnlHead
            // 
            this.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(714, 372);
            this.pnlHead.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(197, 425);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "שם המשתמש";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 442);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ניהול מערכת שעות";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSecretary.ResumeLayout(false);
            this.pnlSecretary_ManageStudent.ResumeLayout(false);
            this.pnlSecretary_ManageStudent.PerformLayout();
            this.pnlSecretary_ManageCoursesBySyallbus.ResumeLayout(false);
            this.pnlSecretary_ManageCoursesBySyallbus.PerformLayout();
            this.pnlSecretary_ManageLecturers.ResumeLayout(false);
            this.pnlSecretary_ManageLecturers.PerformLayout();
            this.pnlSecretary_ManageClasses.ResumeLayout(false);
            this.pnlSecretary_ManageClasses.PerformLayout();
            this.pnlSecretryMain.ResumeLayout(false);
            this.pnlSecretryMain.PerformLayout();
            this.tabLogistic.ResumeLayout(false);
            this.pnlLogisticManageClasseRequest.ResumeLayout(false);
            this.pnlLogisticManageClasseRequest.PerformLayout();
            this.pnlLogisticManageClasses.ResumeLayout(false);
            this.pnlLogisticManageClasses.PerformLayout();
            this.pnlLogisticMain.ResumeLayout(false);
            this.pnlLogisticMain.PerformLayout();
            this.tabLecturer.ResumeLayout(false);
            this.pnlLecCoursesManagment.ResumeLayout(false);
            this.pnlLecCoursesManagment.PerformLayout();
            this.pnlLecManageConstraints.ResumeLayout(false);
            this.pnlLecManageConstraints.PerformLayout();
            this.pnlLecturerMain.ResumeLayout(false);
            this.pnlLecturerMain.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabHead.ResumeLayout(false);
            this.pnlHead_ManageLectuers.ResumeLayout(false);
            this.pnlHead_ManageLectuers.PerformLayout();
            this.pnlHead_ManageStudents.ResumeLayout(false);
            this.pnlHead_ManageStudents.PerformLayout();
            this.pnlHeadMain.ResumeLayout(false);
            this.pnlHeadMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSecretary;
        private System.Windows.Forms.TabPage tabLogistic;
        private System.Windows.Forms.TabPage tabLecturer;
        private System.Windows.Forms.TabPage tabHead;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.ToolStripMenuItem משתמשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem קובץToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הצגפרטיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עזרהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אודותToolStripMenuItem;
        private System.Windows.Forms.Button btnSecretary_ManagerClasses;
        private System.Windows.Forms.Button btnSecretary_ManageLecturers;
        private System.Windows.Forms.Button btnSecretary_ManagerCoursesBySyallbus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSecretryMain;
        private System.Windows.Forms.Panel pnlLogisticMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogisticManager_ManageClassrooms;
        private System.Windows.Forms.Button btnLogisticManager_ManageSecretaryRequest;
        private System.Windows.Forms.Panel pnlLecturerMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLec_ManageConstraints;
        private System.Windows.Forms.Button btnLec_ManageCourses;
        private System.Windows.Forms.Panel pnlSecretary_ManageLecturers;
        private System.Windows.Forms.Button btnSecretary_Lecturers_Back;
        private System.Windows.Forms.Button btnSecretary_AddLecturer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSecretary_LecturersList;
        private System.Windows.Forms.Panel pnlSecretary_ManageCoursesBySyallbus;
        private System.Windows.Forms.Button btnSecretary_CoursesBySyllabus_Back;
        private System.Windows.Forms.Button btnSecretary_CoursesBySyllabus_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSecretary_CoursesBySyllabus_List;
        private System.Windows.Forms.Panel pnlSecretary_ManageClasses;
        private System.Windows.Forms.Button btnSecretary_ClassesManager_Back;
        private System.Windows.Forms.Button btnSecretary_ClassRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSecretry_AssignedClasses;
        private System.Windows.Forms.Panel pnlLogisticManageClasses;
        private System.Windows.Forms.Button btnLogisticManager_Back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLogisticManager_ClassroomsList;
        private System.Windows.Forms.Button btnLogisticManager_AddClassroom;
        private System.Windows.Forms.Panel pnlLecManageConstraints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLecWeeklyConstraintsSystem;
        private System.Windows.Forms.Panel pnlLecCoursesManagment;
        private System.Windows.Forms.Button btnLecCouresesManage_Back;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLec_ConstraintsManageBack;
        private System.Windows.Forms.Panel pnlHeadMain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHead_ManageLecturers;
        private System.Windows.Forms.Button btnHead_ManageCourses;
        private System.Windows.Forms.Button btnHead_ManageStudents;
        private System.Windows.Forms.Panel pnlSecretary;
        private System.Windows.Forms.Panel pnlLogisticManager;
        private Panel pnlHead;
        private Panel pnlHead_ManageLectuers;
        private Button btnHead_ManageConstraints;
        private Button btnHead_ManagerLecturers_Back;
        private Label label12;
        private Button btnHead_LecturersList;
        private Button btnHead_AddLecturer;
        private Panel pnlHead_ManageStudents;
        private Button btnHead_ManageStudents_Back;
        private Label label13;
        private Button btnHead_StudentsList;
        private Button btnHead_FailStudents;
        private Panel pnlLogisticManageClasseRequest;
        private Button btnLogisticManager_ClassRequest_Back;
        private Label label14;
        private Button btnLogisticManager_ClassroomRequestList;
        private Button btnLecAddContrain;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
        private Panel pnlSecretary_ManageStudent;
        private Button button5;
        private Button button6;
        private Label label15;
        private Panel panel7;
        private Button button7;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button13;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button17;
        private Button button19;
        private Button button20;
        private Button button22;
        private Button button21;
        private Button button23;
        private Panel pnlLecturer;
        private ToolStripMenuItem משתמשToolStripMenuItem1;
        private ToolStripMenuItem התנתקToolStripMenuItem1;
        private ToolStripMenuItem התחברלחשבוןFacebookToolStripMenuItem;
        private ToolStripMenuItem הוספתמשתמשלמערכתToolStripMenuItem;
        private ToolStripMenuItem הצגאתכלהמשתמשיםToolStripMenuItem;
    }
}

