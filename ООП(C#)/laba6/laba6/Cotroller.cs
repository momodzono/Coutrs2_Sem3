using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Controller
    {
        public void SearchYear(Container cont, string year)
        {
            foreach (IntelligentBeing item in cont.list)
            {
                if (item.Year == year)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }

        public void SearchPower(Container cont, int power)
        {
            foreach (IntelligentBeing item in cont.list)
            {
                if (item.Power == power)
                    Console.WriteLine(item.ToString() + "\n");
            }
        }

        public void Count(Container cont)
        {
            int count = 0;
            foreach (IntelligentBeing item in cont.list)
            {
                if (item.DoClone())
                    count++;
            }
            Console.WriteLine($"Количество боевых единиц: {count}");
        }
    }
}
