namespace Bs_Pro14.Utilities
{
    partial class frmShowClassRooms
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
            this.dgvClassRooms = new System.Windows.Forms.DataGridView();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassRooms
            // 
            this.dgvClassRooms.AllowUserToAddRows = false;
            this.dgvClassRooms.AllowUserToDeleteRows = false;
            this.dgvClassRooms.AllowUserToResizeColumns = false;
            this.dgvClassRooms.AllowUserToResizeRows = false;
            this.dgvClassRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClassRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDelete,
            this.clmEdit,
            this.clmClassRoomId,
            this.clmClassNumber,
            this.clmBuilding,
            this.clmSits,
            this.clmLab,
            this.clmProjector});
            this.dgvClassRooms.Location = new System.Drawing.Point(-1, -1);
            this.dgvClassRooms.Name = "dgvClassRooms";
            this.dgvClassRooms.ReadOnly = true;
            this.dgvClassRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClassRooms.RowHeadersVisible = false;
            this.dgvClassRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClassRooms.Size = new System.Drawing.Size(523, 394);
            this.dgvClassRooms.TabIndex = 0;
            this.dgvClassRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassRooms_CellContentClick);
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 50;
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
            // frmShowClassRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 392);
            this.Controls.Add(this.dgvClassRooms);
            this.Name = "frmShowClassRooms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "";
            this.Text = "רשימת כיתות";
            this.Load += new System.EventHandler(this.frmShowClassRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassRooms;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjector;
    }
}