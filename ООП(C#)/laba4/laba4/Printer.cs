using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Printer
    {
        public string IAmPrinting(Car someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Human someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Transformer someobj)
        {
            return someobj.ToString();
        }
    }
}
