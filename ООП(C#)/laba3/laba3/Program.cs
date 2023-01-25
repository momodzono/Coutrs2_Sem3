using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using lab3;


namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set1 = new Set(1, "First Set");
            set1.AddItem("Masha");
            set1.AddItem("Yana");
            set1.AddItem("Dima");
            set1.AddItem("Diana");
            set1.AddItem("Nikita");
            set1.AddItem("Vova");
            set1.AddItem("Kostya");

            Set set2 = new Set(2, "Second Set");
            set2.AddItem("Dasha");
            set2.AddItem("Nastya");
            set2.AddItem("Roma");

            Set set3 = new Set(3, "Third Set");
            set3.AddItem("Anna");
            set3.AddItem("Sasha");
            set3.AddItem("Vlad");
            set3.AddItem("Ruslan");

            Console.WriteLine("____________Перегрузка оператора + ____________________ ");
            string it = "Vova";
            set1 = set1 + it;
            set1.Show();
            Console.WriteLine("____________Перегрузка оператора + ____________________ ");
            set2 = set2 + set1;
            set2.Show();
            Console.WriteLine("____________Перегрузка оператора * ____________________ ");
            set3 = set3 * set1;
            set3.Show();
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine($"Мощность множества №1: {(int)set1}");

            if (set1)
            {
                Console.WriteLine("Входит в диапазон");
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }

            Set.Developer Ann = new Set.Developer(15, "Ann");
            Set.Developer Max = new Set.Developer(7, "Max");
            Set OTS = new Set(1, "OTS");
            OTS.production = new(12, "");
            Set SPP = new Set (17, "SPP");
            SPP.production = new(12, "");

            //Создайте статический класс StatisticOperation, содержащий 3 метода для
            //работы с вашим классом(по варианту п.1): сумма, разница между
            //максимальным и минимальным, подсчет количества элементов
            Console.WriteLine("_______________________________________________________");
            set1.Show();
            int max = set1.Max();
            Console.WriteLine($"Максимальная длина слова: {max}");
            int min = set1.Min();
            Console.WriteLine($"Минимальная длина слова: {min}");
            int dif = set1.Dif();
            Console.WriteLine($"Разница: {dif}");
            int sum = set1.Sum();
            Console.WriteLine($"Количество букв во множестве: {sum}");

            int kol = set1.GetSize();
            Console.WriteLine($"Количество элементов: {kol}");


            Console.WriteLine("-----------Удаление повторяющихся элементов-------------------");
            set1.RemoveDubl();
            set1.Show();

            Console.WriteLine("--------------------Добавление запятой после каждого слова-------------------------");
            set1.CommaAtTheEnd();
            set1.Show();



        }
    }
}