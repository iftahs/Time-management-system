namespace Bs_Pro14
{
    partial class frmSelectSmester
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
            this.year1 = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // year1
            // 
            this.year1.FormattingEnabled = true;
            this.year1.Items.AddRange(new object[] {
            "א",
            "ב",
            "ג",
            "ד"});
            this.year1.Location = new System.Drawing.Point(12, 27);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(121, 21);
            this.year1.TabIndex = 0;
            this.year1.Text = "בחר שנת לימודים";
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "חורף",
            "אביב",
            "קיץ"});
            this.semester.Location = new System.Drawing.Point(159, 27);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(121, 21);
            this.semester.TabIndex = 1;
            this.semester.Text = "בחר סמסטר";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSelectSmester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.year1);
            this.Enabled = false;
            this.Name = "frmSelectSmester";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "בחירת סמסטר להצגת הקורסים";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox year1;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.Button button1;
    }
}