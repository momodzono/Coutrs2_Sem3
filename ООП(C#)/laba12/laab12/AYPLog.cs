using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace lab12
{
    public class AYPLog
    {
        private const string path = @"D:\C#\laab12\AYPlog.txt";
        public static StreamWriter fw;

        static AYPLog() => fw = new StreamWriter(path, false);

        public static void Write(string str) => fw.WriteLine(str);

        //6
        public static void GetInfoByDay(string date, int from, int to, string key)
        {
            fw.Close();
            string res = "";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string[] infos = sr.ReadToEnd().Split('\n');
                string str = "";
                Console.WriteLine("Действия пользователя за определенный день: ");
                foreach (var s in infos)
                {
                    str += s;
                    str += '\n';
                    if (s.Contains(date))
                    {
                        Console.WriteLine(str);
                        str = "";
                    }

                }
                str = "";
                int k = 0;
                foreach (var s in infos)
                {
                    if (s.Contains(key))
                    {
                        Console.WriteLine("\nИнформация по ключевому слову:");
                        while (infos[k] != "\r")
                        {
                            Console.WriteLine(infos[k]);
                            k++;
                        }
                    }
                    k++;
                }
                Console.WriteLine("\nДействия пользователя за промежуток времени: ");
                for (int i = from; i <= to; i++)
                {
                    string time = i.ToString();
                    time += ".";
                    k = 0;
                    foreach (var s in infos)
                    {
                        if (s.Contains(time))
                        {
                            int buf = k;
                            while (infos[k] != "\r" && k != 0)
                            {
                                Console.WriteLine(infos[k]);
                                k--;
                            }
                            k = buf;
                        }
                        k++;
                    }
                    time = "";
                }
            }
            fw = new StreamWriter(path, true, Encoding.Default);
        }

        public static int GetRecordCount()
        {
            fw.Close();
            int res = 0;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                res = sr.ReadToEnd().Split('$').Where(s => s.StartsWith("Session") == false).Count();
            }
            fw = new StreamWriter(path, true, Encoding.Default);
            return res;
        }

        public static void Del(string time)
        {
            string hours = time.Substring(0, 2);
            fw.Close();
            int k = 0;
            string str = "";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string[] infos = sr.ReadToEnd().Split('\n');


                foreach (var s in infos)
                {
                    if (s.Contains(hours))
                    {
                        int buf = k;
                        while (infos[k] != "\r" && k != 0)
                        {
                            str += infos[k];
                            str += "\n";
                            k--;

                        }
                        k = buf;
                    }
                    k++;
                }
                Console.WriteLine("=======================================================================");
            }

            fw = new StreamWriter(path, false, Encoding.Default);
            fw.WriteLine(str);
        }

        public static void Close() => fw.Close();
    }
}
