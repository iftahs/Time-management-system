namespace Bs_Pro14
{
    partial class frmShowCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmLessons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "סמסטר:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(62, 10);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(267, 21);
            this.cmbSemester.TabIndex = 1;
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(556, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "הצג";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDelete,
            this.clmEdit,
            this.clmLessons,
            this.clmID,
            this.clmCourseName,
            this.clmCredits,
            this.clmYear,
            this.clmSemester,
            this.clmMaxStudents});
            this.dgvCourses.Location = new System.Drawing.Point(0, 53);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.Size = new System.Drawing.Size(689, 368);
            this.dgvCourses.TabIndex = 3;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellContentClick);
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "מחיקה";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 55;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "עריכה";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 55;
            // 
            // clmLessons
            // 
            this.clmLessons.HeaderText = "שיעורים";
            this.clmLessons.Name = "clmLessons";
            this.clmLessons.ReadOnly = true;
            this.clmLessons.Width = 55;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "מס\"ד";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 50;
            // 
            // clmCourseName
            // 
            this.clmCourseName.HeaderText = "שם הקורס";
            this.clmCourseName.Name = "clmCourseName";
            this.clmCourseName.ReadOnly = true;
            this.clmCourseName.Width = 155;
            // 
            // clmCredits
            // 
            this.clmCredits.HeaderText = "נקודות זיכוי";
            this.clmCredits.Name = "clmCredits";
            this.clmCredits.ReadOnly = true;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "שנה";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Width = 50;
            // 
            // clmSemester
            // 
            this.clmSemester.HeaderText = "סמסטר";
            this.clmSemester.Name = "clmSemester";
            this.clmSemester.ReadOnly = true;
            this.clmSemester.Width = 50;
            // 
            // clmMaxStudents
            // 
            this.clmMaxStudents.HeaderText = "מקסימום סטודנטים";
            this.clmMaxStudents.Name = "clmMaxStudents";
            this.clmMaxStudents.ReadOnly = true;
            this.clmMaxStudents.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(352, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "מחלקה:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(403, 10);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.TabStop = false;
            this.cmbDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartment_KeyPress);
            // 
            // frmShowCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(689, 420);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label1);
            this.Name = "frmShowCourses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רשימת קורסים";
            this.Load += new System.EventHandler(this.frmShowCoursesSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxStudents;
    }
}