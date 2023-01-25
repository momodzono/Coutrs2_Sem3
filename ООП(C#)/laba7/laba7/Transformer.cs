using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Transformer
    {
        private string Year;
        public string year
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
            return "Year - " + Year + " Height - " + Height + " Name - " + Name;
        }

    }
}

