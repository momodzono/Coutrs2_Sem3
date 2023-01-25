using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Transformer : IntelligentBeing
    {
        public virtual string year
        {
            get { return Year; }
            set { year = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Transformer(string year_, string name_, int power_)
        {
            Year = year_;
            Name = name_;
            Power = power_;
        }

        public Transformer() { }

        public override string ToString()
        {

            return $"Transformer: Name - {Name}";
        }
        public virtual void Info()
        {
            Console.WriteLine($"Transformer: Year - {Year}, Name - {Name}, Power - {Power}");
        }
        public override bool Equals(object Obj)
        {
            if (Obj == null)
                return false;
            Transformer temp = (Transformer)Obj;
            return temp.Year == Year;
        }
        public override int GetHashCode()
        {
            return 12 * Year.GetHashCode();
        }
        public override bool DoClone()
        {
            return true;
        }
    }
}
