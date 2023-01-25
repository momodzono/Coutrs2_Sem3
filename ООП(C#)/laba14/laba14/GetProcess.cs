using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb14
{
    static public class GetProcess
    {
        public static void GetAllProcess()
        {
            var process = Process.GetCurrentProcess();//псевдоскриптор текущего процесса
            using (StreamWriter sr = new("Ex1.txt", false))
            {
                sr.WriteLine($"Текущий процесс:\nID: {process.Id} Имя: {process.ProcessName}  Используемая виртуальная память: {process.VirtualMemorySize64}");
                Console.WriteLine($"Текущий процесс:\nID: {process.Id} Имя: {process.ProcessName}  Используемая виртуальная память: {process.VirtualMemorySize64}");
                Console.WriteLine($"---------------------------");

                foreach (var proc in Process.GetProcesses()) //возвращает массив всех запущенных процессов
                {
                    sr.WriteLine("Имя потока: " + proc.ProcessName);
                    sr.WriteLine("Id потока: " + proc.Id);
                    sr.WriteLine("Приоритет потока: " + proc.BasePriority);
                    Console.WriteLine("Имя потока: " + proc.ProcessName);
                    Console.WriteLine("Id потока: " + proc.Id);
                    Console.WriteLine("Приоритет потока: " + proc.BasePriority);

                    try
                    {
                        sr.WriteLine("Start time: " + proc.StartTime);
                        Console.WriteLine("Start time: " + proc.StartTime);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
