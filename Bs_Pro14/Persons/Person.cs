using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bs_Pro14.Persons
{
    class Person
    {
        private string id, firstName, lastName, password, phoneNumber;
        DateTime birthDate;
        bool student, lecturer, secretary, logistic, head;
        int year;

        public Person(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(DataRow dr)
        {
            this.id = dr[0].ToString();
            this.firstName = dr[1].ToString();
            this.lastName = dr[2].ToString();
            this.password = dr[3].ToString();
            this.phoneNumber = dr[4].ToString();
            this.birthDate = (DateTime)dr[5];
            this.student = (bool)dr[6];
            this.lecturer = (bool)dr[7];
            this.secretary = (bool)dr[8];
            this.logistic = (bool)dr[9];
            this.head = (bool)dr[10];
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
        }

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
            set { this.id = value; }
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
    }
}
