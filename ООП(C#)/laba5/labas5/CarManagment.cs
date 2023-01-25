using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class CarManagement : Car
    {
        private char carCategory;
        public char CarCategory
        {
            get { return carCategory; }
            set { carCategory = value; }
        }
        public CarManagement(string type_, string brand_, char carCategory_)
        {
            TypeOfVehicle = type_;
            Brand = brand_;
            CarCategory = carCategory_;
        }
        public override string ToString()
        {
            string res = this.TypeOfVehicle + this.Brand + this.CarCategory;
            return res;
        }
    }
}
