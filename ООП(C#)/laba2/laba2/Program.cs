using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

//Создать класс Student: id, Фамилия, Имя, Отчество,
//Дата рождения, Адрес, Телефон, Факультет, Курс,
//Группа. Свойства и конструкторы должны обеспечивать
//проверку корректности. Добавить метод расчет возраста
//студента
//Создать массив объектов. Вывести:
//a) список студентов заданного факультета
//d) список учебной группы

namespace lab2
{
    partial class Student
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

        private string year;
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
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

        public Student()
        {
            id = 1; lastname = "Akhartsova"; firstname = "Yana"; middlename = "Pavlovna";
            year = "28.04.2004"; address = "Belorusskay Street"; phone = 55555; faculty = "FIT"; course = 2; group = 5; count++;
        }
        public Student(int a, string b, string c, string d = "Petrovich")
        {
            id = a; lastname = b; firstname = c; middlename = d;
            year = "11.04.2003"; address = "Lenina Street"; phone = 44444; faculty = "FIT"; course = 2; group = 4; count++;
        }
        public Student(int a, string b, string c, string d, string i, string f, int g, string k, int m, int t)
        {
            id = a; lastname = b; firstname = c; middlename = d; year = i; address = f; phone = g; faculty = k; course = m; group = t; count++;
        }

        static Student()
        {
            Console.WriteLine("Students:");
        }

        //private Student() { }

        public const string university = "BSTU";

        //создайте в классе статическое поле, хранящее количество созданных
        //      объектов(инкрементируется в конструкторе) и статический
        //    метод вывода информации о классе.

        public static int count;
        public Student(int x, string y)
        {
            count++;
            this.id = x;
            this.lastname = y;
            Student.count++;
        }
        public void Age(ref string year, out int age)
        {
            var date = DateTime.ParseExact(year, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
                age--;
            Console.WriteLine($"Возраст: {age}");
        }

        //переопределяете методы класса Object: Equals, для сравнения объектов,
        //GetHashCode; для алгоритма вычисления хэша руководствуйтесь
        //стандартными рекомендациями, ToString – вывода строки –
        //информации об объекте.


        public override int GetHashCode()
        {
            Console.WriteLine($"Hashcode of lastname: {lastname.GetHashCode()}");
            return lastname.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"{id}\n{lastname}\n{firstname}\n{middlename}\n{year}\n{address}\n{phone}\n{faculty}\n{course}\n{group}\n{university}";
        }

        public void GetInfo()
        {
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine($"Id: {id} | Lastname: {lastname} | Firstname: {firstname} | Middlename: {middlename} | DateOfBirthday: {year} | Address: {address} | Phone: {phone} | Faculty: {faculty} | Course: {course} | Group : {group}| University: {university}");
        }

        public static void array()
        {
            var Students = new Student[3];
            Students[0] = new Student(1, "Sidorov", "Ivan", "Ivanovich", "12.01.2005", "Nemiga", 11111, "PIM", 1, 4);
            Students[1] = new Student(2, "Sokolov", "Vladislav", "Mihailovich", "25.06.2004", "Kiseleva", 25486, "FIT", 1, 3);
            Students[2] = new Student(3, "Vesna", "Vera", "Alexandrovna", "15.03.2005", "Kozlova", 56789, "PIM", 1, 4);
            //a) список студентов заданного факультета;
            Console.Write("Введите название факультета: ");
            string Facult = Console.ReadLine();
            var Stud = Students.Where(s => s.faculty == Facult);
            Console.WriteLine("Список студентов заданного факультета:");
            foreach (var item in Stud)
            {
                Console.WriteLine(item.lastname);
            }

            //d) список учебной группы.
            Console.Write("Введите номер группы: ");
            int Group = int.Parse(Console.ReadLine());
            var groups = Students.Where(g => g.group == Group);
            Console.WriteLine("Список студентов учебной группы:");
            foreach (var item1 in groups)
            {
                Console.WriteLine(item1.lastname);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student Yana = new Student();
            Student Petr = new Student(2, "Petrov", "Petr");
            Student Masha = new Student(3, "Smirnova", "Maria", "Ivanovna", "16.03.2003", "Sverdlova Street", 33333, "FIT", 2, 4);

            Yana.GetInfo();
            string Year1 = "15.04.2004";
            int Age1;
            Yana.Age(ref Year1, out Age1);
            Console.WriteLine("_________________________________________________________________");
            Yana.GetHashCode();
            bool d = Yana.Equals(Yana);
            bool p = Yana.Equals(Petr);
            Console.WriteLine($"Yana-Petr: {p}\t Yana-Yana: {d}");

            Petr.GetInfo();
            Petr.GetHashCode();

            Masha.GetInfo();
            Masha.GetHashCode();
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine(Masha.ToString());
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine($"Количество: {Student.count}");
            Console.WriteLine("_________________________________________________________________");
            Student.array();
            Console.WriteLine("_________________________________________________________________");
            var user = new { lastname = "Petrova", name = "Diana" };
            Console.WriteLine($"Фамилия: {user.lastname} Имя: {user.name}");
        }
    }
}