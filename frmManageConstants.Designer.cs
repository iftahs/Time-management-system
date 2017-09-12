namespace Bs_Pro14
{
    partial class frmManageConstants
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
            this.dgvManageC = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.יום = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageC
            // 
            this.dgvManageC.AllowUserToAddRows = false;
            this.dgvManageC.AllowUserToDeleteRows = false;
            this.dgvManageC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManageC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column1,
            this.יום,
            this.Column2,
            this.Column3});
            this.dgvManageC.Location = new System.Drawing.Point(-1, -2);
            this.dgvManageC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvManageC.Name = "dgvManageC";
            this.dgvManageC.ReadOnly = true;
            this.dgvManageC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvManageC.RowHeadersVisible = false;
            this.dgvManageC.RowTemplate.Height = 24;
            this.dgvManageC.Size = new System.Drawing.Size(609, 303);
            this.dgvManageC.TabIndex = 0;
            this.dgvManageC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageC_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "אישור";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "דחיה";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ת\"ז מרצה";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // יום
            // 
            this.יום.HeaderText = "יום";
            this.יום.Name = "יום";
            this.יום.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "שעת התחלה";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "שעת סיום";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmManageConstants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 302);
            this.Controls.Add(this.dgvManageC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageConstants";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmManageConstants";
            this.Load += new System.EventHandler(this.frmManageConstants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageC;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn יום;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}