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
    public partial class frmShowClassRequest : Form
    {
        private string sqlQuery, sqlQuery1; // Var for the sql query.
        private ClassRequest[] classRequest;
        private Person[] person;

        public frmShowClassRequest()
        {
            InitializeComponent();
            sqlQuery = "SELECT * FROM dbo.ClassRequest";
            classRequest = ClassRequest.getAllClassRequests();
            person = getLogisticManagers();

            dgvAcceptedClassroomRequest.Visible = false;
            dgvClassRoomRequest.Visible = false;
            dgvAcceptedClassroomRequest.Location = dgvClassRoomRequest.Location;
        }

        private void fillDgv(bool isTreated)
        {
            classRequest = ClassRequest.getAllClassRequests();
            dgvClassRoomRequest.Rows.Clear();
            dgvAcceptedClassroomRequest.Rows.Clear();

            int k = 0;

            
            if (isTreated == true)
            {
                foreach (ClassRequest cr in classRequest)
                {
                    if (cr.ApprovedBy != "         ")
                    {
                        dgvClassRoomRequest.Rows.Add();
                        dgvClassRoomRequest.Visible = true;
                        dgvAcceptedClassroomRequest.Visible = false;

                        dgvClassRoomRequest.Rows[k].Cells[0].Value = cr.RequestId;
                        dgvClassRoomRequest.Rows[k].Cells[1].Value = cr.NumberOfSeats;
                        sqlQuery1 = "SELECT * FROM dbo.Semester where semesterId = '" + cr.SemesterId + "'";
                        dgvClassRoomRequest.Rows[k].Cells[2].Value = semesterKind();
                        dgvClassRoomRequest.Rows[k].Cells[3].Value = convertHourToString(cr.WeekDay);
                        dgvClassRoomRequest.Rows[k].Cells[4].Value = cr.StartTime;
                        dgvClassRoomRequest.Rows[k].Cells[5].Value = cr.EndTime;
                        if (cr.Labratory == true)
                            dgvClassRoomRequest.Rows[k].Cells[6].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[6].Value = "לא";

                        if (cr.Projector == true)
                            dgvClassRoomRequest.Rows[k].Cells[7].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[7].Value = "לא";

                        if (cr.IsApproved == true)
                            dgvClassRoomRequest.Rows[k].Cells[8].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[8].Value = "לא";
                        dgvClassRoomRequest.Rows[k].Cells[9].Value = getPersonName(cr.ApprovedBy);
                        k++;
                        
                    }
                }
            }

            else
            {
                foreach (ClassRequest cr in classRequest)
                {
                    if (cr.ApprovedBy == "         ")
                    {
                        dgvAcceptedClassroomRequest.Rows.Add();
                        dgvClassRoomRequest.Visible = false;
                        dgvAcceptedClassroomRequest.Visible = true;

                        dgvAcceptedClassroomRequest.Rows[k].Cells[0].Value = "אשר";
                        dgvAcceptedClassroomRequest.Rows[k].Cells[1].Value = "דחה";
                        dgvAcceptedClassroomRequest.Rows[k].Cells[2].Value = cr.RequestId;
                        dgvAcceptedClassroomRequest.Rows[k].Cells[3].Value = cr.NumberOfSeats;

                        sqlQuery1 = "SELECT * FROM dbo.Semester where semesterId = '" + cr.SemesterId + "'";
                        dgvAcceptedClassroomRequest.Rows[k].Cells[4].Value = semesterKind();

                        dgvAcceptedClassroomRequest.Rows[k].Cells[5].Value = convertHourToString(cr.WeekDay);
                        dgvAcceptedClassroomRequest.Rows[k].Cells[6].Value = cr.StartTime;
                        dgvAcceptedClassroomRequest.Rows[k].Cells[7].Value = cr.EndTime;
                        if (cr.Labratory == true)
                            dgvAcceptedClassroomRequest.Rows[k].Cells[8].Value = "כן";
                        else
                            dgvAcceptedClassroomRequest.Rows[k].Cells[8].Value = "לא";

                        if (cr.Projector == true)
                            dgvAcceptedClassroomRequest.Rows[k].Cells[9].Value = "כן";
                        else
                            dgvAcceptedClassroomRequest.Rows[k].Cells[9].Value = "לא";
                        k++;
                       
                    }
                }

            }
            
           /*
            foreach (ClassRequest cr in classRequest)
            {
                if (cr.IsApproved == approved)
                {
                    dgvClassRoomRequest.Rows.Add();

                    if (approved == true)
                    {
                        dgvClassRoomRequest.Visible = true;
                        dgvAcceptedClassroomRequest.Visible = false;

                        dgvClassRoomRequest.Rows[k].Cells[0].Value = cr.RequestId;
                        dgvClassRoomRequest.Rows[k].Cells[1].Value = cr.NumberOfSeats;
                        sqlQuery1 = "SELECT * FROM dbo.Semester where semesterId = '" + cr.SemesterId + "'";
                        dgvClassRoomRequest.Rows[k].Cells[2].Value = semesterKind();
                        dgvClassRoomRequest.Rows[k].Cells[3].Value = convertHourToString(cr.WeekDay);
                        dgvClassRoomRequest.Rows[k].Cells[4].Value = cr.StartTime;
                        dgvClassRoomRequest.Rows[k].Cells[5].Value = cr.EndTime;
                        if (cr.Labratory == true)
                            dgvClassRoomRequest.Rows[k].Cells[6].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[6].Value = "לא";

                        if (cr.Projector == true)
                            dgvClassRoomRequest.Rows[k].Cells[7].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[7].Value = "לא";

                        if(cr.IsApproved == true)
                            dgvClassRoomRequest.Rows[k].Cells[8].Value = "כן";
                        else
                            dgvClassRoomRequest.Rows[k].Cells[8].Value = "לא";
                        dgvClassRoomRequest.Rows[k].Cells[9].Value = getPersonName(cr.ApprovedBy);
                        k++;
                    }

                    else // If Not Treated
                    {
                            dgvClassRoomRequest.Visible = false;
                            dgvAcceptedClassroomRequest.Visible = true;

                            dgvAcceptedClassroomRequest.Rows.Add();

                            dgvAcceptedClassroomRequest.Rows[k].Cells[0].Value = "אשר";
                            dgvAcceptedClassroomRequest.Rows[k].Cells[1].Value = "דחה";
                            dgvAcceptedClassroomRequest.Rows[k].Cells[2].Value = cr.RequestId;
                            dgvAcceptedClassroomRequest.Rows[k].Cells[3].Value = cr.NumberOfSeats;

                            sqlQuery1 = "SELECT * FROM dbo.Semester where semesterId = '" + cr.SemesterId + "'";
                            dgvAcceptedClassroomRequest.Rows[k].Cells[4].Value = semesterKind();

                            dgvAcceptedClassroomRequest.Rows[k].Cells[5].Value = convertHourToString(cr.WeekDay);
                            dgvAcceptedClassroomRequest.Rows[k].Cells[6].Value = cr.StartTime;
                            dgvAcceptedClassroomRequest.Rows[k].Cells[7].Value = cr.EndTime;
                            if (cr.Labratory == true)
                                dgvAcceptedClassroomRequest.Rows[k].Cells[8].Value = "כן";
                            else
                                dgvAcceptedClassroomRequest.Rows[k].Cells[8].Value = "לא";

                            if (cr.Projector == true)
                                dgvAcceptedClassroomRequest.Rows[k].Cells[9].Value = "כן";
                            else
                                dgvAcceptedClassroomRequest.Rows[k].Cells[9].Value = "לא";
                            k++;
                    }
                }
            }
            */
        }
                
        private void frmShowClassRequest_Load(object sender, EventArgs e)
        {
            dgvClassRoomRequest.Width = this.Width;
        }

        private String semesterKind()
        {
            
            DataTable dt1 = DatabaseManager.Connect(sqlQuery1);
            Semester s = new Semester(dt1.Rows[0]);

            if (s.Kind == 1)
                return "סמסטר א'";
            else if (s.Kind == 2)
                return "סמסטר ב'";
            else
                return "סמסטר קיץ";
           
        }

        private void dgvClassRoomRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbApproveState1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fillList();
            bool approved;
            if (cmbApproveState1.SelectedItem.ToString() == "טופל")
            {
                approved = true;
            }
               
            else
            {
                approved = false;
            }
                
            fillDgv(approved);
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

        private void dgvAcceptedClassroomRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                string requestId = dgvAcceptedClassroomRequest.Rows[e.RowIndex].Cells["clmClassroomRequestId1"].Value.ToString();

                if (e.ColumnIndex == 0 && dgvAcceptedClassroomRequest.Rows[e.RowIndex].Cells["clmRequestApproved1"].Value.ToString() == "אשר") // Accept classroom request.
                {
                    frmAcceptClassRoomRequest frm = new frmAcceptClassRoomRequest(requestId);


                }

                else if (e.ColumnIndex == 1 && dgvAcceptedClassroomRequest.Rows[e.RowIndex].Cells["clmRequestReject"].Value.ToString() == "דחה") // Accept classroom request.
                {
                    int requestId1 = int.Parse(dgvAcceptedClassroomRequest.Rows[e.RowIndex].Cells["clmClassroomRequestId1"].Value.ToString());

                    ClassRequest classReq = ClassRequest.getRequestById(requestId1);
                    classReq.IsApproved = false;
                    classReq.ApprovedBy = Program.person.ID;
                    ClassRequest.UpdateInDataBase(classReq);
                    MessageBox.Show("הבקשה נדחתה", "Success Message");
                }

            }
        }

        private String convertHourToString(int day)
        {
            if (day == 1)
                return "א'";
            else if (day == 2)
                return "ב'";
            else if (day == 3)
                return  "ג'";
            else if (day == 4)
                return  "ד'";
            else if (day == 5)
                return  "ה'";
            else if (day == 6)
                return "ו'";
            else 
                return "'ש";
        } 
    }
}
