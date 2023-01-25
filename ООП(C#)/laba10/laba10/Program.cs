using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace lab10
{
    class Program
    {

        static void Main(string[] args)
        {
            // 1
            string[] Months = { "January", "February", "March", "April", "May", "June", "July",
                                  "August", "September", "October", "November", "December" };


            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяцы, состоящие из {0} букв:", n);
            var Length = from m in Months
                         where m.Length == n
                         orderby m
                         select m;
            foreach (string s in Length)
                Console.WriteLine(s);


            Console.WriteLine("\nЛетние и зимние месяцы:");
            var summerWinter = from m in Months
                               where Array.IndexOf(Months, m) < 2 ||
                               (Array.IndexOf(Months, m) > 4 && Array.IndexOf(Months, m) < 8) ||
                               Array.IndexOf(Months, m) == 11
                               select m;
            foreach (string m in summerWinter)
                Console.WriteLine(m);


            Console.WriteLine("\nМесяцы в алфавитном порядке:");
            var alphabetSort = from m in Months
                               orderby m
                               select m;
            foreach (string m in alphabetSort)
                Console.WriteLine(m);


            Console.WriteLine("\nМесяцы с буквой U длиной не менее 4:");
            var uLen4 = from m in Months
                        where m.Length >= 4 && m.Contains("u")
                        select m;
            foreach (string m in uLen4)
                Console.WriteLine(m);
            Console.WriteLine("\n");

            //2
            //список студентов заданной специальности по алфавиту;
            //список заданной учебной группы и факультета
            //самого молодого студента
            //количество студентов заданной группы упорядоченных по
            //фамилии
            //первого студента с заданным именем
            Student student1 = new Student(1, "Smirnova", "Maria", "Ivanovna", 19, 33333, "FIT", 2, 4, "POIT");
            Student student2 = new Student(2, "Ivanov", "Ivan", "Ivanovich", 17, 55555, "FIT", 1, 5, "POIT");
            Student student3 = new Student(3, "Vesna", "Vera", "Alexandrovna", 18, 56789, "FIT", 2, 4, "POIT");
            Student student4 = new Student(4, "Sokolov", "Vladislav", "Mihailovich", 16, 25486, "FIT", 1, 3, "ISIT");
            Student student5 = new Student(5, "Sokol", "Vlada", "Mihailovna", 17, 25487, "FIT", 1, 3, "ISIT");
            Student student6 = new Student(6, "Sort", "Vladimir", "Mihailovich", 17, 25986, "FIT", 1, 3, "ISIT");
            Student student7 = new Student(7, "Smirt", "Alla", "Mihailovna", 18, 25086, "FIT", 1, 3, "ISIT");
            Student student8 = new Student(8, "Smirnov", "Vladislav", "Mihailovich", 19, 75486, "FIT", 2, 4, "POIT");
            Student student9 = new Student(9, "Mihailov", "Ivan", "Mihailovich", 18, 25496, "FIT", 2, 4, "ISIT");
            Student student10 = new Student(10, "Vasilev", "Nikita", "Mihailovich", 17, 25406, "FIT", 1, 3, "ISIT");
            List<Student> students = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };

            Console.WriteLine("\nСписок студентов POIT в алфавитном порядке :");
            var studentSpecility = from s in students
                                   where s.Speciality == "POIT"
                                   orderby s.lastname
                                   select s;
            foreach (Student s in studentSpecility)
                Console.WriteLine(s.ToString());

            Console.WriteLine("\nСписок 3 группы FIT:");
            var studentGroup = from st in students
                               where st.Group == 3 && st.Faculty == "FIT"
                               select st;
            foreach (Student st in studentGroup)
                Console.WriteLine(st.ToString());

            int minAge = students.Min(a => a.Age);
            var result = students.FirstOrDefault(a => a.Age == minAge);
            Console.WriteLine($"\nСамый молодой студент - {result}");

            int count = 0;
            foreach (Student s in students)
            {
                if (s.Group == 4)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество - {count}");
            var StudentGroup = from s in students
                               where s.Group == 4
                               orderby s.lastname
                               select s;
            foreach (Student s in StudentGroup)
                Console.WriteLine(s.ToString());

            Console.WriteLine("\nПервый студент с определенным именем:");
            var studentName = from s in students
                              where s.Firstname == "Vladislav"
                              select s;
            var result5 = studentName.Take(1);
            foreach (Student s in result5)
                Console.WriteLine(s.ToString());

            //4
            Console.WriteLine("\n\nСобственный запрос");
            var ownRequest = from b in students
                             where b.Age < 18
                             orderby b.Age
                             where b.Firstname.Contains('a')
                             select b;
            foreach (Student b in ownRequest.Take(3))
                Console.WriteLine(b.ToString());

            List<Person> owners = new List<Person>() { new Person("Vesna", "Sverdlova Street"), new Person("Smirnova", "Kozlova") };
            var joinedList = from stud in students
                             join pers in owners on
                             stud.lastname equals pers.Name
                             select new
                             {
                                 Lastname = stud.lastname,
                                 Name = stud.Firstname,
                                 Address = pers.Address,
                             };
            foreach (var el in joinedList.ToList())
            {
                Console.WriteLine($"\n\nLastname: {el.Lastname}\n" +
                                  $"Name: {el.Name}\n" +
                                  $"Address: {el.Address}\n");
            }
        }
    }

}
