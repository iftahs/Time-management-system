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
    public class Person
    {
        private string id, firstName, lastName, password, phoneNumber, facebookID;
        private DateTime birthDate;
        private bool student, lecturer, secretary, logistic, head;
        private int year, semester, departmentId;

        public Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(DataRow dr)
        {
            this.id = dr[0].ToString();
            this.firstName = dr[1].ToString();
            this.lastName = dr[2].ToString();
            this.password = dr[3].ToString();
            this.phoneNumber = dr[4].ToString();
            this.birthDate = ((DateTime)dr[5]);
            this.student = (bool)dr[6];
            this.lecturer = (bool)dr[7];
            this.secretary = (bool)dr[8];
            this.logistic = (bool)dr[9];
            this.head = (bool)dr[10];
            this.year = (int)dr[11];
            this.semester = (int)dr[12];
            this.departmentId = (int)dr[13];
            this.facebookID = (string)dr[14].ToString();
        }

        //Copy C'tor
        public Person(Person other)
        {
            id = other.id;
            firstName = other.firstName;
            lastName = other.lastName;
            password = other.password;
            phoneNumber = other.phoneNumber;
            birthDate = other.birthDate;
            student = other.student;
            lecturer = other.lecturer;
            secretary = other.secretary;
            logistic = other.logistic;
            head = other.head;
            departmentId = other.departmentId;
            year = other.year;
            semester = other.semester;
            facebookID = other.facebookID;
        }

        //-------------Getters and Setters-----------//
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public string ID
        {
            get { return this.id; }
            set
            {
                string i = value;
                while (i.Length < 9)
                    i = '0' + i;
                this.id = i;
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public bool Student
        {
            get { return this.student; }
            set { this.student = value; }
        }

        public bool Lecturer
        {
            get { return this.lecturer; }
            set { this.lecturer = value; }
        }

        public bool Secretary
        {
            get { return this.secretary; }
            set { this.secretary = value; }
        }

        public bool Logistic
        {
            get { return this.logistic; }
            set { this.logistic = value; }
        }

        public bool Head
        {
            get { return this.head; }
            set { this.head = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public int Semester
        {
            get { return this.semester; }
            set { this.semester = value; }
        }

        public int DepartmentId
        {
            get { return this.departmentId; }
            set { this.departmentId = value; }
        }

        public string FacebookID
        {
            get { return this.facebookID; }
            set { this.facebookID = value; }
        }
        //-------------End of Getters and Setters-----------//

        //Method that getting person id and password, and verify this in database.
        public static bool personLogin(string id, string password, ref Person person)
        {
            string sqlQuery = "select * from dbo.person where personID = '" + id + "' and password = '" + password + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 1) { 
                person = new Person(dt.Rows[0]);
                return true;
            }
            return false;
        }

        //Method to find person in database by person id number.
        public static Person getPersonById(string id)
        {
            string sqlQuery = "select * from dbo.person where personID = '" + id + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 1)
            {
                Person p = new Person(dt.Rows[0]);
                return p;
            }
            return null;
        }

        //Method to add person to database table.
        public static void AddToDatabase(Person p)
        {
            //Create INSERT INTO query
            SQLQuery query = new SQLQuery("dbo.person", "insert");
            AddFieldsToQuery(p, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to update person details in database table by person ID.
        public static void UpdateInDataBase(Person p, string id)
        {
            DateTime d = new DateTime(1900, 1, 1);
            if (d.Date < p.BirthDate.Date)
                d = p.BirthDate.Date;

            //Create UPDATE query
            SQLQuery query = new SQLQuery("dbo.person", "update", "personID", id);
            AddFieldsToQuery(p, ref query);
            DatabaseManager.ADURecord(query);
        }

        //Method to delete person from database table by ID.
        public static void RemoveFromDataBase(string id)
        {
            //Create DELETE query
            SQLQuery query = new SQLQuery("dbo.person", "delete", "personID", id);
            DatabaseManager.ADURecord(query);
        }

        //Method that get a SQL query and add all person fields to it.
        private static void AddFieldsToQuery(Person p, ref SQLQuery query)
        {
            DateTime d = new DateTime(1900, 1, 1);
            if (d.Date < p.BirthDate.Date)
                d = p.BirthDate.Date;

            query.AddToQuery("personID", p.ID);
            query.AddToQuery("firstName", p.FirstName, "N");
            query.AddToQuery("lastName", p.LastName, "N");
            query.AddToQuery("password", p.Password);
            query.AddToQuery("phoneNumber", p.PhoneNumber);
            query.AddToQuery("birthDate", d.ToString("MM/dd/yyyy"));
            query.AddToQuery("student", p.Student);
            query.AddToQuery("lecturer", p.Lecturer);
            query.AddToQuery("secretary", p.Secretary);
            query.AddToQuery("logistic", p.Logistic);
            query.AddToQuery("head", p.Head);
            query.AddToQuery("year", p.Year);
            query.AddToQuery("semester", p.Semester);
            query.AddToQuery("departmentId", p.DepartmentId);
            query.AddToQuery("facebookID", p.FacebookID);
        }

        public static Person[] getPersonsByRoll(string roll)
        {
            string query = "SELECT * FROM dbo.Person WHERE " + roll + " = 'True'";
            DataTable dt = DatabaseManager.Connect(query);
            if (dt.Rows.Count == 0)
                return null;

            Person[] persons = new Person[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                persons[i] = new Person(dr);
                i++;
            }
            return persons;
        }

        public static Person getPersonByFacebookID(string id)
        {

            string sqlQuery = "select * from dbo.person where facebookID = '" + id + "'";
            DataTable dt = new DataTable();
            dt = DatabaseManager.Connect(sqlQuery);
            if (dt.Rows.Count == 1)
            {
                Person p = new Person(dt.Rows[0]);
                return p;
            }
            return null;
        }
    }
}
