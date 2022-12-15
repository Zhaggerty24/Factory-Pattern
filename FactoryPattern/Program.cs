using System.Data.SqlTypes;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle would you like to make? Car or Motorcycle");
            string userInput = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);
            vehicle.Drive();
            Console.ReadLine();

        }
    }
}
