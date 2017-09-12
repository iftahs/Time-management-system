using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bs_Pro14.Utilities;

namespace Bs_Pro14.Classes
{
    class Department
    {
        private int departmentId;
        private string departmentName;
        private bool general;

        //C'tor
        public Department(int id, string name)
        {
            this.departmentId = id;
            this.departmentName = name;
        }

        public Department(DataRow dr)
        {
            this.DepartmentId = (int)dr[0];
            this.DepartmentName = (string)dr[1];
            this.general = (bool)dr[2];
        }

        //-----------Getters and setters----------//
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        public bool General
        {
            get { return general; }
            set { general = value; }
        }
        //-----------End of getters and setters----------//

        public static Department[] getDepartmentsList()
        {
            string query = "SELECT * FROM dbo.Department";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;
            Department[] department = new Department[dt.Rows.Count];

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                department[i] = new Department(dr);
                i++;
            }
            return department;
        }

        public static Department getDepartmentById(int id)
        {
            string query = "SELECT * FROM dbo.Department where departmentId = '" + id + "'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;
            Department d = new Department(dt.Rows[0]);
            return d;
        }

        public static string getDepartmentName(int id)
        {
            Department d = getDepartmentById(id);
            return d.DepartmentName;
        }
    }
}
