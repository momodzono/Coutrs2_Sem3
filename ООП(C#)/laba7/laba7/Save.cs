using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Добавьте методы сохранения объектов обобщённого типа
//CollectionType<T> в файл и чтения из него

namespace lab7
{
    public class Save<T>
    {
        public static void WriteToFile(HashSet<T> arr)
        {
            StreamWriter file = new StreamWriter("file.txt", false);

            foreach (var item in arr)
            {
                file.Write($"{item}\n");
            }
            file.Close();
        }

        public static void ReadFromFile()
        {
            StreamReader file = new StreamReader("file.txt");
            Console.WriteLine(file.ReadToEnd());
            file.Close();
        }
    }
}
