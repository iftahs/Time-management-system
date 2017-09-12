namespace Bs_Pro14
{
    partial class frmAcceptClassRoomRequest
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
            this.dgvClassRoomsRequestAccept = new System.Windows.Forms.DataGridView();
            this.clmChoose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoomsRequestAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassRoomsRequestAccept
            // 
            this.dgvClassRoomsRequestAccept.AllowUserToAddRows = false;
            this.dgvClassRoomsRequestAccept.AllowUserToDeleteRows = false;
            this.dgvClassRoomsRequestAccept.AllowUserToResizeColumns = false;
            this.dgvClassRoomsRequestAccept.AllowUserToResizeRows = false;
            this.dgvClassRoomsRequestAccept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClassRoomsRequestAccept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassRoomsRequestAccept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChoose,
            this.clmClassRoomId,
            this.clmClassNumber,
            this.clmBuilding,
            this.clmSits,
            this.clmLab,
            this.clmProjector});
            this.dgvClassRoomsRequestAccept.Location = new System.Drawing.Point(0, -1);
            this.dgvClassRoomsRequestAccept.Name = "dgvClassRoomsRequestAccept";
            this.dgvClassRoomsRequestAccept.ReadOnly = true;
            this.dgvClassRoomsRequestAccept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClassRoomsRequestAccept.RowHeadersVisible = false;
            this.dgvClassRoomsRequestAccept.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClassRoomsRequestAccept.Size = new System.Drawing.Size(523, 394);
            this.dgvClassRoomsRequestAccept.TabIndex = 1;
            this.dgvClassRoomsRequestAccept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassRoomsRequestAccept_CellContentClick);
            // 
            // clmChoose
            // 
            this.clmChoose.HeaderText = "";
            this.clmChoose.Name = "clmChoose";
            this.clmChoose.ReadOnly = true;
            this.clmChoose.Text = "בחר";
            this.clmChoose.Width = 50;
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "מס\"ד";
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
            this.clmClassRoomId.Width = 50;
            // 
            // clmClassNumber
            // 
            this.clmClassNumber.HeaderText = "כיתה";
            this.clmClassNumber.Name = "clmClassNumber";
            this.clmClassNumber.ReadOnly = true;
            // 
            // clmBuilding
            // 
            this.clmBuilding.HeaderText = "בניין";
            this.clmBuilding.Name = "clmBuilding";
            this.clmBuilding.ReadOnly = true;
            // 
            // clmSits
            // 
            this.clmSits.HeaderText = "מס\' מושבים";
            this.clmSits.Name = "clmSits";
            this.clmSits.ReadOnly = true;
            // 
            // clmLab
            // 
            this.clmLab.HeaderText = "מעבדה";
            this.clmLab.Name = "clmLab";
            this.clmLab.ReadOnly = true;
            this.clmLab.Width = 50;
            // 
            // clmProjector
            // 
            this.clmProjector.HeaderText = "מקרן";
            this.clmProjector.Name = "clmProjector";
            this.clmProjector.ReadOnly = true;
            this.clmProjector.Width = 50;
            // 
            // frmAcceptClassRoomRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(503, 393);
            this.Controls.Add(this.dgvClassRoomsRequestAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAcceptClassRoomRequest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כיתות פנויות ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAcceptClassRoomRequest_FormClosed);
            this.Load += new System.EventHandler(this.frmAcceptClassRoomRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoomsRequestAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassRoomsRequestAccept;
        private System.Windows.Forms.DataGridViewButtonColumn clmChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjector;
    }
}