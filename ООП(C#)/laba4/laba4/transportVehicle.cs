using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Транспортное средство:машина:двигатель, управление авто,
//transport vehicle: car: engine, car management, 
namespace lab4
{
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
