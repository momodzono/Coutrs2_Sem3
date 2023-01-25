using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Student
    {
        public readonly int id;
        public string lastname;
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string middlename;
        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        private int phone;
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string faculty;
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        private int course;
        public int Course
        {
            get { return course; }
            set
            {
                if (value < 1 || value > 4)
                {
                    Console.WriteLine("Курс задан не верно");
                }
                else
                {
                    course = value;
                }
            }
        }

        private int group;
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        private string speciality;
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public Student(int a, string b, string c, string d, int i, int g, string k, int m, int t, string w)
        {
            id = a; lastname = b; firstname = c; middlename = d; age = i; phone = g; faculty = k; course = m; group = t; speciality = w;
        }
        public override string ToString()
        {
            return $"{lastname} {firstname}";
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
    }
}
