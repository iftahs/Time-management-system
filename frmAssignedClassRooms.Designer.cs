namespace Bs_Pro14
{
    partial class frmAssignedClassRooms
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
            this.cmbApproveState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "סמסטר:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(63, 10);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(214, 21);
            this.cmbSemester.TabIndex = 1;
            this.cmbSemester.Text = "בחר";
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            // 
            // cmbApproveState
            // 
            this.cmbApproveState.FormattingEnabled = true;
            this.cmbApproveState.Location = new System.Drawing.Point(367, 10);
            this.cmbApproveState.Name = "cmbApproveState";
            this.cmbApproveState.Size = new System.Drawing.Size(121, 21);
            this.cmbApproveState.TabIndex = 3;
            this.cmbApproveState.Text = "בחר";
            this.cmbApproveState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbApproveState_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(294, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "מצב אישור:";
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDelete,
            this.clmRequestId,
            this.clmStartHour,
            this.clmEndTime,
            this.clmClassRoom,
            this.clmApproved,
            this.clmApprovedBy});
            this.dgvRequests.Location = new System.Drawing.Point(-1, 37);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.Size = new System.Drawing.Size(608, 419);
            this.dgvRequests.TabIndex = 4;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(504, 8);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 5;
            this.btnShowData.Text = "הצג";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "מחק";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // clmRequestId
            // 
            this.clmRequestId.HeaderText = "מספר בקשה";
            this.clmRequestId.Name = "clmRequestId";
            this.clmRequestId.ReadOnly = true;
            // 
            // clmStartHour
            // 
            this.clmStartHour.HeaderText = "שעת התחלה";
            this.clmStartHour.Name = "clmStartHour";
            this.clmStartHour.ReadOnly = true;
            this.clmStartHour.Width = 95;
            // 
            // clmEndTime
            // 
            this.clmEndTime.HeaderText = "שעת סיום";
            this.clmEndTime.Name = "clmEndTime";
            this.clmEndTime.ReadOnly = true;
            this.clmEndTime.Width = 90;
            // 
            // clmClassRoom
            // 
            this.clmClassRoom.HeaderText = "כיתה";
            this.clmClassRoom.Name = "clmClassRoom";
            this.clmClassRoom.ReadOnly = true;
            this.clmClassRoom.Width = 70;
            // 
            // clmApproved
            // 
            this.clmApproved.HeaderText = "אושר";
            this.clmApproved.Name = "clmApproved";
            this.clmApproved.ReadOnly = true;
            this.clmApproved.Width = 50;
            // 
            // clmApprovedBy
            // 
            this.clmApprovedBy.HeaderText = "אושר על ידי";
            this.clmApprovedBy.Name = "clmApprovedBy";
            this.clmApprovedBy.ReadOnly = true;
            // 
            // frmAssignedClassRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 456);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.cmbApproveState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label1);
            this.Name = "frmAssignedClassRooms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כיתות שהוקצו למחלקה";
            this.Load += new System.EventHandler(this.frmAssignedClassRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbApproveState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApprovedBy;
    }
}