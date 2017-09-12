using Bs_Pro14.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Classes
{
    class CourseBySyllabus
    {
        private string courseName;
        private int credits, year;
        private string semester;
        private int departmentId;
        private int courseId , maxStudent;
        private int blockerCourseId;
        private int semesterid;
        private bool practice;


        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public string Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
        }

        public int DepartmentId
        {
            get
            {
                return departmentId;
            }

            set
            {
                departmentId = value;
            }
        }

        public int CourseId
        {
            get
            {
                return courseId;
            }

            set
            {
                courseId = value;
            }
        }

        public int BlockerCourseId
        {
            get
            {
                return blockerCourseId;
            }

            set
            {
                blockerCourseId = value;
            }
        }

        public int Semesterid
        {
            get
            {
                return semesterid;
            }

            set
            {
                semesterid = value;
            }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int MaxStudent
        {
            get { return maxStudent; }
            set { maxStudent = value; }
        }

        public bool Practice
        {
            get { return practice; }
            set { practice = value; }
        }

        //Default C'tor
        public CourseBySyllabus()
        {

        }


        //C'tor
        public CourseBySyllabus(string NcourseName, int Ncredits, int Nyear, string Nsemester, int NdepartmentId, int NcourseId, int NblockerCourseId,int NmaxStudent, int Nsemesterid)
        {
            CourseName = NcourseName;
            Credits = Ncredits;
            year = Nyear;
            Semester = Nsemester;
            DepartmentId = NdepartmentId;
            semesterid = Nsemesterid;
            CourseId = NcourseId;
            maxStudent = NmaxStudent;
            BlockerCourseId = NblockerCourseId;
        }
        //Get Datarow and convert it into Course object.
        public CourseBySyllabus(DataRow dr)
        {
            this.CourseName = dr[0].ToString();
            this.Credits = (int)dr[1];
            this.year = (int)dr[2];
            this.Semester = dr[3].ToString();
            this.DepartmentId = (int)dr[4];
            this.CourseId = (int)dr[5];
            this.BlockerCourseId = (int)dr[6];
            this.maxStudent = (int)dr[7];
            this.semesterid = (int)dr[8];
        }

        public static CourseBySyllabus[] getCourseByYearASemid(int semesterid)
        {
            string sqlQuery = "SELECT * FROM dbo.CourseBySyllabus where semesterid ='" + semesterid.ToString() + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);

            if (dt.Rows.Count > 0)
            {
                CourseBySyllabus[] l = new CourseBySyllabus[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    l[i] = new CourseBySyllabus(dt.Rows[i]);
                }
                return l;
            }
            return null;
        }

        public static CourseBySyllabus[] getCoursesByDepartment(int departmentId)
        {
            string query = "SELECT * FROM dbo.CourseBySyllabus where departmentId = '" + departmentId + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;

            CourseBySyllabus[] course = new CourseBySyllabus[dt.Rows.Count];
            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                course[i] = new CourseBySyllabus(dr);
                i++;
            }
            return course;
        }

        public static CourseBySyllabus getCourseById(int id)
        {
            CourseBySyllabus c;
            string query = "SELECT * FROM dbo.CourseBySyllabus WHERE courseId = '" + id.ToString() + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;
            c = new CourseBySyllabus(dt.Rows[0]);
            return c;
        }

        public static string getCourseName(int id)
        {
            CourseBySyllabus c = getCourseById(id);
            return c.CourseName;
        }

        public static CourseBySyllabus[] getCoursesList()
        {
            string query = "SELECT * FROM dbo.CourseBySyllabus";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;

            CourseBySyllabus[] course = new CourseBySyllabus[dt.Rows.Count];
            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                course[i] = new CourseBySyllabus(dr);
                i++;
            }
            return course;
        }

        //Method to add course to database table.
        public static void AddToDatabase(CourseBySyllabus c)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.CourseBySyllabus", "insert");
            AddFieldsToQuery(c, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method that get a SQL query and add all person fields to it.
        private static void AddFieldsToQuery(CourseBySyllabus c, ref SQLQuery query)
        {
            query.AddToQuery("courseName", c.CourseName, "N");
            query.AddToQuery("credits", c.Credits);
            query.AddToQuery("year", c.Year);
            query.AddToQuery("semester", c.Semester);
            query.AddToQuery("departmentId", c.DepartmentId);
            query.AddToQuery("blockerCourseId", c.BlockerCourseId);
            query.AddToQuery("maxStudent", c.MaxStudent);
            query.AddToQuery("semesterId", c.Semesterid);
            query.AddToQuery("practice", c.Practice);
        }

        //Method to update course details in database table by course ID.
        public static void UpdateInDataBase(CourseBySyllabus c, int id)
        {
            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.CourseBySyllabus", "update", "courseId", id.ToString());
            AddFieldsToQuery(c, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete person from database table by ID.
        public static void RemoveFromDataBase(int id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.CourseBySyllabus", "delete", "courseId", id.ToString());
            DatabaseManager.ADURecord(query);
        }
    }
   
}
