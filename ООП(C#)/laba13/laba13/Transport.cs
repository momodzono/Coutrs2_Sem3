using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{

    [Serializable]
    public abstract class TransportVehicle
    {
        private string typeOfVehicle;
        public string TypeOfVehicle
        {
            get { return typeOfVehicle; }
            set { typeOfVehicle = value; }
        }
        public TransportVehicle(string type_)
        {
            typeOfVehicle = type_;
        }
        public TransportVehicle() { }
    }

    [Serializable]
    public class Car : TransportVehicle, Interface
    {
        [NonSerialized]
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Car(string type_, string brand_, int speed_)
        {
            TypeOfVehicle = type_;
            Brand = brand_;
            Speed = speed_;
        }
        public Car() { }
        public override string ToString()
        {
            string res = this.TypeOfVehicle + this.Brand;
            return res;
        }
        void Interface.Info()
        {
            Console.WriteLine($"Car: Type - {TypeOfVehicle}, Brand - {Brand}, Speed - {Speed}");
        }
    }
}

