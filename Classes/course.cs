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
namespace Bs_Pro14.Classes
{
    class Course
    {
        private int pointOfCours, year;
        private string nameOfCours;
        private char semester;
        private static int sem, ye;
        public Course(int pointOfCours, int year, string nameOfCours, char semester)
        {
            this.Year = year;
            this.Semester = semester;
            this.NameOfCours = nameOfCours;
            this.PointOfCours = pointOfCours;
            sem = 0;
            ye = 0;
        }
        public Course(DataRow dr)
        {
            this.nameOfCours = dr[0].ToString();
            this.pointOfCours = (int)dr[1];
            this.year = (int)dr[2];
          //  this.semester = (char)dr[3];

        }
        public void setStatic(int semester,int year)
        {
            sem = semester;
            ye = year;
        }
        public int getStaticSemester() { return sem; }
        public int getStaticYear() { return ye; }

        public int Year
        {
            get {
                return year;
                    }

            set
            {
                year = value;
            }
        }

        public int PointOfCours
        {
            get
            {
                return pointOfCours;
            }

            set
            {
                pointOfCours = value;
            }
        }

        public string NameOfCours
        {
            get
            {
                return nameOfCours;
            }

            set
            {
                nameOfCours = value;
            }
        }

        public char Semester
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

       
       

    }

}
