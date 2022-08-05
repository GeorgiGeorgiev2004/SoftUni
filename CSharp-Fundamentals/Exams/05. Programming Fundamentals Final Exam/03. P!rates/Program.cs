using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split("||").ToList();
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            while (input1[0]!="Sail")
            {
                string town = input1[0];
                int pop = int.Parse(input1[1]);
                int gold= int.Parse(input1[2]);
                if (cities.ContainsKey(town))
                {
                    cities[town][0] += pop;
                    cities[town][1] += gold;
                }
                else
                {
                    cities.Add(town,new List<int>(){ pop, gold });
                }
                input1 = Console.ReadLine().Split("||").ToList();
            }
            var input2 = Console.ReadLine().Split("=>").ToList();
            while (input2[0]!= "End")
            {
                string town = input2[1];
                switch (input2[0])
                {
                    case "Plunder":
                        int goldtaken = int.Parse(input2[3]);
                        int popkill = int.Parse(input2[2]);
                        cities[town][0]-=popkill;
                        cities[town][1] -= goldtaken;
                        if (cities[town][0]==0|| cities[town][1]==0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} plundered! {goldtaken} gold stolen, {popkill} citizens killed.");
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        else
                        {
                            Console.WriteLine($"{town} plundered! {goldtaken} gold stolen, {popkill} citizens killed.");
                        }
                        break;
                    case "Prosper":
                        int gold = int.Parse(input2[2]);
                        if (gold<0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }
                        else
                        {
                            cities[town][1] +=gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                        }
                        break;
                    default:
                        break;
                }
                input2 = Console.ReadLine().Split("=>").ToList();
            }
            if (cities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to: ");
                foreach (var item in cities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}