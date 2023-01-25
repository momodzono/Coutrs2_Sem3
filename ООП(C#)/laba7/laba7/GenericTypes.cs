using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class GenericTypes<T>
    {
        T X { get; set; }
        T Y { get; set; }
        public GenericTypes(T x, T y)
        {
            X = x; Y = y;
        }

        public void Print(string message)
        {
            Console.Write(message + " = ");
            Console.WriteLine($"x = {X}  y = {Y}");
        }
    }
}
