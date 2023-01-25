using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разумное существо:человек, трансформер
//intelligent being:human, transformer

namespace lab4
{
    public abstract class IntelligentBeing
    {
        private string year;
        public virtual string Year
        {
            get { return year; }
            set { year = value; }
        }
        public IntelligentBeing(string year_)
        {
            year = year_;
        }
        public IntelligentBeing() { }

        public abstract bool DoClone();
    }
    public class Human : IntelligentBeing
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

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Human(string year_, int age_, string gender_, string country_)
        {
            Year = year_;
            Age = age_;
            Gender = gender_;
            Country = country_;
        }
        public Human() { }
        public override string ToString()
        {
            string result = this.Year + this.Age + this.Gender + this.Country;
            return result;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Human: Year - {Year}, Age - {Age}, Gender - {Gender}, Country - {Country}");
        }
        public override bool DoClone()
        {
            return false;
        }

    }
    public class Transformer : IntelligentBeing
    {
        public virtual string year
        {
            get { return Year; }
            set { year = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Transformer(string year_, int height_, string name_)
        {
            Year = year_;
            Height = height_;
            Name = name_;
        }
        public Transformer() { }

        public override string ToString()
        {
            string res = this.Year + this.Height + this.Name;
            return res;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Transformer: Year - {Year}, Height - {Height}, Name - {Name}");
        }
        public override bool Equals(object Obj)
        {
            if (Obj == null)
                return false;
            Transformer temp = (Transformer)Obj;
            return temp.Height == Height;
        }
        public override int GetHashCode()
        {
            return 12 * Height;
        }
        public override bool DoClone()
        {
            return false;
        }
    }
}