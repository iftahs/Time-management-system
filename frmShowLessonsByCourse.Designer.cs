namespace Bs_Pro14
{
    partial class frmShowLessonsByCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLessonsByCourse));
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeekDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            resources.ApplyResources(this.lblCourseName, "lblCourseName");
            this.lblCourseName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCourseName.Name = "lblCourseName";
            // 
            // btnAddLesson
            // 
            resources.ApplyResources(this.btnAddLesson, "btnAddLesson");
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // dgvLessons
            // 
            this.dgvLessons.AllowUserToAddRows = false;
            this.dgvLessons.AllowUserToDeleteRows = false;
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDelete,
            this.clmID,
            this.clmWeekDay,
            this.clmStart,
            this.clmEnd,
            this.clmLecturer,
            this.clmClassRoom});
            resources.ApplyResources(this.dgvLessons, "dgvLessons");
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            this.dgvLessons.RowHeadersVisible = false;
            this.dgvLessons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_CellContentClick);
            // 
            // clmDelete
            // 
            resources.ApplyResources(this.clmDelete, "clmDelete");
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // clmID
            // 
            resources.ApplyResources(this.clmID, "clmID");
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmWeekDay
            // 
            resources.ApplyResources(this.clmWeekDay, "clmWeekDay");
            this.clmWeekDay.Name = "clmWeekDay";
            this.clmWeekDay.ReadOnly = true;
            // 
            // clmStart
            // 
            resources.ApplyResources(this.clmStart, "clmStart");
            this.clmStart.Name = "clmStart";
            this.clmStart.ReadOnly = true;
            // 
            // clmEnd
            // 
            resources.ApplyResources(this.clmEnd, "clmEnd");
            this.clmEnd.Name = "clmEnd";
            this.clmEnd.ReadOnly = true;
            // 
            // clmLecturer
            // 
            resources.ApplyResources(this.clmLecturer, "clmLecturer");
            this.clmLecturer.Name = "clmLecturer";
            this.clmLecturer.ReadOnly = true;
            // 
            // clmClassRoom
            // 
            resources.ApplyResources(this.clmClassRoom, "clmClassRoom");
            this.clmClassRoom.Name = "clmClassRoom";
            this.clmClassRoom.ReadOnly = true;
            // 
            // frmShowLessonsByCourse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.lblCourseName);
            this.Name = "frmShowLessonsByCourse";
            this.Load += new System.EventHandler(this.frmShowLessonsByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeekDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoom;
    }
}