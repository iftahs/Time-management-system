using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bs_Pro14.Class
{
    public class LessonS
    {
        TimeSpan start, end;
        int courseId, classId, lessonId;
        string weekDay, lecturerId;
        public LessonS(DataRow dr)
        {
            this.lessonId = (int)dr[0];
            this.start = (TimeSpan)dr[1];
            this.end = (TimeSpan)dr[2];
            this.courseId = (int)dr[3];
            this.lecturerId = (string)dr[4];
            this.classId = (int)dr[5];
            this.weekDay = (string)dr[6];
        }
        public LessonS(TimeSpan st, TimeSpan en, int Courseid, int Classid, int Lid, string weekD, string lecId)
        {
            this.lessonId = Lid;
            this.start = st;
            this.end = en;
            this.courseId = Courseid;
            this.lecturerId = lecId;
            this.classId = Classid;
            this.weekDay = weekD;
        }
        public int LessonId
        {
            get { return lessonId; }
            set { this.lessonId = value; }
        }
        public TimeSpan Start
        {
            get { return start; }
            set { this.start = value; }
        }
        public TimeSpan End
        {
            get { return end; }
            set { this.end = value; }
        }
        public int CourseId
        {
            get { return courseId; }
            set { this.courseId = value; }
        }
        public string LecturerId
        {
            get { return lecturerId; }
            set { this.lecturerId = value; }
        }
        public int ClassId
        {
            get { return classId; }
            set { this.classId = value; }
        }
        public string WeekDay
        {
            get { return weekDay; }
            set { this.weekDay = value; }
        }
    }
}
