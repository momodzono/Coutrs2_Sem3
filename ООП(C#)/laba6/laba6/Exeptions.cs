using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class AgeExceptions : Exception
    {
        public new string Message { get; set; }
        public AgeExceptions(string message, int age) : base(message)
        {
            Message = $"AgeExceptions({age}):" + message;
        }
    }

    public class CarExceptions : Exception
    {
        public new string Message { get; set; }
        public CarExceptions(string message, string Brand) : base(message)
        {
            Message = $"CarExceptions({Brand}):" + message;
        }
    }

    public class CarMExceptions : Exception
    {
        public new string Message { get; set; }
        public CarMExceptions(string message, char carCategory) : base(message)
        {
            Message = $"CarManagementExceptions({carCategory}):" + message;
        }
    }
}
