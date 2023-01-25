using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("car", "BMW", 150);
            Car car2 = new Car("car", "Audi", 250);
            Car car3 = new Car("car", "Volkswagen", 300);
            Car car4 = new Car("car", "Volvo", 180);

            Console.WriteLine("-------Binary serialiation--------");
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.dat", FileMode.OpenOrCreate))
            {
                binary.Serialize(fs, car1);
            }
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.dat", FileMode.OpenOrCreate))
            {
                Car newCar1 = (Car)binary.Deserialize(fs);
                Console.WriteLine($"Type: {newCar1.TypeOfVehicle}  Brand: {newCar1.Brand}");
            }

            Console.WriteLine("-------Soap serialiation--------");
            SoapFormatter soap = new SoapFormatter();
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.soap", FileMode.OpenOrCreate))
            {
                soap.Serialize(fs, car2);
            }
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.soap ", FileMode.OpenOrCreate))
            {
                Car newCar2 = (Car)soap.Deserialize(fs);
                Console.WriteLine($"Type: {newCar2.TypeOfVehicle}  Brand: {newCar2.Brand}");
            }

            Console.WriteLine("---------Json serialization---------");
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Car));
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, car3);
            }
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.json", FileMode.OpenOrCreate))
            {
                Car newCar3 = (Car)json.ReadObject(fs);
                Console.WriteLine($"Type: {newCar3.TypeOfVehicle}  Brand: {newCar3.Brand}");
            }


            Console.WriteLine("---------XML serialization----------");
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, car4);
            }
            using (FileStream fs = new FileStream(@"D:\C#\laba13\car.xml", FileMode.OpenOrCreate))
            {
                Car newCar4 = (Car)xml.Deserialize(fs);
                Console.WriteLine($"Type: {newCar4.TypeOfVehicle}  Brand: {newCar4.Brand}");
            }


            Car[] cars = new Car[] { car1, car2, car3, car4 };
            Console.WriteLine("\n-----------XML serialization of objects array ----------");
            XmlSerializer arrxml = new XmlSerializer(typeof(Car[]));
            using (FileStream fs = new FileStream(@"D:\C#\laba13\cars.xml", FileMode.OpenOrCreate))
            {
                arrxml.Serialize(fs, cars);
            }
            using (FileStream fs = new FileStream(@"D:\C#\laba13\cars.xml", FileMode.OpenOrCreate))
            {
                Car[] newCars = (Car[])arrxml.Deserialize(fs);
                foreach (Car c in newCars)
                {
                    Console.WriteLine($"Type: {c.TypeOfVehicle}  Brand: {c.Brand}");
                }
            }

            Console.WriteLine("---------XPath----------------");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\C#\laba13\cars.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList nodes = xRoot.SelectNodes("Car[Brand='BMW']");
            if (nodes != null)//выборка по запросу коллекции узлов 
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.OuterXml + "\n");
            }
            XmlNode node1 = xRoot.SelectSingleNode("Car[2]");
            if (node1 != null)//выбор единственног узла из выборки
            {
                Console.WriteLine(node1.OuterXml + "\n");
            }

            Console.WriteLine("\n---------LINQ to XML----------------");
            XDocument xmlfile = new XDocument();
            XElement head = new XElement("cars");

            XElement elem1 = new XElement("car");
            XElement type1 = new XElement("type", "car");
            XElement brand1 = new XElement("brand", "BMW");
            elem1.Add(type1);
            elem1.Add(brand1);

            XElement elem2 = new XElement("car");
            XElement type2 = new XElement("type", "car");
            XElement brand2 = new XElement("brand", "Audi");
            elem2.Add(type2);
            elem2.Add(brand2);

            XElement elem3 = new XElement("car");
            XElement type3 = new XElement("type", "car");
            XElement brand3 = new XElement("brand", "Volkswagen");
            elem3.Add(type3);
            elem3.Add(brand3);

            XElement elem4 = new XElement("car");
            XElement type4 = new XElement("type", "car");
            XElement brand4 = new XElement("brand", "Volvo");
            elem4.Add(type4);
            elem4.Add(brand4);

            head.Add(elem1);
            head.Add(elem2);
            head.Add(elem3);
            head.Add(elem4);

            xmlfile.Add(head);
            xmlfile.Save(@"D:\C#\laba13\xmlfile.xml");

            Console.WriteLine("LINQ-1: ");
            var linq1 = xmlfile.Elements("cars").Elements("car").Where(n => n.Element("brand")?.Value == "Volkswagen");
            foreach (var x in linq1)
            {
                Console.WriteLine(x + "\n");
            }

            Console.WriteLine("LINQ-2: ");
            var linq2 = from x in xmlfile.Element("cars").Elements("car")
                        orderby (x.Element("brand").Value)
                        select x;
            foreach (var x in linq2)
            {
                Console.WriteLine(x + "\n");
            }


        }
    }
}