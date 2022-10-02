using System;
using System.Linq;
using System.Collections.Generic;
namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list= Console.ReadLine().Split(" ").ToList();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "Starts with":
                        return s => s.StartsWith(value);
                    case "Ends with":
                        return s => s.EndsWith(value);
                    case "Length":
                        return s => s.Length == int.Parse(value);
                    case "Contains":
                        return s => s.Contains(value);
                    default:
                        return default(Predicate<string>);
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Print")
                {
                    break;
                }
                string[] input = command.Split(";");
                if (input[0] == "Add filter")
                {
                    filters.Add(input[1] + input[2], GetPredicate(input[1], input[2]));
                }
                else
                {
                    filters.Remove(input[1] + input[2]);
                }
            }
            foreach (var filter in filters)
            {
                list.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}