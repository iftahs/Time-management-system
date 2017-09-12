using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Utilities;
using Bs_Pro14.Classes;

namespace Bs_Pro14.Classes
{
     class Constraints
    {
        private int constraintId, semesterId, day;
        private bool removed, approved;
        private Time startTime, endTime;
        private string lecturerId;

        public Constraints()
        {

        }

        public Constraints(DataRow dr)
        {
            ConstraintId = (int)dr[0];
            LecturerId = (string)dr[1];
            Semesterid = (int)dr[2];
            day = (int)dr[3];
            StartTime = (Time)DateTime.Parse(dr[4].ToString());
            EndTime = (Time)DateTime.Parse(dr[5].ToString());
            Removed = (bool)dr[6];
            approved = (bool)dr[7];

            
        }
        //-------------Getters and Setters-----------//
        public int ConstraintId
        {
            get { return constraintId; }
            set { constraintId = value; }
        }

        public string LecturerId
        {
            get {return lecturerId;}
            set { lecturerId = value; }
        }

        public int Semesterid
        {
            get { return semesterId; }
            set { semesterId = value; }
        }

        public bool Removed
        {
            get { return removed; }
            set { removed = value; }
        }

        public bool Approved
        {
            get { return approved; }
            set { approved = value; }
        }

        public Time StartTime
        {
            get { return startTime; }
            set { this.startTime = value; }
        }

        public Time EndTime
        {
            get { return endTime;}
            set { endTime = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public static void AddToDatabase(Constraints c)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.Constraints", "insert");
            AddFieldsToQuery(c, ref query);
            DatabaseManager.ADURecord(query);
        }

        public static void UpdateInDataBase(Constraints c)
        {
            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.Constraints", "update", "constraintId", c.ConstraintId.ToString());
            AddFieldsToQuery(c, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete person from database table by ID.
        public static void RemoveFromDataBase(int id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.Constraints", "delete", "constraintId", id.ToString());
            DatabaseManager.ADURecord(query);
        }

        //Method that get a SQL query and add all constraint fields to it.
        private static void AddFieldsToQuery(Constraints c, ref SQLQuery query)
        {
            query.AddToQuery("lecturerId", c.LecturerId);
            query.AddToQuery("semesterId", c.Semesterid);
            query.AddToQuery("day", c.Day);
            query.AddToQuery("startTime", c.StartTime);
            query.AddToQuery("endTime", c.EndTime);
            query.AddToQuery("removed", c.Removed);
            query.AddToQuery("approved", c.Approved);
        }

        public static Constraints[] getConstraintsByLecturer(string id)
        {
            string sqlQuery = "SELECT * FROM dbo.Constraints where lecturerId = '" + id + "'";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 0)
                return null;

            int i = 0;
            Constraints[] c = new Constraints[dt.Rows.Count];
            foreach (DataRow dr in dt.Rows)
            {
                c[i] = new Constraints(dr);
                i++;
            }

            return c;
        }

        public static Constraints[] getAllConstraints()
        {
            string sqlQuery = "SELECT * FROM dbo.Constraints";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 0)
                return null;

            int i = 0;
            Constraints[] c = new Constraints[dt.Rows.Count];
            foreach (DataRow dr in dt.Rows)
            {
                c[i] = new Constraints(dr);
                i++;
            }

            return c;
        }
        //check if has any Constraints of the id lectuer
        public static bool hasConstrain(string id)
        {
            Constraints[] a = getConstraintsByLecturer(id);
            if (a != null)
            {
                return true;
            }
            else
            {
            return false;
            }
        }
    }
}
