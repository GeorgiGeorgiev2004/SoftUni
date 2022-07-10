using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            Dictionary<string, double> basketprice = new Dictionary<string, double>();
            Dictionary<string, double> basketammount = new Dictionary<string, double>();
            while (input[0] != "buy")
            {
                if (!basketprice.ContainsKey(input[0]))
                {
                    basketprice.Add(input[0], double.Parse(input[1]));
                    basketammount.Add(input[0], double.Parse(input[2]));
                }
                else
                {
                    basketprice[input[0]] = double.Parse(input[1]);
                    basketammount[input[0]] += double.Parse(input[2]);
                }
                input = Console.ReadLine().Split().ToArray(); 
            }
            Dictionary<string, double> outputdata = new Dictionary<string, double>();
            foreach (var price in basketprice)
            {
                foreach (var ammount in basketammount)
                {
                    if (price.Key==ammount.Key)
                    {
                        outputdata.Add(price.Key, price.Value * ammount.Value);
                    }
                }

            }
            foreach (var item in outputdata)
            {
                Console.WriteLine($"{item.Key:f2} -> {item.Value:f2}");
            }
        }
    }
}