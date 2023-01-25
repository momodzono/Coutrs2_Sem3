using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Goods
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Goods(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
