using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разумное существо:человек, трансформер
//intelligent being:human, transformer

namespace lab6
{
    public abstract class IntelligentBeing
    {
        private string year;
        public virtual string Year
        {
            get { return year; }
            set { year = value; }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public IntelligentBeing(string year_, int power_)
        {
            year = year_;
            Power = power_;
        }
        public IntelligentBeing() { }

        public abstract bool DoClone();
    }
}
