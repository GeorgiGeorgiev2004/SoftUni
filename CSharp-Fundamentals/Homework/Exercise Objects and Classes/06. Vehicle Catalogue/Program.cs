using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        { 
            var list = new List<Vechicle>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList<string>();
                if (input[0]=="End")
                {
                    break;
                }
                string type = input[0];
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);
                var vechicle = new Vechicle(type[0].ToString().ToUpper() + type.Substring(1),model,color,horsepower);
                list.Add(vechicle);
            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }
                var desiredVechichle = list.FirstOrDefault(vechicle => vechicle.Model == model);
                Console.WriteLine(desiredVechichle);

            }
            var cars = list.Where(vehicle => vehicle.Type == "Car").ToList();
            var trucks = list.Where(vehicle => vehicle.Type == "Truck").ToList();
            double CarAvrg = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double TruckAvrg = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;
            Console.WriteLine($"Cars have average horsepower of: {CarAvrg:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {TruckAvrg:f2}.");
        }
        class Vechicle 
        {
            public string Type { get; set ; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
            public Vechicle(string type, string model,string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsepower; 
            }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Type: {Type}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {HorsePower}");
                return sb.ToString().TrimEnd();
            }
        }
    }
}
