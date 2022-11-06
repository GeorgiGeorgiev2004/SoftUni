using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            var command = Console.ReadLine().Split().ToList();
            for (int i = 0; i < n; i++)
            {
                if (command.Count() == 4)
                {
                    map.Add(command[0], true);
                }
                else 
                {
                    map.Add(command[0], false);
                }

                command = Console.ReadLine().Split().ToList();
            }
            string name = command[0];
            int result = 0;
            while (name!="End")
            {
                if (map.ContainsKey(name))
                {
                    if (map[name]) 
                    {
                        result += 10;
                    }
                    else
                    {
                        result += 5;
                    }
                }
                name = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
