using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Vova", "2000", 22);
            Human human2 = new Human("Sasha", "2001", 20);

            Transformer transformer1 = new Transformer("2000", "Optimus Prime", 7);
            Transformer transformer2 = new Transformer("2000", "Megatron", 7);
            Transformer transformer3 = new Transformer("2000", "Bumblebee", 7);
            Transformer transformer4 = new Transformer("2001", "Starscream", 6);

            List<object> army1 = new List<object> { human1, human2, transformer2, transformer3, transformer4 };
            Container container = new Container();
            container.mainList = army1;
            Console.WriteLine("Список:" + "\n");
            container.PrintElems();
            Console.WriteLine();
            Console.WriteLine("Удаление элемента: " + "\n");
            container.Remove(3);
            container.PrintElems();
            Console.WriteLine();
            Console.WriteLine("Добавление элемента:" + "\n");
            container.Add(transformer1);
            container.PrintElems();


            Controller controller = new Controller();
            Console.WriteLine("Элементы определенного года:" + "\n");
            controller.SearchYear(container, "2000");
            Console.WriteLine("Трансформеры определенной мощности:" + "\n");
            controller.SearchPower(container, 7);
            controller.Count(container);

        }
    }
}