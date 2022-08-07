using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("-").ToList();
            Dictionary<string, List<string>> meals = new Dictionary<string, List<string>>();
            int mealhate = 0;
            while (input[0]!="Stop")
            {
                string person = input[1];
                string meal = input[2];
                switch (input[0])
                {
                    case "Like":
                        if (meals.ContainsKey(person))
                        {
                            if (meals[person].Contains(meal))
                            {
                                break;
                            }
                            else
                            {
                                meals[person].Add(meal);
                            }

                        }
                        else
                        {
                            meals.Add(person, new List<string>() { meal });
                        }
                        break;
                    case "Dislike":
                        if (meals.ContainsKey(person))
                        {
                            if (meals[person].Contains(meal))
                            {
                                Console.WriteLine($"{person} doesn't like the {meal}.");
                                meals[person].Remove(meal);
                                mealhate++;
                            }
                            else
                            {
                                Console.WriteLine($"{person} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{person} is not at the party.");
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split("-").ToList();
            }
            foreach (var item in meals)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ",item.Value)}");  
            }
            Console.WriteLine($"Unliked meals: {mealhate}");
        }
    }
}