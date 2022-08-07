using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plan = Console.ReadLine();
            var input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (input[0] != "Travel")
            {
                switch (input[0])
                {
                    case "Add Stop":
                        if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < plan.Length )
                        {
                            plan = plan.Insert(int.Parse(input[1]), input[2]);
                        }
                        Console.WriteLine(plan);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        if (startIndex >= 0 && endIndex >= 0 && startIndex < plan.Length  && endIndex < plan.Length )
                        {
                            plan = plan.Remove(startIndex, endIndex+1 - startIndex);
                        }
                        Console.WriteLine(plan);
                        break;
                    case "Switch":
                        if (plan.Contains(input[1]))
                        {
                            plan = plan.Replace(input[1], input[2]);
                        }
                        Console.WriteLine(plan);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {plan}");
        }
    }
}