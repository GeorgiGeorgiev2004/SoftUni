using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = input[0];
                int rarity = int.Parse(input[1]);
                if (plants.ContainsKey(name))
                {
                    plants[name][0] = rarity;
                }
                else
                {
                    plants.Add(name, new List<int>() { rarity,0 });
                }
            }
            var input1 = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (input1[0]!= "Exhibition")
            {
                if (!plants.ContainsKey(input1[1].Split(" - ",StringSplitOptions.RemoveEmptyEntries).ToList()[0]))
                {
                    Console.WriteLine("error");
                }
                if (input1[0]=="Rate")
                {
                    string plantname = input1[1].Split(" - ").ToList()[0]; 
                    int plantrating = int.Parse(input1[1].Split(" - ").ToList()[1]);
                    if (plants.ContainsKey(plantname))
                    {
                        plants[plantname][1] = plantrating;
                    }
                    else plants[plantname][1]= plantrating;
                }
                else if (input1[0] == "Update")
                {
                    string plantname = input1[1].Split(" - ").ToList()[0];
                    int plantrarity = int.Parse(input1[1].Split(" - ").ToList()[1]);
                    plants[plantname][0] =plantrarity;
                }
                else if (input1[0] == "Reset")
                {
                    string plantname = input1[1].Split(" - ").ToList()[0];
                    plants[plantname][1] = 0;
                }
                input1 = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();   
            }
            Console.WriteLine("Plants for the exhibition: ");
                foreach (var item in plants)
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
                }

        }
    }
}