using System;

namespace Laba8
{
    class Program
    {
        delegate int Expression(int x, int y);
        static void Main(string[] args)
        {
            Expression ex = (x, y) => (x + y) * 2;
            int a = ex(2, 3);
            Console.WriteLine(a);
            Console.WriteLine("----------------------------------------");


            Director d1 = new Director(3000, "Директор");
            Director d2 = new Director(4500, "Токарь");
            Director d3 = new Director(5000, "Студент");
            ClassEvent CE = new ClassEvent();

            d1.fine += CE.DoFine;
            d1.increase += CE.DoIncrease;
            d2.fine += CE.DoFine;
            d3.increase += CE.DoIncrease;


            d1.Action(7000, "Финансовый директор");
            Console.WriteLine("----------------------------------------");
            d2.Action(4700, "Токарь");
            Console.WriteLine("----------------------------------------");
            d3.Action(5000, "Токарь");



            string str = "P.   O- i?  T k-l,a ss";
            Func<string, string> A;

            Console.WriteLine("--------------Работа со строками--------------");
            A = Str.RemoveS;
            Console.WriteLine($"Без знаков препинания:\nСтрока до: {str}\nПосле: {A(str)}\n");
            A = Str.RemoveSpase;
            Console.WriteLine($"Убрать пробелы:\nСтрока до: {str}\nПосле: {A(str)}\n");
            A = Str.Upper;
            Console.WriteLine($"Заглавные буквы:\nСтрока до: {str}\nПосле: {A(str)}\n");
            A = Str.Letter;
            Console.WriteLine($"Прописные буквы:\nСтрока до: {str}\nПосле: {A(str)}\n");
            A = Str.AddToString;
            Console.WriteLine($"Добавление символов:\nСтрока до: {str}\nПосле: {A(str)}\n");
        }
    }
}