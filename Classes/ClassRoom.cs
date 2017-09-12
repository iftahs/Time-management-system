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
    public class ClassRoom
    {
        private int classRoomId, classNumber, sits;
        private string building;
        private bool labratory, projector;

        //C'tor
        public ClassRoom(string building, int classNumber)
        {
            Building = building;
            ClassNumber = classNumber;
        }

        //Copy C'tor
        public ClassRoom(ClassRoom other)
        {
            ClassRoomId = other.ClassRoomId;
            ClassNumber = other.ClassNumber;
            Sits = other.Sits;
            Building = other.Building;
            Labratory = other.Labratory;
            Projector = other.Projector;
        }

        //C'tor that get data from database
        public ClassRoom(DataRow dr)
        {
            classRoomId = (int)dr[0];
            ClassNumber = (int)dr[1];
            Labratory = (bool)dr[2];
            Building = (string)dr[3];
            Sits = (int)dr[4];
            Projector = (bool)dr[5];
        }

        //-------------Getters and Setters-----------//
        public int ClassRoomId
        {
            get { return classRoomId; }
            set { classRoomId = value; }
        }

        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        public int Sits
        {
            get { return sits; }
            set { sits = value; }
        }

        public string Building
        {
            get { return building; }
            set { building = value; }
        }

        public bool Projector
        {
            get { return projector; }
            set { projector = value; }
        }

        public bool Labratory
        {
            get { return labratory; }
            set { this.labratory = value; }
        }
        //-------------End of Getters and Setters-----------//

        //Static method that return class by building and calssNumber
        public static ClassRoom getClassRoom(string building, string classNumber)
        {
            string sqlQuery = "SELECT * FROM dbo.ClassRooms where building = '" + building + "' and classNumber = '" + classNumber + "'";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count > 0)
            {
                ClassRoom cr = new ClassRoom(dt.Rows[0]);
                return cr;
            }
            else
                return null;
        }

        public static ClassRoom[] getAllClassRooms()
        {
            string sqlQuery = "Select * From dbo.ClassRooms";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            ClassRoom[] cr = new ClassRoom[dt.Rows.Count];
            int i = 0;
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cr[i] = new ClassRoom(dr);
                    i++;
                }
                return cr;
            }
            return null;
        }

        public static string getClassRoomName(int id)
        {
            string query = "SELECT * FROM dbo.ClassRooms WHERE classRoomId = '" + id.ToString() + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;

            ClassRoom c = new ClassRoom(dt.Rows[0]);
            return c.Building + c.ClassNumber;
        }

        //Insert new ClassRoom to database
        public static void AddToDataBase(ClassRoom cr)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.ClassRooms", "insert");
            AddFieldsToQuery(cr, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method that get a SQL query and add all class room fields to it.
        private static void AddFieldsToQuery(ClassRoom cr, ref SQLQuery query)
        {
            query.AddToQuery("classNumber", cr.ClassNumber);
            query.AddToQuery("labratory", cr.Labratory);
            query.AddToQuery("building", cr.Building);
            query.AddToQuery("sits", cr.Sits);
            query.AddToQuery("projector", cr.Projector);
        }


        //Method to update Classroom details in database table by person ID.
        public static void UpdateInDataBase(ClassRoom cr, string classRoomId)
        {
            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.ClassRooms", "update", "classRoomId", classRoomId);
            AddFieldsToQuery(cr, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete Classroom from database table by ID.
        public static void RemoveFromDataBase(string classRoomId)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.classRooms", "delete", "classRoomId", classRoomId);
            DatabaseManager.ADURecord(query);
        }
    }
}
