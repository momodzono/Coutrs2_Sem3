using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.ObjectModel;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlClass<Goods> collection = new ControlClass<Goods>();
            Goods goods1 = new Goods("Milk", 20);
            Goods goods2 = new Goods("Bread", 10);
            Goods goods3 = new Goods("Meat", 50);
            collection.Add(goods1);
            collection.Add(goods2);
            collection.Add(goods3);
            collection.Print();
            Console.WriteLine("--------------");
            collection.Remove(goods2);
            collection.Print();
            Console.WriteLine("--------------");
            Console.WriteLine($"Элемент {goods1.Name} находится в collection: {collection.Contains(goods1)}");
            Console.WriteLine($"Элемент {goods2.Name} находится в collection: {collection.Contains(goods2)}");


            ControlClass<int> collection2 = new ControlClass<int>();
            collection2.Add(0, 2);
            collection2.Add(0, 6);
            collection2.Add(0, 11);
            collection2.Add(0, 1);
            collection2.Add(0, 121);
            collection2.Print();

            Console.Write("Введите n: ");
            string str;
            str = Console.ReadLine();
            int n = Convert.ToInt32(str);
            while (n > 0)
            {
                collection2.RemoveAt(--n);
            }
            Console.WriteLine("------------------------------------");
            collection2.Print();





            LinkedList<int> link = new ();

            for (int i = 0; i < collection2.Count; i++)
            {
                link.AddLast(collection2.Value(i));
            }
            Console.WriteLine("Вторая коллекция:");
            foreach (var item in link)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------");

            int a = 2;
            foreach (int item in link)
            {
                if (item == a)
                {
                    Console.WriteLine("Элемент найден");
                }
            }
            Console.WriteLine("------------------------------------");




            var collection3 = new ObservableCollection<Goods>();
            Goods goods4 = new Goods("Apple", 20);

            collection3.CollectionChanged += Collection3_CollectionChanged;
            collection3.Add(goods4);
            collection3.Remove(goods4);

        }
        private static void Collection3_CollectionChanged(object s, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен новый объект");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален объект");
                    break;
            }
        }
    }
}