using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class RegStudent
    {
        private string studentid, nameOfCourse,nameOfStudent,courseid;

        public RegStudent(DataRow dr)
        {
            Studentid = dr[1].ToString();
            courseid = dr[2].ToString();
        }

        public string Courseid
        {
            get
            {
                return courseid;
            }

            set
            {
                courseid = value;
            }
        }

        public string NameOfCourse
        {
            get
            {
                return nameOfCourse;
            }

            set
            {
                nameOfCourse = value;
            }
        }

        public string NameOfStudent
        {
            get
            {
                return nameOfStudent;
            }

            set
            {
                nameOfStudent = value;
            }
        }

        public string Studentid
        {
            get
            {
                return studentid;
            }

            set
            {
                studentid = value;
            }
        }
    }
}
