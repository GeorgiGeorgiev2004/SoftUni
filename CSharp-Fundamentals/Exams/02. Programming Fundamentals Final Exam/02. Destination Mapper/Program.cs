using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\/|\=)(?<Name>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            int travelpoints = 0;
            MatchCollection validcities = Regex.Matches(input, pattern);
            var finres = new List<string>();
            foreach (Match item in validcities)
            {
                travelpoints += item.Groups["Name"].Length;
                finres.Add(item.Groups["Name"].Value);
            }
            Console.WriteLine($"Destinations: {string.Join(", ",finres)}");
            Console.WriteLine($"Travel Points: {travelpoints}");
        }
    }
}