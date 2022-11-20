using System;
using System.Linq;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CarInfo = Console.ReadLine().Split().ToList();
            Car car = new Car(double.Parse(CarInfo[1]), double.Parse(CarInfo[2]));
            var TruckInfo = Console.ReadLine().Split().ToList();
            Truck truck = new Truck(double.Parse(CarInfo[1]), double.Parse(CarInfo[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
            }
        }
    }
}
