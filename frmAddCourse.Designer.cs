namespace Bs_Pro14
{
    partial class frmAddCourse
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
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnCancelAddClassroom = new System.Windows.Forms.Button();
            this.btnCleanAddClassroom = new System.Windows.Forms.Button();
            this.btnAddClassroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAddClassroom = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCredits = new System.Windows.Forms.ComboBox();
            this.cmbBlockCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaxStudents = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSemesterId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPractice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(145, 135);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(64, 24);
            this.cmbYear.TabIndex = 58;
            this.cmbYear.Text = "בחר";
            this.cmbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYear_KeyPress);
            // 
            // btnCancelAddClassroom
            // 
            this.btnCancelAddClassroom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddClassroom.Location = new System.Drawing.Point(16, 390);
            this.btnCancelAddClassroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelAddClassroom.Name = "btnCancelAddClassroom";
            this.btnCancelAddClassroom.Size = new System.Drawing.Size(100, 28);
            this.btnCancelAddClassroom.TabIndex = 57;
            this.btnCancelAddClassroom.Text = "ביטול";
            this.btnCancelAddClassroom.UseVisualStyleBackColor = true;
            this.btnCancelAddClassroom.Click += new System.EventHandler(this.btnCancelAddClassroom_Click);
            // 
            // btnCleanAddClassroom
            // 
            this.btnCleanAddClassroom.Location = new System.Drawing.Point(179, 390);
            this.btnCleanAddClassroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCleanAddClassroom.Name = "btnCleanAddClassroom";
            this.btnCleanAddClassroom.Size = new System.Drawing.Size(100, 28);
            this.btnCleanAddClassroom.TabIndex = 56;
            this.btnCleanAddClassroom.Text = "נקה";
            this.btnCleanAddClassroom.UseVisualStyleBackColor = true;
            this.btnCleanAddClassroom.Click += new System.EventHandler(this.btnCleanAddClassroom_Click);
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Location = new System.Drawing.Point(342, 390);
            this.btnAddClassroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(100, 28);
            this.btnAddClassroom.TabIndex = 55;
            this.btnAddClassroom.Text = "הוסף";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "שנה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "נקודות זיכוי:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(145, 50);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(297, 22);
            this.txtCourseName.TabIndex = 48;
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCourseName.Location = new System.Drawing.Point(13, 54);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(68, 17);
            this.lblCourseName.TabIndex = 47;
            this.lblCourseName.Text = "שם הקורס:";
            // 
            // lblAddClassroom
            // 
            this.lblAddClassroom.AutoSize = true;
            this.lblAddClassroom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddClassroom.Location = new System.Drawing.Point(13, 9);
            this.lblAddClassroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddClassroom.Name = "lblAddClassroom";
            this.lblAddClassroom.Size = new System.Drawing.Size(75, 17);
            this.lblAddClassroom.TabIndex = 46;
            this.lblAddClassroom.Text = "הוספת קורס";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(145, 178);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(64, 24);
            this.cmbSemester.TabIndex = 60;
            this.cmbSemester.Text = "בחר";
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "סמסטר:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(145, 222);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(297, 24);
            this.cmbDepartment.TabIndex = 62;
            this.cmbDepartment.Text = "בחר";
            this.cmbDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartment_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "מחלקה:";
            // 
            // cmbCredits
            // 
            this.cmbCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCredits.FormattingEnabled = true;
            this.cmbCredits.Location = new System.Drawing.Point(145, 92);
            this.cmbCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCredits.Name = "cmbCredits";
            this.cmbCredits.Size = new System.Drawing.Size(64, 24);
            this.cmbCredits.TabIndex = 63;
            this.cmbCredits.Text = "בחר";
            this.cmbCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCredits_KeyPress);
            // 
            // cmbBlockCourse
            // 
            this.cmbBlockCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBlockCourse.FormattingEnabled = true;
            this.cmbBlockCourse.Location = new System.Drawing.Point(145, 263);
            this.cmbBlockCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBlockCourse.Name = "cmbBlockCourse";
            this.cmbBlockCourse.Size = new System.Drawing.Size(297, 24);
            this.cmbBlockCourse.TabIndex = 65;
            this.cmbBlockCourse.Text = "בחר";
            this.cmbBlockCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBlockCourse_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(13, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "קורס חוסם:";
            // 
            // cmbMaxStudents
            // 
            this.cmbMaxStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaxStudents.FormattingEnabled = true;
            this.cmbMaxStudents.Location = new System.Drawing.Point(145, 306);
            this.cmbMaxStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMaxStudents.Name = "cmbMaxStudents";
            this.cmbMaxStudents.Size = new System.Drawing.Size(64, 24);
            this.cmbMaxStudents.TabIndex = 67;
            this.cmbMaxStudents.Text = "בחר";
            this.cmbMaxStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMaxStudents_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(13, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "מקס סטודנטים:";
            // 
            // cmbSemesterId
            // 
            this.cmbSemesterId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSemesterId.FormattingEnabled = true;
            this.cmbSemesterId.Location = new System.Drawing.Point(145, 350);
            this.cmbSemesterId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSemesterId.Name = "cmbSemesterId";
            this.cmbSemesterId.Size = new System.Drawing.Size(297, 24);
            this.cmbSemesterId.TabIndex = 69;
            this.cmbSemesterId.Text = "בחר";
            this.cmbSemesterId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemesterId_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(13, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "סמסטר (תאריך):";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cbPractice
            // 
            this.cbPractice.AutoSize = true;
            this.cbPractice.Enabled = false;
            this.cbPractice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbPractice.Location = new System.Drawing.Point(458, 52);
            this.cbPractice.Name = "cbPractice";
            this.cbPractice.Size = new System.Drawing.Size(62, 21);
            this.cbPractice.TabIndex = 70;
            this.cbPractice.Text = "תרגול";
            this.cbPractice.UseVisualStyleBackColor = true;
            this.cbPractice.CheckedChanged += new System.EventHandler(this.cbPractice_CheckedChanged);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(532, 431);
            this.Controls.Add(this.cbPractice);
            this.Controls.Add(this.cmbSemesterId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMaxStudents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBlockCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCredits);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnCancelAddClassroom);
            this.Controls.Add(this.btnCleanAddClassroom);
            this.Controls.Add(this.btnAddClassroom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblAddClassroom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת קורס";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnCancelAddClassroom;
        private System.Windows.Forms.Button btnCleanAddClassroom;
        private System.Windows.Forms.Button btnAddClassroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblAddClassroom;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCredits;
        private System.Windows.Forms.ComboBox cmbBlockCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaxStudents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSemesterId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbPractice;
    }
}