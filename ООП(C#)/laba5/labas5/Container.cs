using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Container
    {
        public List<object> mainList = new List<object>();


        public List<object> list
        {
            get { return mainList; }
            set
            {
                if (value == null) { Console.WriteLine("Ошибка"); }
                else { mainList = value; }
            }
        }


        public void Remove(int num)
        {
            list.RemoveAt(num);
        }




        public void Add(object element)
        {
            list.Add(element);
        }



        public void PrintElems()
        {
            {
                Console.WriteLine("               _______            ");
                Console.WriteLine("              /   |   \\        ");
                Console.WriteLine("             /         \\         ");
                Console.WriteLine("            /____/\\_____\\         ");
                Console.WriteLine("            |           |         ");
                Console.WriteLine("            |    (      |         ");
                Console.WriteLine("            |   (       |         ");
                Console.WriteLine("            |        )  |         ");
                Console.WriteLine("            |           |         ");
                Console.WriteLine("            |    (      |         ");
                Console.WriteLine("            |           |         ");
                Console.WriteLine("            |         ) |         ");
                Console.WriteLine("            |   (       |         ");
                Console.WriteLine("            |      )    |         ");
                Console.WriteLine("            |           |         ");
                Console.WriteLine("            |  (        |         ");
                Console.WriteLine("            |           |         ");
                Console.WriteLine(" __________               __________      ");
                Console.WriteLine("/          \\            /          \\");
                Console.WriteLine("|           |           |           |");
                Console.WriteLine("|           |           |           |");
                Console.WriteLine("\\__________/            \\__________/");
            }
            foreach (object item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
