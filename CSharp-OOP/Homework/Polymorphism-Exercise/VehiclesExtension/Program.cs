using System;
using System.Text;
using VehiclesExtension;

namespace VehiclesExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = (Car)Factory();
            Truck truck = (Truck)Factory();
            Bus bus = (Bus)Factory();
            int cnt = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            while (cnt > 0)
            {
                string command = Console.ReadLine().Trim();
                string[] data = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = data[0] + data[1];
                action = action.ToLower();
                double argument = double.Parse(data[2]);

                switch (action)
                {
                    case "drivecar":
                        Console.WriteLine(car.Drive(argument));
                        break;
                    case "drivetruck":
                        Console.WriteLine(truck.Drive(argument));
                        break;
                    case "drivebus":
                        bus.FullOREmpty(true);
                        Console.WriteLine((bus.Drive(argument)));
                        break;
                    case "driveemptybus":
                        bus.FullOREmpty(false);
                        Console.WriteLine((bus.Drive(argument)));
                        break;
                    case "refuelcar":
                        car.Refuel(argument);
                        break;
                    case "refuelbus":
                        bus.Refuel(argument);
                        break;
                    case "refueltruck":
                        truck.Refuel(argument);
                        break;
                }
                cnt--;
               
            }
            //Console.WriteLine(str.ToString().TrimEnd().Trim());
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
            
        private static Vehicle Factory()
        {
            string[] part = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double fuelQty = double.Parse(part[1]);
            double fuelConsumption = double.Parse(part[2]);
            double tankcap = double.Parse(part[3]);
            switch (part[0])
            {
                case "Car":
                        return new Car(fuelQty, fuelConsumption, tankcap);
                case "Truck":
                        return new Truck(fuelQty, fuelConsumption, tankcap);
                case "Bus":
                        return new Bus(fuelQty, fuelConsumption, tankcap);
                default:
                    return null;
            }
        }
    }
}