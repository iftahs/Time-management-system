namespace Bs_Pro14
{
    partial class frmShowClassRequest
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
            this.dgvClassRoomRequest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbApproveState1 = new System.Windows.Forms.ComboBox();
            this.dgvAcceptedClassroomRequest = new System.Windows.Forms.DataGridView();
            this.clmClassroomRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestedSits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassroomDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmClassroomLabReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmClassroomProjReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmIsApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestApproved1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmRequestReject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmClassroomRequestId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoomRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptedClassroomRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassRoomRequest
            // 
            this.dgvClassRoomRequest.AllowUserToAddRows = false;
            this.dgvClassRoomRequest.AllowUserToDeleteRows = false;
            this.dgvClassRoomRequest.AllowUserToResizeColumns = false;
            this.dgvClassRoomRequest.AllowUserToResizeRows = false;
            this.dgvClassRoomRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClassRoomRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassRoomRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassroomRequestId,
            this.clmRequestedSits,
            this.clmSemester,
            this.clmClassroomDay,
            this.clmStartHour,
            this.clmEndHour,
            this.ClmClassroomLabReq,
            this.ClmClassroomProjReq,
            this.clmIsApproved,
            this.ClmIsApprovedBy});
            this.dgvClassRoomRequest.Location = new System.Drawing.Point(-1, 37);
            this.dgvClassRoomRequest.Name = "dgvClassRoomRequest";
            this.dgvClassRoomRequest.ReadOnly = true;
            this.dgvClassRoomRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClassRoomRequest.RowHeadersVisible = false;
            this.dgvClassRoomRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClassRoomRequest.Size = new System.Drawing.Size(705, 420);
            this.dgvClassRoomRequest.TabIndex = 1;
            this.dgvClassRoomRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassRoomRequest_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "מצב טיפול:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbApproveState1
            // 
            this.cmbApproveState1.FormattingEnabled = true;
            this.cmbApproveState1.Items.AddRange(new object[] {
            "טופל",
            "לא טופל"});
            this.cmbApproveState1.Location = new System.Drawing.Point(83, 10);
            this.cmbApproveState1.Name = "cmbApproveState1";
            this.cmbApproveState1.Size = new System.Drawing.Size(121, 21);
            this.cmbApproveState1.TabIndex = 3;
            this.cmbApproveState1.Text = "בחר מצב טיפול";
            this.cmbApproveState1.SelectedIndexChanged += new System.EventHandler(this.cmbApproveState1_SelectedIndexChanged);
            // 
            // dgvAcceptedClassroomRequest
            // 
            this.dgvAcceptedClassroomRequest.AllowUserToAddRows = false;
            this.dgvAcceptedClassroomRequest.AllowUserToDeleteRows = false;
            this.dgvAcceptedClassroomRequest.AllowUserToResizeColumns = false;
            this.dgvAcceptedClassroomRequest.AllowUserToResizeRows = false;
            this.dgvAcceptedClassroomRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAcceptedClassroomRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcceptedClassroomRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRequestApproved1,
            this.clmRequestReject,
            this.clmClassroomRequestId1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvAcceptedClassroomRequest.Location = new System.Drawing.Point(-1, 74);
            this.dgvAcceptedClassroomRequest.Name = "dgvAcceptedClassroomRequest";
            this.dgvAcceptedClassroomRequest.ReadOnly = true;
            this.dgvAcceptedClassroomRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAcceptedClassroomRequest.RowHeadersVisible = false;
            this.dgvAcceptedClassroomRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAcceptedClassroomRequest.Size = new System.Drawing.Size(705, 420);
            this.dgvAcceptedClassroomRequest.TabIndex = 4;
            this.dgvAcceptedClassroomRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcceptedClassroomRequest_CellContentClick);
            // 
            // clmClassroomRequestId
            // 
            this.clmClassroomRequestId.HeaderText = "מס\"ד";
            this.clmClassroomRequestId.Name = "clmClassroomRequestId";
            this.clmClassroomRequestId.ReadOnly = true;
            this.clmClassroomRequestId.Width = 50;
            // 
            // clmRequestedSits
            // 
            this.clmRequestedSits.HeaderText = "מס\' מקומות";
            this.clmRequestedSits.Name = "clmRequestedSits";
            this.clmRequestedSits.ReadOnly = true;
            // 
            // clmSemester
            // 
            this.clmSemester.HeaderText = "סמסטר";
            this.clmSemester.Name = "clmSemester";
            this.clmSemester.ReadOnly = true;
            this.clmSemester.Width = 75;
            // 
            // clmClassroomDay
            // 
            this.clmClassroomDay.HeaderText = "יום";
            this.clmClassroomDay.Name = "clmClassroomDay";
            this.clmClassroomDay.ReadOnly = true;
            this.clmClassroomDay.Width = 45;
            // 
            // clmStartHour
            // 
            this.clmStartHour.HeaderText = "שעת התחלה";
            this.clmStartHour.Name = "clmStartHour";
            this.clmStartHour.ReadOnly = true;
            // 
            // clmEndHour
            // 
            this.clmEndHour.HeaderText = "שעת סיום";
            this.clmEndHour.Name = "clmEndHour";
            this.clmEndHour.ReadOnly = true;
            // 
            // ClmClassroomLabReq
            // 
            this.ClmClassroomLabReq.HeaderText = "מעבדה";
            this.ClmClassroomLabReq.Name = "ClmClassroomLabReq";
            this.ClmClassroomLabReq.ReadOnly = true;
            this.ClmClassroomLabReq.Width = 50;
            // 
            // ClmClassroomProjReq
            // 
            this.ClmClassroomProjReq.HeaderText = "מקרן";
            this.ClmClassroomProjReq.Name = "ClmClassroomProjReq";
            this.ClmClassroomProjReq.ReadOnly = true;
            this.ClmClassroomProjReq.Width = 45;
            // 
            // clmIsApproved
            // 
            this.clmIsApproved.HeaderText = "אושר";
            this.clmIsApproved.Name = "clmIsApproved";
            this.clmIsApproved.ReadOnly = true;
            this.clmIsApproved.Width = 40;
            // 
            // ClmIsApprovedBy
            // 
            this.ClmIsApprovedBy.HeaderText = "טופל ע\"י";
            this.ClmIsApprovedBy.Name = "ClmIsApprovedBy";
            this.ClmIsApprovedBy.ReadOnly = true;
            // 
            // clmRequestApproved1
            // 
            this.clmRequestApproved1.HeaderText = "";
            this.clmRequestApproved1.Name = "clmRequestApproved1";
            this.clmRequestApproved1.ReadOnly = true;
            this.clmRequestApproved1.Width = 50;
            // 
            // clmRequestReject
            // 
            this.clmRequestReject.HeaderText = "";
            this.clmRequestReject.Name = "clmRequestReject";
            this.clmRequestReject.ReadOnly = true;
            this.clmRequestReject.Width = 50;
            // 
            // clmClassroomRequestId1
            // 
            this.clmClassroomRequestId1.HeaderText = "מס\"ד";
            this.clmClassroomRequestId1.Name = "clmClassroomRequestId1";
            this.clmClassroomRequestId1.ReadOnly = true;
            this.clmClassroomRequestId1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "מס\' מקומות";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "סמסטר";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "יום";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "שעת התחלה";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "שעת סיום";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "מעבדה";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "מקרן";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // frmShowClassRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.dgvAcceptedClassroomRequest);
            this.Controls.Add(this.cmbApproveState1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClassRoomRequest);
            this.Name = "frmShowClassRequest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רשימת בקשות מזכירה";
            this.Load += new System.EventHandler(this.frmShowClassRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoomRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptedClassroomRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassRoomRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbApproveState1;
        private System.Windows.Forms.DataGridView dgvAcceptedClassroomRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassroomRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestedSits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassroomDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmClassroomLabReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmClassroomProjReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIsApprovedBy;
        private System.Windows.Forms.DataGridViewButtonColumn clmRequestApproved1;
        private System.Windows.Forms.DataGridViewButtonColumn clmRequestReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassroomRequestId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}