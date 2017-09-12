using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Classes;
using Bs_Pro14.Utilities;

namespace Bs_Pro14
{
    public partial class frmAddClassRoom : Form
    {
        private string classroomNumber, building, sqlQuery;
        private bool edit;
        private ClassRoom classroom;


        public frmAddClassRoom()
        {
            InitializeComponent();
        }
       
        //C'tor For Add New Class
        public frmAddClassRoom(bool edit) : this()
        {
            this.edit = false;
        }
        
        //C'tor For Edit exist Class
        public frmAddClassRoom(bool edit, string classroomNumber, string building) : this()
        {
            this.edit = edit;
            this.classroomNumber = classroomNumber;
            this.building = building;
            this.classroom = ClassRoom.getClassRoom(building, classroomNumber);
        }
        
        //Changed form deatails for edit class operate. 
        private void frmAddClassRoom_Load(object sender, EventArgs e)
        {
            if (edit == true)
            {
                this.Text = "עריכת כיתה";
                lblAddClassroom.Text = "עריכת פרטי כיתה";
                btnCleanAddClassroom.Enabled = false;
                btnAddClassroom.Text = "בצע";
                fillForm();
            }
            else
            {
                cmbSitsPicker.SelectedItem = null;
                cmbSitsPicker.Text = "בחר";
            }
        }

        private void cmbSitsPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancelAddClassroom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCleanAddClassroom_Click(object sender, EventArgs e)
        {
            textClassNumber.Clear();
            cbIsLab.Checked = false;
            textBuilding.Clear();
            cmbSitsPicker.SelectedItem = null;
            cmbSitsPicker.Text = "בחר";
            cbIsProjector.Checked = false;
            errorProvider1.Clear();

        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            bool valid = true;

            //Check class number.
           
            if (string.IsNullOrEmpty(textClassNumber.Text))
            {
                errorProvider1.SetError(textClassNumber, "שדה חובה");
                valid = false;
            }
            else if (!(Utilities.Validations.isNumric(textClassNumber.Text)))
            {
                errorProvider1.SetError(textClassNumber, "חדר לא חוקי! אנא הזן מספר");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(textClassNumber, null);
            }

            //Check building.
            if (string.IsNullOrEmpty(textBuilding.Text))
            {
                errorProvider1.SetError(textBuilding, "שדה חובה");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(textBuilding, null);
            }

            //Check Sits.
            if (cmbSitsPicker.SelectedItem == null)
            {
                errorProvider1.SetError(cmbSitsPicker, "יש לבחור מספר מושבים בכיתה");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cmbSitsPicker, null);
            }
            
            //All the filled data are ok.
            if (valid == true)
            {
                ClassRoom c = new ClassRoom(textBuilding.Text, int.Parse(textClassNumber.Text));
                c.Sits = int.Parse(cmbSitsPicker.Text);
                c.Labratory = cbIsLab.Checked;
                c.Projector = cbIsProjector.Checked;

                try
                {
                    ClassRoom c2 = ClassRoom.getClassRoom(textBuilding.Text, textClassNumber.Text);
                    //Mode:Edit and the new class is not in the DB OR the mode is Edit and the new class is already exit but the rest can be changed.
                    if ((edit == true && c2 == null) || (edit == true && c2 != null && (c2.Projector != cbIsProjector.Checked || c2.Labratory != cbIsLab.Checked || c2.Sits != int.Parse(cmbSitsPicker.Text))))
                    {
                        ClassRoom.UpdateInDataBase(c, classroom.ClassRoomId.ToString());
                        MessageBox.Show("פרטי הכיתה עודכנו בהצלחה", "Success");
                        this.Close();
                    }
                    else
                    {
                        if (c2 == null)
                        {
                            ClassRoom.AddToDataBase(c);
                            MessageBox.Show("הכיתה נוספה בהצלחה", "Success");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("!כבר קיימת במערכת" + " " +textBuilding.Text+ textClassNumber.Text + " :כיתה", "Classroom is already exist");
                        }
                    }
                }

                catch (Exception ex)
                {
                    Validations.ShowError(ex.ToString());
                }
            }
 
        }
        
        //Edit Classroom Details: The old Details will be showen then the user can decide if he wants to edit them.
        private void fillForm()
        {
            textClassNumber.Text = classroom.ClassNumber.ToString();
            cbIsLab.Checked = classroom.Labratory;
            textBuilding.Text = classroom.Building;
            cmbSitsPicker.SelectedIndex = cmbSitsPicker.FindStringExact(classroom.Sits.ToString());
            cbIsProjector.Checked = classroom.Projector;
        }



    }
}
