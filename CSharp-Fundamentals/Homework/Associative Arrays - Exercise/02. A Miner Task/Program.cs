using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> map = new Dictionary<string, double>();
            while (input!="stop")
            {
                double amount = int.Parse(Console.ReadLine());
                if(!map.ContainsKey(input))
                    {
                    map.Add(input, amount);
                }
                else
                {
                    map[input]+=amount;
                }
                input = Console.ReadLine();
            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}