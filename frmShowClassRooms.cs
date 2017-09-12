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

namespace Bs_Pro14.Utilities
{
    public partial class frmShowClassRooms : Form
    {
        private string sqlQuery; // Var for the sql query.
        
        //C'tor.
        public frmShowClassRooms()
        {
            InitializeComponent();
            sqlQuery = "SELECT * FROM dbo.ClassRooms";
        }
        
        //Fills the classrooms from the Data Base in to the Data Grid Table - Fills the classrooms list. 
        private void fillList()
        {
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            int count = dt.Rows.Count, class_Counter = 0;

            ClassRoom[] classrooms = new ClassRoom[count];
            for (int i = 0; i < count; i++)
            {
                class_Counter++;
                classrooms[i] = new ClassRoom(dt.Rows[i]);
                DataGridViewRow dgvr = new DataGridViewRow();
                dgvClassRooms.Rows.Add();
                DataGridViewImageColumn c = new DataGridViewImageColumn();
                dgvClassRooms.Rows[i].Cells[0].Value = "מחק";
                dgvClassRooms.Rows[i].Cells[1].Value = "ערוך";
                dgvClassRooms.Rows[i].Cells[2].Value = classrooms[i].ClassRoomId;
                dgvClassRooms.Rows[i].Cells[3].Value = classrooms[i].ClassNumber;
                dgvClassRooms.Rows[i].Cells[4].Value = classrooms[i].Building;
                dgvClassRooms.Rows[i].Cells[5].Value = classrooms[i].Sits;

                if (classrooms[i].Labratory == true)
                    dgvClassRooms.Rows[i].Cells[6].Value = "כן";
                else
                    dgvClassRooms.Rows[i].Cells[6].Value = "לא";

                if (classrooms[i].Projector == true)
                    dgvClassRooms.Rows[i].Cells[7].Value = "כן";
                else
                    dgvClassRooms.Rows[i].Cells[7].Value = "לא";

            }
        }
       
        //Change the width of the form and operate fillList function.
        private void frmShowClassRooms_Load(object sender, EventArgs e)
        {
            dgvClassRooms.Width = this.Width;
            fillList();
        }

        //clmDelete button.
        private void dgvClassRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string classroomId = dgvClassRooms.Rows[e.RowIndex].Cells["clmClassRoomId"].Value.ToString();
                string building = dgvClassRooms.Rows[e.RowIndex].Cells["clmBuilding"].Value.ToString();
                string classroomNumber = dgvClassRooms.Rows[e.RowIndex].Cells["clmClassNumber"].Value.ToString();

                if (e.ColumnIndex == 0) // Delete.
                {
                    deleteClassRoom(classroomId);
                }

                else if (e.ColumnIndex == 1) // Edit.
                {
                    frmAddClassRoom frm = new frmAddClassRoom(true, classroomNumber , building);
                    frm.Show();
                    frm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                }
            }
        }
       
        //Delete classroom. id = classRoom id.
        private void deleteClassRoom(string id)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הכיתה", "Delete classroom", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                    ClassRoom.RemoveFromDataBase(id);
                MessageBox.Show("הכיתה נמחקה בהצלחה", "Delete classroom");
                foreach (DataGridViewRow row in dgvClassRooms.Rows)
                {
                    if (row.Cells["clmClassRoomId"].Value.ToString() == id)
                    {
                        dgvClassRooms.Rows.Remove(row);
                    }
                }
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshList();

        }

        public void RefreshList()
        {
            dgvClassRooms.Rows.Clear();
            dgvClassRooms.Refresh();
            fillList();
        }

    }
}
