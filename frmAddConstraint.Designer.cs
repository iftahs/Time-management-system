namespace Bs_Pro14
{
    partial class frmAddConstraint
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת אילוץ חדש (ימים בהם אני יכול ללמד)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(184, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(185, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = ":";
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(200, 201);
            this.cmbEndHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(47, 24);
            this.cmbEndHour.TabIndex = 30;
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Location = new System.Drawing.Point(137, 201);
            this.cmbEndMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(47, 24);
            this.cmbEndMinute.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "שעות סיום:";
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(200, 152);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(47, 24);
            this.cmbStartHour.TabIndex = 27;
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Location = new System.Drawing.Point(137, 152);
            this.cmbStartMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(47, 24);
            this.cmbStartMinute.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "שעות התחלה:";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(137, 103);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(109, 24);
            this.cmbDay.TabIndex = 24;
            this.cmbDay.Text = "בחר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "יום:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(137, 52);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(271, 24);
            this.cmbSemester.TabIndex = 22;
            this.cmbSemester.Text = "בחר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "סמסטר:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(333, 266);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "שלח";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClean
            // 
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(174, 266);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 34;
            this.btnClean.Text = "נקה טופס";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(15, 266);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddConstraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 328);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.cmbEndMinute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmAddConstraint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת אילוץ";
            this.Load += new System.EventHandler(this.frmAddConstraint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}