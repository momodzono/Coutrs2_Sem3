using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

//Транспортное средство, Управление авто, Машина, Двигатель,
//Разумное существо, Человек, Трансформер

//Транспортное средство: машина:двигатель, управление авто,
//transport vehicle: car:engine, car management, 
//Разумное существо:человек, трансформер
//intelligent being:human, transformer

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("2000", 22, "woman", "Belarus");
            human1.Info();
            Transformer transformer1 = new Transformer("1999", 3, "Megatron");
            transformer1.Info();

            Car car1 = new Car("car", "BMW");
            car1.Info();
            CarManagement carManagement1 = new CarManagement("car", "BMW", 'B');
            car1 = carManagement1 as Car;
            if (carManagement1 is Car)
            {
                Console.WriteLine("carManagement1 is Car");
            }
            else
            {
                Console.WriteLine("carManagement1 is not Car");
            }
            Printer print = new Printer();
            print.IAmPrinting(car1);
            print.IAmPrinting(human1);
            print.IAmPrinting(transformer1);
        }
    }
}