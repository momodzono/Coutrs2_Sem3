using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public partial class Human : IntelligentBeing
    {
        public virtual string year
        {
            get { return ("Year of the birth:" + Year); }
            set { year = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Human(string name_, string year_, int age_)
        {
            Name = name_;
            Year = year_;
            Age = age_;
        }

        public Human() { }
        public override string ToString()
        {
            return $"Human: Name - {Name}";
        }
        public virtual void Info()
        {
            Console.WriteLine($"Human: Name - {Name}, Year - {Year}, Age - {Age}");
        }
        public override bool DoClone()
        {
            return true;
        }

    }
}
