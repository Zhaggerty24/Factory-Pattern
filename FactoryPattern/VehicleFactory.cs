using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car();
                    
                case "Motorcycle":
                    return new Motorcycle();
                    
               default:
                    return new Car();
            }
        }
    }
}
