using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //обобщение для стандартных типов данных
                //тип int
                GenericTypes<int> objInt = new(23, 15);
                objInt.Print("\nInt: ");

                //тип double
                GenericTypes<double> objDouble = new GenericTypes<double>(7.88, -3.22);
                objDouble.Print("Double: ");


                CollectionType<Transformer> set1 = new CollectionType<Transformer>();
                Transformer transformer1 = new Transformer("1999", 3, "Megatron");
                Transformer transformer2 = new Transformer("2000", 2, "Bumblebee");
                Transformer transformer3 = new Transformer("2001", 5, "Optimus Prime");
                Transformer transformer4 = new Transformer("2002", 4, "Starscream");

                HashSet<Transformer> hashset1 = new HashSet<Transformer>() { transformer1, transformer2, transformer3 };

                set1.Collection = hashset1;
                Console.WriteLine("--------set1---------");
                set1.Show();
                Console.WriteLine("---------Add-----------");
                set1.Add(transformer4);
                set1.Show();
                Console.WriteLine("------Delete-----------");
                set1.Delete(transformer1);
                set1.Show();
                Console.WriteLine();
                Console.WriteLine("-------Read--------");
                Save<Transformer>.WriteToFile(set1.Collection);
                Save<Transformer>.ReadFromFile();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
        }
    }
}
