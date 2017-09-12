using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Bs_Pro14.Utilities;

namespace Bs_Pro14.Classes
{
    public class ClassRequest
    {
        private int requestId, numberOfSeats, classRoomId, weekDay, semesterId;
        private Time startTime, endTime;
        private bool isApproved, projector, labratory;
        private string approvedBy, requestPersonId;

        public ClassRequest() { }

        public ClassRequest(DataRow dr)
        {
            RequestId = (int)dr[0];
            NumberOfSeats = (int)dr[1];
            ClassRoomId = (int)dr[2];
            RequestPersonId = (string)dr[3];
            WeekDay = (int)dr[4];
            StartTime = (Time)DateTime.Parse(dr[5].ToString());
            EndTime = (Time)DateTime.Parse(dr[6].ToString());
            IsApproved = (bool)dr[7];
            ApprovedBy = (string)dr[8];
            Projector = (bool)dr[9];
            Labratory = (bool)dr[10];
            SemesterId = (int)dr[11];
        }

        //-------------Getters and Setters-----------//
        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }

        public int ClassRoomId
        {
            get { return classRoomId; }
            set { classRoomId = value; }
        }

        public string RequestPersonId
        {
            get { return requestPersonId; }
            set { requestPersonId = value; }
        }

        public int WeekDay
        {
            get { return weekDay; }
            set
            {
                if (value < 1 || value > 7)
                    throw new Exception("Day must be between 1 to 7");
                else
                    weekDay = value;
            }
        }

        public string ApprovedBy
        {
            get { return approvedBy; }
            set { approvedBy = value; }
        }

        public Time StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public Time EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }

        public bool Projector
        {
            get { return projector; }
            set { projector = value; }
        }

        public bool Labratory
        {
            get { return labratory; }
            set { labratory = value; }
        }

        public int SemesterId
        {
            get { return semesterId; }
            set { semesterId = value; }
        }
        //-------------End of Getters and Setters-----------//

        //Get request by request id
        public static ClassRequest getRequestById(int id)
        {
            string sqlQuery = "select * from dbo.ClassRequest where requestId = '" + id + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 1)
            {
                ClassRequest cr = new ClassRequest(dt.Rows[0]);
                return cr;
            }
            return null;
        }

      
        //Get all request for class rooms by applicant.
        public static ClassRequest[] getRequestByApplicant(string id)
        {
            string sqlQuery = "select * from dbo.ClassRequest where requestPersonId = '" + id + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count > 0)
            {
                ClassRequest[] cr = new ClassRequest[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cr[i] = new ClassRequest(dt.Rows[i]);
                }
                return cr;
            }
            return null;
        }

        public static ClassRequest[] getAllClassRequests()
        {
            string sqlQuery = "Select * From dbo.ClassRequest";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            ClassRequest[] cr = new ClassRequest[dt.Rows.Count];
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cr[i] = new ClassRequest(dr);
                    i++;
                }
                return cr;
            }
            return null;
        }





        public static void AddToDatabase(ClassRequest c)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.ClassRequest", "insert");
            AddFieldsToQuery(c, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete request from database table by ID.
        public static void RemoveFromDataBase(int id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.ClassRequest", "delete", "requestId", id.ToString());
            DatabaseManager.ADURecord(query);
        }

        public static void UpdateInDataBase(ClassRequest cr)
        {
            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.ClassRequest", "update", "requestId", cr.RequestId.ToString());
            AddFieldsToQuery(cr, ref query);
            DatabaseManager.ADURecord(query);
        }

        private static void AddFieldsToQuery(ClassRequest c, ref SQLQuery query)
        {
            query.AddToQuery("numberOfSeats", c.NumberOfSeats);
            query.AddToQuery("classRoomId", c.classRoomId);
            query.AddToQuery("requestPersonId", c.RequestPersonId);
            query.AddToQuery("weekDay", c.weekDay);
            query.AddToQuery("startTime", new DateTime(1900, 1, 1, c.StartTime.Hour, c.StartTime.Minute, 0));
            query.AddToQuery("endTime", new DateTime(1900, 1, 1, c.EndTime.Hour, c.EndTime.Minute, 0));
            query.AddToQuery("isApproved", c.IsApproved);
            query.AddToQuery("approvedBy", c.approvedBy);
            query.AddToQuery("projector", c.Projector);
            query.AddToQuery("labratory", c.Labratory);
            query.AddToQuery("semesterId", c.SemesterId);
        }
    }
}
