using System;
using System.Data;
using Bs_Pro14.Utilities;
using System.Windows.Forms;

namespace Bs_Pro14.Classes
{
    class Lesson
    {
        private int lessonId, courseId, classId;
        Time startTime, endTime;
        private string lecturerId, weekDay;

        //--Seeter and Geeter--//
        public int LessonId
        {
            get
            {
                return lessonId;
            }

            set
            {
                lessonId = value;
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

        public string LecturerId
        {
            get
            {
                return lecturerId;
            }

            set
            {
                lecturerId = value;
            }
        }

        public int ClassId
        {
            get
            {
                return classId;
            }

            set
            {
                classId = value;
            }
        }

        public string WeekDay
        {
            get
            {
                return weekDay;
            }

            set
            {
                weekDay = value;
            }
        }

        public int IntWeekDay
        {
            get
            {
                if (weekDay == "א" || weekDay == "1")
                    return 1;
                if (weekDay == "ב" || weekDay == "2")
                    return 2;
                if (weekDay == "ג" || weekDay == "3")
                    return 3;
                if (weekDay == "ד" || weekDay == "4")
                    return 4;
                if (weekDay == "ה" || weekDay == "5")
                    return 5;
                if (weekDay == "ו" || weekDay == "6")
                    return 6;
                if (weekDay == "ש" || weekDay == "7")
                    return 7;
                return 0;
            }

            set
            {
                if (value == 1)
                    weekDay = "א";
                if (value == 2)
                    weekDay = "ב";
                if (value == 3)
                    weekDay = "ג";
                if (value == 4)
                    weekDay = "ד";
                if (value == 5)
                    weekDay = "ה";
                if (value == 6)
                    weekDay = "ו";
                if (value == 7)
                    weekDay = "ש";
            }
        }

        public Time StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public Time EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

        //--End Seeter and Geeter--//

        //Default C'tror
        public Lesson()
        {

        }
        public Lesson(int NlessonID, int NcourseId, string NlecturerId, int NclassId, string NweekDay, Time NstartTime, Time NendTime)
        {
            LessonId = NlessonID;
            CourseId = NcourseId;
            LecturerId = NlecturerId;
            ClassId = NclassId;
            WeekDay = NweekDay;
            startTime = NstartTime;
            endTime = NendTime;
        }
        //this function is pull the data from the server
        public Lesson(DataRow dr)
        {
            this.LessonId = (int)dr[0];
            this.StartTime = (Time)DateTime.Parse(dr[1].ToString());
            this.EndTime = (Time)DateTime.Parse(dr[2].ToString());
            this.CourseId = (int)dr[3];
            this.LecturerId = dr[4].ToString();
            this.ClassId = (int)dr[5];
            this.WeekDay = dr[6].ToString();
        }
        //this function is array of lessones by lecturer id.
        public static Lesson[] getLessonById(string id)
        {
            string sqlQuery = "select * from dbo.Lesson where lecturerId = '" + id + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count > 0)
            {
                Lesson[] l = new Lesson[dt.Rows.Count];
                for(int i = 0; i< dt.Rows.Count ; i++)
                {
                    l[i] = new Lesson(dt.Rows[i]);
                }
                return l;
            }
            return null;
        }

        public static Lesson[] getLessonsByCourseId(int id)
        {
            string query = "SELECT * FROM dbo.Lesson WHERE courseId = '" + id.ToString() + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;

            Lesson[] lesson = new Lesson[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                lesson[i] = new Lesson(dr);
                i++;
            }
            return lesson;
        }

        //Method to add lesson to database table.
        public static void AddToDatabase(Lesson l)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.Lesson", "insert");
            AddFieldsToQuery(l, ref query);
            DatabaseManager.ADURecord(query);
        }


        //Method that get a SQL query and add all lesson fields to it.
        private static void AddFieldsToQuery(Lesson l, ref SQLQuery query)
        {
            query.AddToQuery("startTime", l.StartTime);
            query.AddToQuery("endTime", l.EndTime);
            query.AddToQuery("courseId", l.CourseId);
            query.AddToQuery("lecturerId", l.LecturerId);
            query.AddToQuery("classId", l.ClassId);
            query.AddToQuery("weekDay", l.WeekDay, "N");
        }

        //Method to update lesson details in database table by lesson ID.
        public static void UpdateInDataBase(Lesson l, int id)
        {
            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.Lesson", "update", "lessonId", id.ToString());
            AddFieldsToQuery(l, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete person from database table by ID.
        public static void RemoveFromDataBase(int id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.Lesson", "delete", "lessonId", id.ToString());
            DatabaseManager.ADURecord(query);
        }

        public static void removeFromDataBaseByCourseId(int id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.Lesson", "delete", "courseId", id.ToString());
            DatabaseManager.ADURecord(query);
        }


        public static Lesson[] getAllLessons()
        {
            string sqlQuery = "Select * From dbo.Lesson";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            Lesson[] l = new Lesson[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                l[i] = new Lesson(dr);
                i++;
            }
            return l;
        }

    }
}
