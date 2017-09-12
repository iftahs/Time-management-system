namespace Bs_Pro14
{
    partial class frmAddLesson
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClassRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.btnReselect = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "יום:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "הוספת הרצאה לקורס";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(120, 40);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(129, 21);
            this.cmbDay.TabIndex = 2;
            this.cmbDay.Text = "בחר";
            this.cmbDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDay_KeyPress);
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Location = new System.Drawing.Point(120, 80);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(60, 21);
            this.cmbStartMinute.TabIndex = 4;
            this.cmbStartMinute.Text = "בחר";
            this.cmbStartMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStartMinute_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "שעת התחלה:";
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Location = new System.Drawing.Point(120, 120);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(60, 21);
            this.cmbEndMinute.TabIndex = 6;
            this.cmbEndMinute.Text = "בחר";
            this.cmbEndMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEndMinute_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "שעת סיום:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 160);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(234, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "הצג מרצים וכיתות פנויים";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.Enabled = false;
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(120, 206);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(129, 21);
            this.cmbLecturer.TabIndex = 9;
            this.cmbLecturer.Text = "בחר";
            this.cmbLecturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLecturer_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "מרצה:";
            // 
            // cmbClassRoom
            // 
            this.cmbClassRoom.Enabled = false;
            this.cmbClassRoom.FormattingEnabled = true;
            this.cmbClassRoom.Location = new System.Drawing.Point(120, 248);
            this.cmbClassRoom.Name = "cmbClassRoom";
            this.cmbClassRoom.Size = new System.Drawing.Size(129, 21);
            this.cmbClassRoom.TabIndex = 11;
            this.cmbClassRoom.Text = "בחר";
            this.cmbClassRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClassRoom_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "כיתה:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "נקה";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(174, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(189, 80);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(60, 21);
            this.cmbStartHour.TabIndex = 15;
            this.cmbStartHour.Text = "בחר";
            this.cmbStartHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStartHour_KeyPress);
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(189, 120);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(60, 21);
            this.cmbEndHour.TabIndex = 16;
            this.cmbEndHour.Text = "בחר";
            this.cmbEndHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEndHour_KeyPress);
            // 
            // btnReselect
            // 
            this.btnReselect.Location = new System.Drawing.Point(15, 160);
            this.btnReselect.Name = "btnReselect";
            this.btnReselect.Size = new System.Drawing.Size(234, 23);
            this.btnReselect.TabIndex = 17;
            this.btnReselect.Text = "בחר זמן אחר";
            this.btnReselect.UseVisualStyleBackColor = true;
            this.btnReselect.Visible = false;
            this.btnReselect.Click += new System.EventHandler(this.btnReselect_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(261, 334);
            this.Controls.Add(this.btnReselect);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbClassRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbEndMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddLesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת הרצאה לקורס";
            this.Load += new System.EventHandler(this.frmAddLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClassRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.Button btnReselect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}