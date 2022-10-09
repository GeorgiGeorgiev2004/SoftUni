using System;
using System.Linq;
using System.Collections.Generic;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var props = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string model = props[0];
                double fuelamount = double.Parse(props[1]);
                double consumption = double.Parse(props[2]);
                Car car = new Car(model,fuelamount,consumption);
                cars.Add(car);
            }
            var coms = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (coms[0]!="End")
            {
                foreach (var car in cars)
                {
                    if (car.Model == coms[1])
                    {
                        car.Drive(double.Parse(coms[2]), car);
                    }
                }
                coms = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
