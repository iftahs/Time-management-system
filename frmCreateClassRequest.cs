using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bs_Pro14.Utilities;
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class frmCreateClassRequest : Form
    {
        public frmCreateClassRequest()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (formValidtion())
            {
                ClassRequest r = new ClassRequest();
                r.StartTime = new Time(int.Parse(cmbStartHour.Text), int.Parse(cmbStartMinute.Text));
                r.EndTime = new Time(int.Parse(cmbEndHour.Text), int.Parse(cmbEndMinute.Text));
                r.Labratory = cbLabratory.Checked;
                r.Projector = cbProjector.Checked;
                r.SemesterId = ((Item)cmbSemester.SelectedItem).Value;
                r.WeekDay = ((Item)cmbDay.SelectedItem).Value;
                r.RequestPersonId = Program.person.ID;
                r.NumberOfSeats = int.Parse(txtNumberOfSits.Text);
                
                try
                {
                    ClassRequest.AddToDatabase(r);
                    MessageBox.Show("הבקשה נוצרה בהצלחה", "Success");
                    this.Close();
                }
                catch(Exception ex) { Validations.ShowError(ex.Message); }
            }
        }

        private bool formValidtion()
        {
            bool valid = true;

            //Check number of sits. Must be between 20 to 100
            if (string.IsNullOrEmpty(txtNumberOfSits.Text))
            {
                errorProvider1.SetError(txtNumberOfSits, "שדה חובה");
                valid = false;
            }
            else if (!Validations.isNumric(txtNumberOfSits.Text))
            {
                errorProvider1.SetError(txtNumberOfSits, "יש למלא מספר בלבד");
                valid = false;
            }
            else if (int.Parse(txtNumberOfSits.Text) < 20 || int.Parse(txtNumberOfSits.Text) > 100)
            {
                errorProvider1.SetError(txtNumberOfSits, "יש למלא מספר בין 20 ל-100");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtNumberOfSits, null);
            }

            //Check combobox semester
            if (cmbSemester.Text == "בחר")
            {
                errorProvider1.SetError(cmbSemester, "יש לבחור סמסטר");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbSemester, null);

            //Check start time hour
            if (string.IsNullOrEmpty(cmbStartHour.Text))
            {
                errorProvider1.SetError(cmbStartHour, "יש לבחור שעת התחלה");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbStartHour, null);

            //Check start time minutes
            if (string.IsNullOrEmpty(cmbStartMinute.Text))
            {
                errorProvider1.SetError(cmbStartMinute, "יש לבחור דקות התחלה");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbStartMinute, null);

            //Check start time hour
            if (string.IsNullOrEmpty(cmbEndHour.Text))
            {
                errorProvider1.SetError(cmbEndHour, "יש לבחור שעת סיום");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbEndHour, null);

            //Check start time minutes
            if (string.IsNullOrEmpty(cmbEndMinute.Text))
            {
                errorProvider1.SetError(cmbEndMinute, "יש לבחור דקות סיום");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbEndMinute, null);

            //Check weekday comobobox
            if (cmbDay.Text == "בחר")
            {
                errorProvider1.SetError(cmbDay, "יש לבחור יום");
                valid = false;
            }
            else
                errorProvider1.SetError(cmbDay, null);

            return valid;
        }

        private void fiilHoursAndDays()
        {
            string value;
            //Fill minutes in interval of 5
            for (int i = 0; i < 60; i += 5)
            {
                if (i >= 0 && i <= 9)
                    value = "0" + i.ToString();
                else
                    value = i.ToString();

                cmbEndMinute.Items.Add(value);
                cmbStartMinute.Items.Add(value);
            }

            //Fill hours.
            for (int i = 8; i <= 22; i++)
            {
                if (i >= 0 && i <= 9)
                    value = "0" + i.ToString();
                else
                    value = i.ToString();
                cmbStartHour.Items.Add(value);
                cmbEndHour.Items.Add(value);
            }


            string day = "";
            for (int i = 1; i <= 7; i++)
            {
                if (i == 1)
                    day = "א";
                if (i == 2)
                    day = "ב";
                if (i == 3)
                    day = "ג";
                if (i == 4)
                    day = "ד";
                if (i == 5)
                    day = "ה";
                if (i == 6)
                    day = "ו";
                if (i == 7)
                    day = "ש";
                Item item = new Item(day, i);
                cmbDay.Items.Add(item);
            }
        }

        private void frmCreateClassRequest_Load(object sender, EventArgs e)
        {
            fiilHoursAndDays();
            Semester.fillSemesters(ref cmbSemester);
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbStartMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbStartHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEndMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEndHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNumberOfSits.Clear();
            cmbSemester.Text = "בחר";
            cmbDay.Text = "בחר";
            cmbStartHour.Text = "";
            cmbEndHour.Text = "";
            cmbStartMinute.Text = "";
            cmbEndMinute.Text = "";
            cbLabratory.Checked = false;
            cbProjector.Checked = false;
        }

    }
}
