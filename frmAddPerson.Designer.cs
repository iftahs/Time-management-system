namespace Bs_Pro14
{
    partial class frmAddPerson
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbYearPicker = new System.Windows.Forms.ComboBox();
            this.cmbMonthPicker = new System.Windows.Forms.ComboBox();
            this.cmbDayPicker = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPhonePre = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbLecturer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSecretary = new System.Windows.Forms.CheckBox();
            this.cbHead = new System.Windows.Forms.CheckBox();
            this.cbLogistic = new System.Windows.Forms.CheckBox();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbYearPicker
            // 
            this.cmbYearPicker.FormattingEnabled = true;
            this.cmbYearPicker.Location = new System.Drawing.Point(218, 179);
            this.cmbYearPicker.Name = "cmbYearPicker";
            this.cmbYearPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYearPicker.Size = new System.Drawing.Size(49, 21);
            this.cmbYearPicker.TabIndex = 28;
            this.cmbYearPicker.Text = "בחר";
            this.cmbYearPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYearPicker_KeyPress);
            // 
            // cmbMonthPicker
            // 
            this.cmbMonthPicker.FormattingEnabled = true;
            this.cmbMonthPicker.Location = new System.Drawing.Point(161, 179);
            this.cmbMonthPicker.Name = "cmbMonthPicker";
            this.cmbMonthPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMonthPicker.Size = new System.Drawing.Size(51, 21);
            this.cmbMonthPicker.TabIndex = 27;
            this.cmbMonthPicker.Text = "בחר";
            this.cmbMonthPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMonthPicker_KeyPress);
            // 
            // cmbDayPicker
            // 
            this.cmbDayPicker.FormattingEnabled = true;
            this.cmbDayPicker.Location = new System.Drawing.Point(112, 179);
            this.cmbDayPicker.Name = "cmbDayPicker";
            this.cmbDayPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDayPicker.Size = new System.Drawing.Size(44, 21);
            this.cmbDayPicker.TabIndex = 26;
            this.cmbDayPicker.Text = "בחר";
            this.cmbDayPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDayPicker_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(13, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "תאריך לידה:";
            // 
            // cmbPhonePre
            // 
            this.cmbPhonePre.FormattingEnabled = true;
            this.cmbPhonePre.Items.AddRange(new object[] {
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "056",
            "057",
            "058",
            "059"});
            this.cmbPhonePre.Location = new System.Drawing.Point(218, 144);
            this.cmbPhonePre.Name = "cmbPhonePre";
            this.cmbPhonePre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPhonePre.Size = new System.Drawing.Size(49, 21);
            this.cmbPhonePre.TabIndex = 24;
            this.cmbPhonePre.Text = "בחר";
            this.cmbPhonePre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPhonePre_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 144);
            this.txtPhone.MaxLength = 7;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(13, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "טלפון:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 109);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(13, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "תעודת זהות:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 74);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(112, 39);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(13, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "שם משפחה:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(13, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "שם פרטי:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(13, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "הוספת משתמש";
            // 
            // cbLecturer
            // 
            this.cbLecturer.AutoSize = true;
            this.cbLecturer.Enabled = false;
            this.cbLecturer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbLecturer.Location = new System.Drawing.Point(112, 214);
            this.cbLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.cbLecturer.Name = "cbLecturer";
            this.cbLecturer.Size = new System.Drawing.Size(53, 17);
            this.cbLecturer.TabIndex = 30;
            this.cbLecturer.Text = "מרצה";
            this.cbLecturer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "תפקיד:";
            // 
            // cbSecretary
            // 
            this.cbSecretary.AutoSize = true;
            this.cbSecretary.Enabled = false;
            this.cbSecretary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbSecretary.Location = new System.Drawing.Point(112, 244);
            this.cbSecretary.Margin = new System.Windows.Forms.Padding(2);
            this.cbSecretary.Name = "cbSecretary";
            this.cbSecretary.Size = new System.Drawing.Size(63, 17);
            this.cbSecretary.TabIndex = 32;
            this.cbSecretary.Text = "מזכירה";
            this.cbSecretary.UseVisualStyleBackColor = true;
            // 
            // cbHead
            // 
            this.cbHead.AutoSize = true;
            this.cbHead.Enabled = false;
            this.cbHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbHead.Location = new System.Drawing.Point(112, 274);
            this.cbHead.Margin = new System.Windows.Forms.Padding(2);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(87, 17);
            this.cbHead.TabIndex = 33;
            this.cbHead.Text = "ראש מחלקה";
            this.cbHead.UseVisualStyleBackColor = true;
            // 
            // cbLogistic
            // 
            this.cbLogistic.AutoSize = true;
            this.cbLogistic.Enabled = false;
            this.cbLogistic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbLogistic.Location = new System.Drawing.Point(190, 214);
            this.cbLogistic.Margin = new System.Windows.Forms.Padding(2);
            this.cbLogistic.Name = "cbLogistic";
            this.cbLogistic.Size = new System.Drawing.Size(111, 17);
            this.cbLogistic.TabIndex = 34;
            this.cbLogistic.Text = "מנהל לוגיסטיקה";
            this.cbLogistic.UseVisualStyleBackColor = true;
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Enabled = false;
            this.cbStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbStudent.Location = new System.Drawing.Point(190, 244);
            this.cbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(64, 17);
            this.cbStudent.TabIndex = 35;
            this.cbStudent.Text = "סטודנט";
            this.cbStudent.UseVisualStyleBackColor = true;
            this.cbStudent.CheckedChanged += new System.EventHandler(this.cbStudent_CheckedChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbYear.Location = new System.Drawing.Point(396, 39);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(52, 21);
            this.cmbYear.TabIndex = 36;
            this.cmbYear.Text = "בחר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(296, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "שנה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(296, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "סמסטר:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.Enabled = false;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbSemester.Location = new System.Drawing.Point(395, 74);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(53, 21);
            this.cmbSemester.TabIndex = 38;
            this.cmbSemester.Text = "בחר";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(186, 298);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 40;
            this.btnClean.Text = "נקה";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.cbLogistic);
            this.Controls.Add(this.cbHead);
            this.Controls.Add(this.cbSecretary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLecturer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbYearPicker);
            this.Controls.Add(this.cmbMonthPicker);
            this.Controls.Add(this.cmbDayPicker);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbPhonePre);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת משתמש";
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbYearPicker;
        private System.Windows.Forms.ComboBox cmbMonthPicker;
        private System.Windows.Forms.ComboBox cmbDayPicker;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPhonePre;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox cbLecturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSecretary;
        private System.Windows.Forms.CheckBox cbHead;
        private System.Windows.Forms.CheckBox cbLogistic;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClean;
    }
}