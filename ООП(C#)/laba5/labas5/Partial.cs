using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    partial class Human
    {
        enum transformer
        {
            OptimusPrime,
            Megatron,
            Bumblebee,
            Starscream
        }
        struct human
        {
            public string name;
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
        }
    }
}
