namespace Bs_Pro14
{
    partial class frmShowPersons
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
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AllowUserToResizeColumns = false;
            this.dgvPersons.AllowUserToResizeRows = false;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDelete,
            this.clmEdit,
            this.clmID,
            this.clmFirstName,
            this.clmLastName,
            this.clmPhone});
            this.dgvPersons.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPersons.Location = new System.Drawing.Point(-1, -1);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPersons.Size = new System.Drawing.Size(500, 394);
            this.dgvPersons.TabIndex = 0;
            this.dgvPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellContentClick);
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDelete.Width = 50;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 50;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "תעודת זהות";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "שם פרטי";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "שם משפחה";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "טלפון";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            // 
            // frmShowPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 392);
            this.Controls.Add(this.dgvPersons);
            this.MaximizeBox = false;
            this.Name = "frmShowPersons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רשימת משתמשים";
            this.Load += new System.EventHandler(this.frmShowPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
    }
}