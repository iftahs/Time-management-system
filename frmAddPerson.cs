using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Utilities;
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class frmAddPerson : Form
    {
        private string role, id;
        private bool edit;
        private Person person;

        public frmAddPerson()
        {
            InitializeComponent();
        }

        public frmAddPerson(string role) : this()
        {
            this.edit = false;
            this.role = role;
            if (role == "all")
            {
                cbHead.Enabled = true;
                cbLecturer.Enabled = true;
                cbLogistic.Enabled = true;
                cbSecretary.Enabled = true;
                cbStudent.Enabled = true;
            }
        }

        public frmAddPerson(bool edit, string id) : this()
        {
            this.edit = edit;
            this.id = id;
            this.person = Person.getPersonById(id);
        }

        private void FillDateCMB()
        {
            for (int i = 1; i <= 31; i++)
                cmbDayPicker.Items.Add(new Item(i.ToString(), i));

            for (int i = 1; i <= 12; i++)
                cmbMonthPicker.Items.Add(new Item(i.ToString(), i));

            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 100; i--)
                cmbYearPicker.Items.Add(new Item(i.ToString(), i));
        }

        private void cmbPhonePre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDayPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMonthPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbYearPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = true;
            bool dateValid = true;
            //Check first name
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "שדה חובה");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }

            //Check last name
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "שדה חובה");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtLastName, null);
            }

            //Check ID
            if (string.IsNullOrEmpty(txtID.Text))
            {
                errorProvider1.SetError(txtID, "שדה חובה");
                valid = false;
            }
            else if (!Validations.IDValidation(txtID.Text))
            {
                errorProvider1.SetError(txtID, "תעודת זהות לא חוקית");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtID, null);
            }

            //Check phone number
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "שדה חובה");
                valid = false;
            }
            else if (!Validations.isNumric(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "מספר לא חוקי");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }

            //Check phone area code
            if (cmbPhonePre.SelectedItem == null)
            {
                errorProvider1.SetError(cmbPhonePre, "יש לבחור קידומת");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cmbPhonePre, null);
            }

            //Check day of date
            if (cmbDayPicker.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDayPicker, "יש לבחור יום בחודש");
                valid = false;
                dateValid = false;
            }

            else
            {
                errorProvider1.SetError(cmbDayPicker, null);
            }

            //Check month selection
            if (cmbMonthPicker.SelectedItem == null)
            {
                errorProvider1.SetError(cmbMonthPicker, "יש לבחור חודש");
                valid = false;
                dateValid = false;
            }
            else
            {
                errorProvider1.SetError(cmbMonthPicker, null);
            }

            //Check year selection
            if (cmbYearPicker.SelectedItem == null)
            {
                errorProvider1.SetError(cmbYearPicker, "יש לבחור שנה");
                valid = false;
                dateValid = false;
            }
            else
            {
                errorProvider1.SetError(cmbYearPicker, null);
            }

            //Check that at least one role is checked.
            if (cbHead.Checked == false && cbLecturer.Checked == false && cbLogistic.Checked == false && cbSecretary.Checked == false && cbStudent.Checked == false)
            {
                errorProvider1.SetError(cbLecturer, "יש לבחור לפחות בעל תפקיד אחד");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cbLecturer, null);
            }

            //Check date validtion
            if (dateValid == true)
            {
                int day = ((Item)cmbDayPicker.SelectedItem).Value;
                int month = ((Item)cmbMonthPicker.SelectedItem).Value;
                int year = ((Item)cmbYearPicker.SelectedItem).Value;
                if (!Validations.DateValidation(year, month, day) && dateValid == true)
                {
                    errorProvider1.SetError(cmbDayPicker, "תאריך לא חוקי");
                    valid = false;
                }
            }

            if (valid == true)
            {
                Person p = new Person(txtID.Text, txtFirstName.Text, txtLastName.Text);
                p.BirthDate = new DateTime(((Item)cmbYearPicker.SelectedItem).Value, ((Item)cmbMonthPicker.SelectedItem).Value, ((Item)cmbDayPicker.SelectedItem).Value);
                p.Lecturer = true;
                p.PhoneNumber = cmbPhonePre.SelectedItem.ToString() + txtPhone.Text;
                p.Password = "p123456";
                p.Secretary = cbSecretary.Checked;
                p.Student = cbStudent.Checked;
                p.Head = cbHead.Checked;
                p.Lecturer = cbLecturer.Checked;
                p.Logistic = cbLogistic.Checked;
                if (cmbSemester.Enabled == true)
                {
                    int s;
                    int.TryParse(cmbSemester.SelectedItem.ToString(), out s);
                    p.Semester = s;
                }
                if (cmbYear.Enabled == true)
                {
                    int y;
                    int.TryParse(cmbYear.SelectedItem.ToString(), out y);
                    p.Year = y;
                }

                try
                {
                    if (edit == true)
                    {
                        Person.UpdateInDataBase(p, person.ID);
                        MessageBox.Show("פרטי המשתמש עודכנו בהצלחה", "Success");
                        this.Close();
                    }
                    else
                    {
                        Person p2 = Person.getPersonById(txtID.Text);
                        if (p2 == null)
                        {
                            bool s = true;
                            try
                            {
                                Person.AddToDatabase(p);
                            }
                            catch(Exception ex)
                            {
                                Validations.ShowError(ex.Message);
                                s = false;
                            }
                            if (s == true)
                            {
                                MessageBox.Show("המשתמש נוסף בהצלחה", "Success");
                                this.Close();
                            }                        
                        }
                        else
                        {
                            MessageBox.Show("משתמש עם תעודת זהות " + txtID.Text + " כבר קיים במערכת", "User already exist");
                        }
                    }
                }

                catch (Exception ex)
                {
                    Validations.ShowError(ex.ToString());
                }

            }
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            FillDateCMB();
            
            if (edit == true)
            {
                lblTitle.Text = "עריכת פרטי משתמש";
                btnClean.Enabled = false;
                btnAdd.Text = "בצע";
                fillForm();
            }
            else
            {
                CheckBoxes();
            }
        }

        private void fillForm()
        {
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtID.Text = person.ID;
            txtPhone.Text = person.PhoneNumber.Substring(3, 7);
            cmbPhonePre.SelectedIndex = cmbPhonePre.FindStringExact(person.PhoneNumber.Substring(0, 3));
            cmbDayPicker.SelectedIndex = cmbDayPicker.FindStringExact(person.BirthDate.Day.ToString());
            cmbMonthPicker.SelectedIndex = cmbMonthPicker.FindStringExact(person.BirthDate.Month.ToString());
            cmbYearPicker.SelectedIndex = cmbYearPicker.FindStringExact(person.BirthDate.Year.ToString());
            if (person.Semester != 0)
                cmbSemester.SelectedIndex = cmbSemester.FindStringExact(person.Semester.ToString());
            if (person.Year != 0)
                cmbYear.SelectedIndex = cmbYear.FindStringExact(person.Year.ToString());
            cbSecretary.Checked = person.Secretary;
            cbHead.Checked = person.Head;
            cbLogistic.Checked = person.Logistic;
            cbLecturer.Checked = person.Lecturer;
            cbStudent.Checked = person.Student;
        }

        private void CheckBoxes()
        {
            if (this.role == "student") { 
                cbStudent.Checked = true;
                lblTitle.Text = "הוספת סטודנט";
                cmbSemester.Enabled = true;
                cmbYear.Enabled = true;
            }

            if (this.role == "lecturer") {
                cbLecturer.Checked = true;
                lblTitle.Text = "הוספת מרצה";
            }

            if (this.role == "secretary") { 
                cbSecretary.Checked = true;
                lblTitle.Text = "הוספת מזכירה";
            }

            if (this.role == "head") { 
                cbHead.Checked = true;
                lblTitle.Text = "הוספת ראש מחלקה";
            }

            if (this.role == "logistic") { 
                cbLogistic.Checked = true;
                lblTitle.Text = "הוספת מנהל לוגיסטיקה";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStudent.Checked)
            {
                cmbYear.Enabled = true;
                cmbSemester.Enabled = true;
            }
            else
            {
                cmbYear.Text = "בחר";
                cmbYear.Enabled = false;
                cmbSemester.Text = "בחר";
                cmbSemester.Enabled = false;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtID.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cmbDayPicker.SelectedItem = null;
            cmbDayPicker.Text = "בחר";
            cmbMonthPicker.SelectedItem = null;
            cmbMonthPicker.Text = "בחר";
            cmbYearPicker.SelectedItem = null;
            cmbYearPicker.Text = "בחר";
            cmbPhonePre.SelectedItem = null;
            cmbPhonePre.Text = "בחר";
            cmbSemester.SelectedItem = null;
            cmbSemester.Text = "בחר";
            cmbYear.SelectedItem = null;
            cmbYear.Text = "בחר";
            errorProvider1.Clear();
        }
    }
}
