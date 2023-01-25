using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    sealed class Engine : Car
    {
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public Engine(string type_, string brand_, int power_)
        {
            TypeOfVehicle = type_;
            Brand = brand_;
            Power = power_;
        }
        public override string ToString()
        {
            string res = this.TypeOfVehicle + this.Brand + this.Power;
            return res;
        }
        public override void Info()
        {
            Console.WriteLine($"Car: Type - {TypeOfVehicle}, Brand - {Brand}, Power - {Power}");
        }
    }
}
