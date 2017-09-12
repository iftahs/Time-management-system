using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bs_Pro14.Class
{
    public class CourseS
    {
        string courseName;
        string semester;
        int credits;
        int year, departmentId, courseId, blockerCourseId,maxOfStudent;
        float rating;

        public CourseS(DataRow dr)
        {
            this.courseName = dr[0].ToString();
            this.credits = (int)dr[1];
            this.year = (int)dr[2];
            this.semester = dr[3].ToString();
            this.departmentId = (int)dr[4];
            this.courseId = (int)dr[5];
            this.blockerCourseId = (int)dr[6];
            this.maxOfStudent = (int)dr[7];
        }
        //C'ctor
        public CourseS(CourseS other)
        {
            this.courseName = other.courseName;
            this.credits = other.credits;
            this.year = other.year;
            this.semester = other.semester;
            this.departmentId = other.departmentId;
            this.courseId = other.courseId;
            this.blockerCourseId = other.blockerCourseId;
            this.maxOfStudent = other.maxOfStudent;
        }
        public CourseS(string name, string semester, int credit, int year, int depId, int Cid, int blockId, int Max)
        {
            this.courseName = name;
            this.credits = credit;
            this.year = year;
            this.semester = semester;
            this.departmentId = depId;
            this.courseId = Cid;
            this.blockerCourseId = blockId;
            this.maxOfStudent = Max;
        }
        public string CourseName
        {
            get { return courseName; }
            set { this.courseName = value; }
        }
        public int Credits
        {
            get { return credits; }
            set { this.credits = value; }
        }
        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { this.semester = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { this.departmentId = value; }
        }
        public int CourseId
        {
            get { return courseId; }
            set { this.courseId = value; }
        }
        public int BlockerCourseId
        {
            get { return blockerCourseId; }
            set { this.blockerCourseId = value; }
        }
        public int MaxOfStudent
        {
            get { return maxOfStudent; }
            set { this.maxOfStudent = value; }
        }

        public float Rating
        {
            get {return rating;}
            set{rating = value;}
        }
    }
}
