using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;
namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pt = @"%\b(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quant>[\d]+)\|[^|$%.]*?(?<price>[\d]+[.]*?([\d]*))?\$";
            double sum = 0;
            while (input != "end of shift")
            {
                Match matches = Regex.Match(input, pt);
                Regex regex = new Regex(pt);
                if (regex.IsMatch(input)) 
                {
                var name = matches.Groups["name"].Value;
                var product = matches.Groups["product"].Value;
                var quant = double.Parse(matches.Groups["quant"].Value);
                var price = double.Parse(matches.Groups["price"].Value);
                double sumpp = quant * price;
                sum += sumpp;
                Console.WriteLine($"{name}: {product} - {sumpp:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}