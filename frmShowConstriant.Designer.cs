namespace Bs_Pro14
{
    partial class frmShowConstriant
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
            this.dgvConstriants = new System.Windows.Forms.DataGridView();
            this.clmdel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstriants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConstriants
            // 
            this.dgvConstriants.AllowUserToAddRows = false;
            this.dgvConstriants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstriants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmdel,
            this.day,
            this.semesterid,
            this.start,
            this.end,
            this.status});
            this.dgvConstriants.Location = new System.Drawing.Point(21, -1);
            this.dgvConstriants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConstriants.Name = "dgvConstriants";
            this.dgvConstriants.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvConstriants.RowHeadersVisible = false;
            this.dgvConstriants.RowTemplate.Height = 24;
            this.dgvConstriants.Size = new System.Drawing.Size(605, 371);
            this.dgvConstriants.TabIndex = 0;
            this.dgvConstriants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConstriants_CellContentClick);
            // 
            // clmdel
            // 
            this.clmdel.HeaderText = " ";
            this.clmdel.Name = "clmdel";
            // 
            // day
            // 
            this.day.HeaderText = "יום";
            this.day.Name = "day";
            // 
            // semesterid
            // 
            this.semesterid.HeaderText = "סמסטר";
            this.semesterid.Name = "semesterid";
            // 
            // start
            // 
            this.start.HeaderText = "התחלה";
            this.start.Name = "start";
            // 
            // end
            // 
            this.end.HeaderText = "סיום";
            this.end.Name = "end";
            // 
            // status
            // 
            this.status.HeaderText = "מצב הבקשה";
            this.status.Name = "status";
            // 
            // frmShowConstriant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(625, 440);
            this.Controls.Add(this.dgvConstriants);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShowConstriant";
            this.Text = "frmShowConstriant";
            this.Load += new System.EventHandler(this.frmShowConstriant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstriants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConstriants;
        private System.Windows.Forms.DataGridViewButtonColumn clmdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterid;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}