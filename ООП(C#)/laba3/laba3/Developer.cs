using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class Set
    {
    public Production production;

        public class Developer
        {
            public int id;
            public string fio;

            public Developer(int id, string fio)
            {
                this.id = id;
                this.fio = fio;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Владелец - ID: {id}, ФИО: {fio}");
            }
        }
    }

    public class Production
    {
        public int id;
        public string name;

        public Production(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($" ID: {id}, Организация: {name}");
        }
    }
}
