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
    class Semester
    {
        private int semesterId, kind;
        private DateTime startDate, endDate;

        public Semester(int semesterId, DateTime startDate, DateTime endDate, int kind)
        {
            this.SemesterId = semesterId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.kind = kind;
        }

        public Semester(Semester other)
        {
            this.SemesterId = other.semesterId;
            this.StartDate = other.startDate;
            this.EndDate = other.endDate;
            this.kind = other.kind;
        }

        public Semester(DataRow dr)
        {
            SemesterId = (int)dr[0];
            StartDate = (DateTime)dr[1];
            EndDate = (DateTime)dr[2];
            Kind = (int)dr[3];
        }

        public int SemesterId
        {
            get { return semesterId; }
            set { semesterId = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public static int getSemesterKind(int semesterId)
        {
            string sqlQuery = "SELECT * FROM dbo.Semester where semesterId = '" + semesterId + "'";
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count > 0)
            {
                Semester s = new Semester(dt.Rows[0]);
                return s.Kind;
            }
            else
                return -1;
        }

        public static string getSemesterName(int id)
        {
            string query = "SELECT * FROM dbo.Semester WHERE semesterId = '" + id.ToString() + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;
            string name = "";
            string kind = "";
            Semester s = new Semester(dt.Rows[0]);

            if (s.Kind == 1)
                kind = "סמסטר א'";
            else if (s.Kind == 2)
                kind = "סמסטר ב'";
            else if (s.Kind == 3)
                kind = "סמסטר קיץ";
            name = kind + ": " + s.StartDate.Date.ToString("dd/MM/yyyy") + " - " + s.EndDate.Date.ToString("dd/MM/yyyy");
            return name;
        }

        public static void fillSemesters(ref ComboBox cmbSemester)
        {
            string sqlQuery = "SELECT * FROM dbo.Semester ORDER BY startDate Asc";
            string s;
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            Semester[] semester = new Semester[dt.Rows.Count];
            int i = 0;
            string kind = "";
            foreach (DataRow dr in dt.Rows)
            {
                semester[i] = new Semester(dr);
                if (semester[i].Kind == 1)
                    kind = "סמסטר א'";
                else if (semester[i].Kind == 2)
                    kind = "סמסטר ב'";
                else if (semester[i].Kind == 3)
                    kind = "סמסטר קיץ";
                s = kind + ": " + semester[i].StartDate.Date.ToString("dd/MM/yyyy") + " - " + semester[i].EndDate.Date.ToString("dd/MM/yyyy");
                Item item = new Item(s, semester[i].SemesterId);
                cmbSemester.Items.Add(item);
                if (DateTime.Now.Date > semester[i].StartDate.Date && DateTime.Now.Date < semester[i].EndDate.Date)
                    cmbSemester.SelectedIndex = cmbSemester.Items.Count - 1;
                i++;
            }
        }
    }
}
