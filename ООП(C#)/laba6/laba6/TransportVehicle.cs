using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
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
}
