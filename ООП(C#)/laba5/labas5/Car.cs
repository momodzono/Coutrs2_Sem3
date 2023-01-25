using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Car : TransportVehicle
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Car(string type_, string brand_)
        {
            TypeOfVehicle = type_;
            Brand = brand_;
        }
        public Car() { }
        public override string ToString()
        {
            string res = this.TypeOfVehicle + this.Brand;
            return res;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Car: Type - {TypeOfVehicle}, Brand - {Brand}");
        }
    }
}
