using Microsoft.VisualBasic;
using System;
using System.Text;

namespace ConsoleApplication
{
    class Lab1
    {
        [STAThread]
        static void Main(string[] args)
        {
            //1a Типы
            bool a = true;
            byte b = 255;
            int i = 2147483647;
            short s = 32767;
            long e = 9223372036854775807;
            float f = 3.667f;
            double d = 5.0855676567;
            char ch = 'a';
            string str = "dk";
            decimal de = 6.9745533332235565m;

            Console.WriteLine("Переменная bool :{0}", a);
            Console.WriteLine("Введите bool:");
            a = bool.Parse(Console.ReadLine());
            Console.WriteLine(a);

            Console.WriteLine("Переменная byte :{0}", b);
            Console.WriteLine("Введите byte:");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine(b);

            Console.WriteLine("Переменная int :{0}", i);
            Console.WriteLine("Введите int:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);

            Console.WriteLine("Переменная short :{0}", s);
            Console.WriteLine("Введите short");
            s = short.Parse(Console.ReadLine());
            Console.WriteLine(s);

            Console.WriteLine("Переменная long :{0}", e);
            Console.WriteLine("Введите long");
            e = long.Parse(Console.ReadLine());
            Console.WriteLine(e);

            Console.WriteLine("Переменная float :{0}", f);
            Console.WriteLine("Введите float");
            f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);

            Console.WriteLine("Переменная double :{0}", d);
            Console.WriteLine("Введите double");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);

            Console.WriteLine("Переменная char :{0}", ch);
            Console.WriteLine("Введите char");
            ch = char.Parse(Console.ReadLine());
            Console.WriteLine(s);

            Console.WriteLine("Переменная string :{0}", str);
            Console.WriteLine("Введите string:");
            str = Console.ReadLine();
            Console.WriteLine(str); 

            Console.WriteLine("Переменная decimal :{0}", de);
            Console.WriteLine("Введите decimal:");
            de = decimal.Parse(Console.ReadLine());
            Console.WriteLine(de); 

            //1b
            float z = 4.56f;
            float x = 5.66f;
            byte q = (byte)(z + x);
            long t = (long)(z + x);
            short y = (short)(z + x);
            int l = (int)(z + x);
            sbyte o = (sbyte)(z + x);
            Console.WriteLine("float-->byte: " + q);
            Console.WriteLine("float-->long: " + t);
            Console.WriteLine("float-->short: " + y);
            Console.WriteLine("float-->int: " + l);
            Console.WriteLine("float-->sbyte: " + o);

            byte ii = 5;
            short ss = ii;
            int bb = ss;
            long ll = bb;
            float ff = ll;
            double dd = ff;
            Console.WriteLine("byte-->short-->int-->long-->float-->double:" + dd);

            Console.Write("Введите число: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число: " + g);

            //1c
            int v = 1;
            object w = v; //упаковка из значимого
            int n = (int)w; //распаковка

            //1d
            var p = 4.4;
            var u = 2.5;
            var j = p + u;
            Console.WriteLine(j);

            //1e
            int? val = null;
            Console.WriteLine(val == null);

            //1f
            var ddd = 134;
            ddd = 'd';

            //2a Строки
            string h = "hello";
            string c = "world!";
            Console.WriteLine($"Сравнение 1 и 2 строки: {c == h}");


            //2b
            string hh = "hello";
            string cc = "beautiful";
            string ww = "world gfs !!!";
            Console.WriteLine($"Сцепление строк: {String.Concat(hh, ' ', ww)}");
            Console.WriteLine($"Копирование строк:{String.Copy(cc)}");
            Console.WriteLine($"Выделение подстроки: {cc.Substring(7)}");
            string[] gg = ww.Split(' ');
            foreach (string ggg in gg)
            {
                Console.WriteLine(ggg);
            }
            Console.WriteLine($"Вставка подстроки в заданную позицию: {cc.Insert(6, hh)}");
            Console.WriteLine($"Удаление заданной подстроки: {cc.Remove(6)}");

            //2c
            string kk = "";
            string fff = null;
            Console.WriteLine($"IsNullOrEmpty:{string.IsNullOrEmpty(kk)}");
            Console.WriteLine($"IsNullOrEmpty:{string.IsNullOrEmpty(fff)}");
            Console.WriteLine($"Сцепление строк: {String.Concat(kk, fff)}");
            Console.WriteLine($"Сравнение 1 и 2 строки: {kk == fff}");

            //2d
            StringBuilder ssd = new StringBuilder("summer");
            Console.WriteLine($"Добавление: {ssd.Append(2)} ");
            Console.WriteLine($"Добавление: {ssd.Insert(0, "f")} ");
            Console.WriteLine($"Удаление: {ssd.Remove(3, 2)} ");


