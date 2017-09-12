using Bs_Pro14.Classes;
using Bs_Pro14.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bs_Pro14
{
    public partial class frmAcceptClassRoomRequest : Form
    {
        private string requestId;
        private ClassRoom[] classRooms;
        private ClassRequest[] classRequests;

        public frmAcceptClassRoomRequest()
        {
            InitializeComponent();
        }

        public frmAcceptClassRoomRequest(string requestId)
        {
            InitializeComponent();
            this.requestId = requestId;
            this.classRooms = ClassRoom.getAllClassRooms();
            this.classRequests = ClassRequest.getAllClassRequests();
            fillAvailableClassRoom();
        }

        public void fillAvailableClassRoom()
        {

            int reqId = int.Parse(requestId);
            int classroomId;
            List<int> cId = new List<int>();

            ClassRequest classReq = ClassRequest.getRequestById(reqId); // The request to Accept

            //Find the classroom that suitable for the Secretary requested classroom. 
            foreach (ClassRoom clrom in classRooms)
            {
                if (clrom.Projector == classReq.Projector && clrom.Labratory == classReq.Labratory && classReq.NumberOfSeats <= clrom.Sits)
                {
                    cId.Add(clrom.ClassRoomId);
                }
            }


            if(cId.Count != 0){
                //If the class is suitable check if it is available in the requested times.
                foreach (ClassRequest req in classRequests)
                {
                    if (req.SemesterId == classReq.SemesterId && req.WeekDay == classReq.WeekDay && req.IsApproved == true && req.ClassRoomId == classReq.ClassRoomId)
                    {
                        if ((classReq.StartTime >= req.StartTime && classReq.StartTime <= req.EndTime) || (classReq.EndTime <= req.EndTime && classReq.EndTime >= req.StartTime))
                        {
                            classroomId = req.ClassRoomId;
                            if (cId.Contains(req.ClassRoomId))
                                cId.Remove(req.ClassRoomId);
                        }
                    }
                }

                if (cId.Count != 0)
                {
                    fillDgv(cId, reqId);
                    this.Show();
                }
                     
                else
                {
                    MessageBox.Show("לא נמצאה כיתה תואמת פנויה", "Message");
                    this.Close();
                }
                    
            }

            else
            {
                MessageBox.Show("לא נמצאה כיתה תואמת פנויה", "Message");
                this.Close();
            }
                
                
        }


        public void fillDgv(List<int> cId, int reqId)
        {

            dgvClassRoomsRequestAccept.Rows.Clear();

            int i = 0;

            foreach (ClassRoom cr in classRooms)
            {
                if (cId.Contains(cr.ClassRoomId))
                {
                    dgvClassRoomsRequestAccept.Rows.Add();
                    dgvClassRoomsRequestAccept.Rows[i].Cells[0].Value = "בחר";
                    dgvClassRoomsRequestAccept.Rows[i].Cells[1].Value = reqId;
                    dgvClassRoomsRequestAccept.Rows[i].Cells[2].Value = cr.ClassNumber;
                    dgvClassRoomsRequestAccept.Rows[i].Cells[3].Value = cr.Building;
                    dgvClassRoomsRequestAccept.Rows[i].Cells[4].Value = cr.Sits;
                    dgvClassRoomsRequestAccept.Rows[i].Cells[5].Value = cr.Labratory;
                    dgvClassRoomsRequestAccept.Rows[i].Cells[6].Value = cr.Projector;

                    if (classRooms[i].Labratory == true)
                        dgvClassRoomsRequestAccept.Rows[i].Cells[5].Value = "כן";
                    else
                        dgvClassRoomsRequestAccept.Rows[i].Cells[5].Value = "לא";

                    if (classRooms[i].Projector == true)
                        dgvClassRoomsRequestAccept.Rows[i].Cells[6].Value = "כן";
                    else
                        dgvClassRoomsRequestAccept.Rows[i].Cells[6].Value = "לא";
                    i++;
                }
            }
        }

        private void frmAcceptClassRoomRequest_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmAcceptClassRoomRequest_Load(object sender, EventArgs e)
        {

        }

        private void dgvClassRoomsRequestAccept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int requestId = int.Parse(dgvClassRoomsRequestAccept.Rows[e.RowIndex].Cells["clmClassRoomId"].Value.ToString() );

                ClassRequest classReq = ClassRequest.getRequestById(requestId);
                classReq.IsApproved = true;
                classReq.ApprovedBy = Program.person.ID;
                ClassRoom cr = ClassRoom.getClassRoom(dgvClassRoomsRequestAccept.Rows[e.RowIndex].Cells["clmBuilding"].Value.ToString(), dgvClassRoomsRequestAccept.Rows[e.RowIndex].Cells["clmClassNumber"].Value.ToString());
                classReq.ClassRoomId = cr.ClassRoomId ;
                ClassRequest.UpdateInDataBase(classReq);
                MessageBox.Show("הבקשה אושרה בהצלחה", "Success Message");
                this.Close();
            }

        }
    }
}