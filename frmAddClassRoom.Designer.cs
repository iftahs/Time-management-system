namespace Bs_Pro14
{
    partial class frmAddClassRoom
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
            this.lblAddClassroom = new System.Windows.Forms.Label();
            this.lblClassRoom = new System.Windows.Forms.Label();
            this.textClassNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBuilding = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIsLab = new System.Windows.Forms.CheckBox();
            this.cbIsProjector = new System.Windows.Forms.CheckBox();
            this.btnCancelAddClassroom = new System.Windows.Forms.Button();
            this.btnCleanAddClassroom = new System.Windows.Forms.Button();
            this.btnAddClassroom = new System.Windows.Forms.Button();
            this.cmbSitsPicker = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddClassroom
            // 
            this.lblAddClassroom.AutoSize = true;
            this.lblAddClassroom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddClassroom.Location = new System.Drawing.Point(13, 7);
            this.lblAddClassroom.Name = "lblAddClassroom";
            this.lblAddClassroom.Size = new System.Drawing.Size(69, 13);
            this.lblAddClassroom.TabIndex = 0;
            this.lblAddClassroom.Text = "הוספת כיתה";
            // 
            // lblClassRoom
            // 
            this.lblClassRoom.AutoSize = true;
            this.lblClassRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClassRoom.Location = new System.Drawing.Point(13, 44);
            this.lblClassRoom.Name = "lblClassRoom";
            this.lblClassRoom.Size = new System.Drawing.Size(30, 13);
            this.lblClassRoom.TabIndex = 1;
            this.lblClassRoom.Text = "חדר:";
            // 
            // textClassNumber
            // 
            this.textClassNumber.Location = new System.Drawing.Point(112, 44);
            this.textClassNumber.Name = "textClassNumber";
            this.textClassNumber.Size = new System.Drawing.Size(100, 20);
            this.textClassNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "בניין:";
            // 
            // textBuilding
            // 
            this.textBuilding.Location = new System.Drawing.Point(112, 94);
            this.textBuilding.Name = "textBuilding";
            this.textBuilding.Size = new System.Drawing.Size(100, 20);
            this.textBuilding.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "מספר מושבים:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ציוד:";
            // 
            // cbIsLab
            // 
            this.cbIsLab.AutoSize = true;
            this.cbIsLab.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbIsLab.Location = new System.Drawing.Point(112, 69);
            this.cbIsLab.Name = "cbIsLab";
            this.cbIsLab.Size = new System.Drawing.Size(61, 17);
            this.cbIsLab.TabIndex = 8;
            this.cbIsLab.Text = "מעבדה";
            this.cbIsLab.UseVisualStyleBackColor = true;
            // 
            // cbIsProjector
            // 
            this.cbIsProjector.AutoSize = true;
            this.cbIsProjector.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbIsProjector.Location = new System.Drawing.Point(112, 164);
            this.cbIsProjector.Name = "cbIsProjector";
            this.cbIsProjector.Size = new System.Drawing.Size(51, 17);
            this.cbIsProjector.TabIndex = 9;
            this.cbIsProjector.Text = "מקרן";
            this.cbIsProjector.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddClassroom
            // 
            this.btnCancelAddClassroom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddClassroom.Location = new System.Drawing.Point(16, 200);
            this.btnCancelAddClassroom.Name = "btnCancelAddClassroom";
            this.btnCancelAddClassroom.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddClassroom.TabIndex = 44;
            this.btnCancelAddClassroom.Text = "ביטול";
            this.btnCancelAddClassroom.UseVisualStyleBackColor = true;
            this.btnCancelAddClassroom.Click += new System.EventHandler(this.btnCancelAddClassroom_Click);
            // 
            // btnCleanAddClassroom
            // 
            this.btnCleanAddClassroom.Location = new System.Drawing.Point(97, 200);
            this.btnCleanAddClassroom.Name = "btnCleanAddClassroom";
            this.btnCleanAddClassroom.Size = new System.Drawing.Size(75, 23);
            this.btnCleanAddClassroom.TabIndex = 43;
            this.btnCleanAddClassroom.Text = "נקה";
            this.btnCleanAddClassroom.UseVisualStyleBackColor = true;
            this.btnCleanAddClassroom.Click += new System.EventHandler(this.btnCleanAddClassroom_Click);
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Location = new System.Drawing.Point(178, 200);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(75, 23);
            this.btnAddClassroom.TabIndex = 42;
            this.btnAddClassroom.Text = "הוסף";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // cmbSitsPicker
            // 
            this.cmbSitsPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSitsPicker.FormattingEnabled = true;
            this.cmbSitsPicker.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbSitsPicker.Location = new System.Drawing.Point(113, 129);
            this.cmbSitsPicker.Name = "cmbSitsPicker";
            this.cmbSitsPicker.Size = new System.Drawing.Size(49, 21);
            this.cmbSitsPicker.TabIndex = 45;
            this.cmbSitsPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSitsPicker_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(259, 250);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSitsPicker);
            this.Controls.Add(this.btnCancelAddClassroom);
            this.Controls.Add(this.btnCleanAddClassroom);
            this.Controls.Add(this.btnAddClassroom);
            this.Controls.Add(this.cbIsProjector);
            this.Controls.Add(this.cbIsLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuilding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textClassNumber);
            this.Controls.Add(this.lblClassRoom);
            this.Controls.Add(this.lblAddClassroom);
            this.Name = "frmAddClassRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת כיתה";
            this.Load += new System.EventHandler(this.frmAddClassRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddClassroom;
        private System.Windows.Forms.Label lblClassRoom;
        private System.Windows.Forms.TextBox textClassNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbIsLab;
        private System.Windows.Forms.CheckBox cbIsProjector;
        private System.Windows.Forms.Button btnCancelAddClassroom;
        private System.Windows.Forms.Button btnCleanAddClassroom;
        private System.Windows.Forms.Button btnAddClassroom;
        private System.Windows.Forms.ComboBox cmbSitsPicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}