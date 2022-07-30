using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;
namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[\d]+.?([\d]+))\!(?<quan>[\d]+)";
            var list = new List<string>();
            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Purchase")
                {
                    break;
                }
                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (matches.Success) 
                {
                    var name = matches.Groups["name"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quant = int.Parse(matches.Groups["quan"].Value);
                    list.Add(name);
                    sum += price * quant;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}