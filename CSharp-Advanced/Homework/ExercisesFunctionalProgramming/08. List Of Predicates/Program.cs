using System;
using System.Collections.Generic;
using System.Linq;
namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicts = new List<Predicate<int>>();  
            int endRange = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToHashSet();  
            var numbers = Enumerable.Range(1, endRange).ToList();
            foreach (var divider in dividers)
            {
                predicts.Add(x => x % divider == 0);
            }
            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var match in predicts)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}