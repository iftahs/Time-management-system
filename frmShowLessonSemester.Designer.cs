using Bs_Pro14.Classes;
namespace Bs_Pro14
{
    partial class frmShowLessonSemester
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
            this.ShowDataTime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvShowLesson = new System.Windows.Forms.DataGridView();
            this.clmday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowDateTime = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLesson)).BeginInit();
            this.pnlShowDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "סמסטר:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(64, 17);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(240, 21);
            this.cmbSemester.TabIndex = 3;
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            // 
            // ShowDataTime
            // 
            this.ShowDataTime.Location = new System.Drawing.Point(403, 17);
            this.ShowDataTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowDataTime.Name = "ShowDataTime";
            this.ShowDataTime.Size = new System.Drawing.Size(56, 19);
            this.ShowDataTime.TabIndex = 4;
            this.ShowDataTime.Text = "הצג";
            this.ShowDataTime.UseVisualStyleBackColor = true;
            this.ShowDataTime.Click += new System.EventHandler(this.ShowDataTime_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvShowLesson
            // 
            this.dgvShowLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowLesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmday,
            this.clmlesson,
            this.clmstart,
            this.clmend});
            this.dgvShowLesson.Location = new System.Drawing.Point(0, 0);
            this.dgvShowLesson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShowLesson.Name = "dgvShowLesson";
            this.dgvShowLesson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowLesson.RowHeadersVisible = false;
            this.dgvShowLesson.RowTemplate.Height = 24;
            this.dgvShowLesson.Size = new System.Drawing.Size(521, 301);
            this.dgvShowLesson.TabIndex = 0;
            // 
            // clmday
            // 
            this.clmday.HeaderText = "יום";
            this.clmday.Name = "clmday";
            // 
            // clmlesson
            // 
            this.clmlesson.HeaderText = "שיעור";
            this.clmlesson.Name = "clmlesson";
            // 
            // clmstart
            // 
            this.clmstart.HeaderText = "התחלה";
            this.clmstart.Name = "clmstart";
            // 
            // clmend
            // 
            this.clmend.HeaderText = "סיום";
            this.clmend.Name = "clmend";
            // 
            // pnlShowDateTime
            // 
            this.pnlShowDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlShowDateTime.Controls.Add(this.dgvShowLesson);
            this.pnlShowDateTime.Location = new System.Drawing.Point(0, 44);
            this.pnlShowDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlShowDateTime.Name = "pnlShowDateTime";
            this.pnlShowDateTime.Size = new System.Drawing.Size(521, 304);
            this.pnlShowDateTime.TabIndex = 1;
            // 
            // frmShowLessonSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(520, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowDataTime);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlShowDateTime);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShowLessonSemester";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmShowLessonSemester";
            this.Load += new System.EventHandler(this.frmShowLessonSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLesson)).EndInit();
            this.pnlShowDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button ShowDataTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvShowLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmend;
        private System.Windows.Forms.Panel pnlShowDateTime;
    }
}