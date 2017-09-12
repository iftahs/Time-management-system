namespace Bs_Pro14
{
    partial class frmCreateClassRequest
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
            this.txtNumberOfSits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLabratory = new System.Windows.Forms.CheckBox();
            this.cbProjector = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר מקומות:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "יצירת בקשה חדשה לכיתה";
            // 
            // txtNumberOfSits
            // 
            this.txtNumberOfSits.Location = new System.Drawing.Point(140, 59);
            this.txtNumberOfSits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberOfSits.Name = "txtNumberOfSits";
            this.txtNumberOfSits.Size = new System.Drawing.Size(47, 22);
            this.txtNumberOfSits.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "סמסטר:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(140, 107);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(271, 24);
            this.cmbSemester.TabIndex = 4;
            this.cmbSemester.Text = "בחר";
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(140, 158);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(109, 24);
            this.cmbDay.TabIndex = 6;
            this.cmbDay.Text = "בחר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "יום:";
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Location = new System.Drawing.Point(140, 207);
            this.cmbStartMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(47, 24);
            this.cmbStartMinute.TabIndex = 8;
            this.cmbStartMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStartMinute_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "שעות התחלה:";
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(203, 207);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(47, 24);
            this.cmbStartHour.TabIndex = 9;
            this.cmbStartHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStartHour_KeyPress);
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(203, 256);
            this.cmbEndHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(47, 24);
            this.cmbEndHour.TabIndex = 12;
            this.cmbEndHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEndHour_KeyPress);
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Location = new System.Drawing.Point(140, 256);
            this.cmbEndMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(47, 24);
            this.cmbEndMinute.TabIndex = 11;
            this.cmbEndMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEndMinute_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "שעות סיום:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "דרישות:";
            // 
            // cbLabratory
            // 
            this.cbLabratory.AutoSize = true;
            this.cbLabratory.ForeColor = System.Drawing.SystemColors.Control;
            this.cbLabratory.Location = new System.Drawing.Point(141, 306);
            this.cbLabratory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLabratory.Name = "cbLabratory";
            this.cbLabratory.Size = new System.Drawing.Size(69, 21);
            this.cbLabratory.TabIndex = 14;
            this.cbLabratory.Text = "מעבדה";
            this.cbLabratory.UseVisualStyleBackColor = true;
            // 
            // cbProjector
            // 
            this.cbProjector.AutoSize = true;
            this.cbProjector.ForeColor = System.Drawing.SystemColors.Control;
            this.cbProjector.Location = new System.Drawing.Point(141, 354);
            this.cbProjector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProjector.Name = "cbProjector";
            this.cbProjector.Size = new System.Drawing.Size(58, 21);
            this.cbProjector.TabIndex = 15;
            this.cbProjector.Text = "מקרן";
            this.cbProjector.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(19, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(177, 401);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 17;
            this.btnClean.Text = "נקה טופס";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(336, 401);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "שלח";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(188, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(187, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(199, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "20 - 100";
            // 
            // frmCreateClassRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(427, 455);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbProjector);
            this.Controls.Add(this.cbLabratory);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.txtNumberOfSits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateClassRequest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "יצירת בקשה לכיתה";
            this.Load += new System.EventHandler(this.frmCreateClassRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfSits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbLabratory;
        private System.Windows.Forms.CheckBox cbProjector;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}