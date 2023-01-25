using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] aa = null;
            //Debug.Assert(aa != null, "Values array cannot be null");

            Debug.Indent(); //задает уровень отступа
            Debug.WriteLine("Entering Main");
            Console.WriteLine("Hello World."); //Записывает значение метода ToString() объекта в прослушиватели трассировки в коллекции Listeners.
            Debug.WriteLine("Exiting Main");
            Debug.Unindent();//уменьшает уровень отступа -1

            try
            {
                Human human1 = new Human("Vasya", "1999", 0);
            }
            catch (AgeExceptions ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                StackTrace stack = new StackTrace(ex);
                foreach (StackFrame frame in stack.GetFrames())
                {
                    Console.WriteLine(frame.GetMethod());
                }
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }
            try
            {
                Car car1 = new Car("Car", "");
            }
            catch (CarExceptions ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }
            try
            {
                CarManagement carManagement1 = new CarManagement("Car", "Audi", 'T');
            }
            catch (CarMExceptions ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }
            try
            {
                int a = 0;
                int b = 10 / a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }
            try
            {
                Car car = new Car();
                CarManagement carM = (CarManagement)car;
                Console.WriteLine("Можно привести");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Невозможно привести car к типу CarManagement");
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }

            try
            {
                int[] arr = new int[2] { 0, 2 };
                int q = arr[2];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }

        }
    }
}