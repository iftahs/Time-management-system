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
    public partial class frmAssignedClassRooms : Form
    {
        private ClassRoom[] classRoom;
        private ClassRequest[] classRequest;
        private Person[] person;

        public frmAssignedClassRooms()
        {
            classRoom = ClassRoom.getAllClassRooms();
            classRequest = ClassRequest.getRequestByApplicant(Program.person.ID);
            person = getLogisticManagers();
            InitializeComponent();
        }

        private void frmAssignedClassRooms_Load(object sender, EventArgs e)
        {
            dgvRequests.Width = this.Width;
            fillCmbState();
            Semester.fillSemesters(ref cmbSemester);
            fillDgv(((Item)cmbSemester.SelectedItem).Value, (((Item)cmbApproveState.SelectedItem).Value == 1) ? true : false);
            
        }

        private void fillCmbState()
        {
            Item approved = new Item("אושר", 1);
            Item notApproved = new Item("לא אושר", 0);
            cmbApproveState.Items.Add(approved);
            cmbApproveState.Items.Add(notApproved);
            cmbApproveState.SelectedIndex = 0;
        }

        private void fillDgv(int semesterId, bool approved)
        {
            dgvRequests.Rows.Clear();
            int i = 0;
            foreach (ClassRequest cr in classRequest)
            {
                if (cr.IsApproved == approved && cr.SemesterId == semesterId)
                {
                    dgvRequests.Rows.Add();
                    dgvRequests.Rows[i].Cells[0].Value = "מחק בקשה";
                    dgvRequests.Rows[i].Cells[1].Value = cr.RequestId;
                    dgvRequests.Rows[i].Cells[2].Value = cr.StartTime;
                    dgvRequests.Rows[i].Cells[3].Value = cr.EndTime;
                    dgvRequests.Rows[i].Cells[4].Value = getClassName(cr.ClassRoomId);
                    dgvRequests.Rows[i].Cells[5].Value = (cr.IsApproved == true) ? "כן" : "לא";
                    dgvRequests.Rows[i].Cells[6].Value = getPersonName(cr.ApprovedBy);
                    i++;
                }
            }
        }

        private string getClassName(int classId)
        {
            foreach (ClassRoom cr in classRoom)
            {
                if (cr.ClassRoomId == classId)
                    return cr.Building.ToString() + cr.ClassNumber.ToString();
            }
            return null;
        }

        private string getPersonName(string id)
        {
            foreach (Person p in person)
            {
                if (p.ID == id)
                    return p.FirstName + " " + p.LastName;
            }
            return null;
        }

        private Person[] getLogisticManagers()
        {
            string sqlQuery = "SELECT * FROM dbo.Person where logistic = 'True'";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            Person[] p = new Person[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                p[i] = new Person(dr);
                i++;
            }
            return p;
        }

        private void deleteRequest(int id)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הבקשה", "Delete request", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                ClassRequest.RemoveFromDataBase(id);
                MessageBox.Show("הבקשה נמחקה בהצלחה", "Delete request");
                foreach (DataGridViewRow row in dgvRequests.Rows)
                {
                    if (int.Parse(row.Cells["clmRequestId"].Value.ToString()) == id)
                    {
                        dgvRequests.Rows.Remove(row);
                    }
                }
            }
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbApproveState_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            fillDgv(((Item)cmbSemester.SelectedItem).Value, (((Item)cmbApproveState.SelectedItem).Value == 1) ? true : false);
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = int.Parse(dgvRequests.Rows[e.RowIndex].Cells["clmRequestId"].Value.ToString());
                if (e.ColumnIndex == 0)
                {
                    deleteRequest(id);
                }
            }
        }
    }
}
