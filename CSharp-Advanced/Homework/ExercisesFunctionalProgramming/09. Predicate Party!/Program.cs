using System;
using System.Linq;
using System.Collections.Generic;
namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "StartsWith":
                        return s => s.StartsWith(value);
                    case "EndsWith":
                        return s => s.EndsWith(value);
                    case "Length":
                        return s => s.Length == int.Parse(value);
                    default:
                        return default(Predicate<string>);
                }
            }
            while (true)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0]=="Party!")
                {
                    break;
                }
                if (input[0] == "Remove")
                {
                    list.RemoveAll(GetPredicate(input[1], input[2]));
                }
                else
                {
                    List<string> peopleToDouble = list.FindAll(GetPredicate(input[1], input[2]));

                    int index = list.FindIndex(GetPredicate(input[1], input[2]));

                    if (index >= 0)
                    {
                        list.InsertRange(index, peopleToDouble);
                    }
                }
            }
            if (list.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", list)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}