            //3a Массивы
            int[,] numbers =
            { { 1, 2, 3 }, { 4, 5, 6 }, { 2, 9, 7 } };
            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.Length / rows;
            for (int iiii = 0; iiii < rows; iiii++)
            {
                for (int jjj = 0; jjj < columns; jjj++)
                {
                    Console.Write($"{numbers[iiii, jjj]} \t");
                }
                Console.WriteLine();
            } 

            //3b
            string[] strings = { "dasha", "masha", "pasha" };
            for (int ee = 0; ee < strings.Length; ee++)
            {
                Console.WriteLine(strings[ee]);
            }
            Console.WriteLine($"Длина массива:{strings.Length}");
            Console.WriteLine("Введите строку,на которую хотите заменить:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите позицию(от 1 до 3):");
            int plase = int.Parse(Console.ReadLine());
            strings[plase-1] = str1;
            Console.WriteLine("Новый массив: ");
            for (int ee = 0; ee < strings.Length; ee++)
            {
                Console.WriteLine(strings[ee]);
            }

            //3c
            double[][] myArr = new double[3][]; 
            myArr[0] = new double[2];//ступенчатый
            myArr[1] = new double[3];
            myArr[2] = new double[4];
            Console.WriteLine();
            Console.WriteLine("Введите элементы в ступенчатый массив: ");
            int cif;
            for (int nn = 0; nn < 2; nn++)
            {
                cif = int.Parse(Console.ReadLine());
                myArr[0][nn] = cif;
            }
            Console.WriteLine();
            for (int nn = 0; nn < 3; nn++)
            {
                cif = int.Parse(Console.ReadLine());
                myArr[1][nn] = cif;
            }
            Console.WriteLine();
            for (int nn = 0; nn < 4; nn++)
            {
                cif = int.Parse(Console.ReadLine());
                myArr[2][nn] = cif;
            }
            Console.WriteLine();
            for (int nn = 0; nn < myArr.Length; nn++)
            {
                for (int m = 0; m < myArr[nn].Length; m++)
                {
                    Console.Write($"{myArr[nn][m]} \t");
                }
                Console.WriteLine();
            }


            //3d
            var mm = new object[0];


            //4a Кортежи
            (int, string, char, string, ulong) xxx = (7, "asdffg", 'a', "poiuyt", 12345);
            
            //4b
            Console.WriteLine($"Первый элемент:{xxx.Item1}");
            Console.WriteLine($"Третий элемент:{xxx.Item3}");
            Console.WriteLine($"Четвертый элемент:{xxx.Item4}");

            //4с
            (string aaa, int bbb) = ("123sdfg", 456);
            Console.WriteLine($"{aaa} {bbb}");
            (int id, string wer, char pou, string lok, ulong utr) = xxx;
            Console.WriteLine($"Распаковка: {id} {lok} {utr}");
            (int idd, _, char pouu, string lokk, ulong utrr) = xxx; //?????

            //4d
            var mmmm = (3, 2, 4, 5, 6, 3, 5);
            var ssss = (3, 2, 4, 5, 5, 3, 0);
            if (mmmm == ssss)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            { Console.WriteLine("Кортежи не равны"); }

            //5
            (int, int, int, char) Localfunction(int[] numbers, string str1)
            {
                int min = numbers.Min();
                int max = numbers.Max();
                int sum = numbers.Sum();

                char smb = str1[0];
                var tuple1 = (min, max, sum, smb);
                return tuple1;
            }

            int[] nums = new int[4];
            nums[0] = 20;
            nums[1] = 30;
            nums[2] = 40;
            nums[3] = 100;
            Console.WriteLine("Массив:");
            for (int r = 0; r < nums.Length; r++)
            {
                Console.WriteLine(nums[r]);
            }
            Console.WriteLine("Строка:");
            string str3 = "abc";
            Console.WriteLine(str3);
            Console.WriteLine($"Кортеж, содержащий max, min, sum, первую букву строки: {Localfunction(nums, str3)}");


            //6
            int z22 = 100;
            int localfunction1()
            {
                int z1 = Int32.MaxValue;
                checked
                {
                    z1 = z1 + z22;
                    Console.WriteLine(z1);
                }
                return z1;
            }
            int localfunction2()
            {
                int z1 = Int32.MaxValue;
                unchecked
                {
                    z1 = z1 + z22;
                    Console.WriteLine(z1);
                }
                return z1;
            }

            Console.WriteLine(localfunction2());//выведется это
            Console.WriteLine(localfunction1());

        }
    }
}