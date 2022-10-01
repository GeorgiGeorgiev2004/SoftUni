using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colection = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> divisible = num => num % n == 0;
            Func<List<int>, List<int>> fnc = (colection) =>
            {
                List<int> result = new List<int>();
                foreach (var item in colection)
                {
                    if (!divisible(item))
                    {
                        result.Add(item);
                    }
                }
                return result;
            };
            Func<List<int>, List<int>> reverse = colection =>
            {
                List<int> result = new List<int>();
                for (int i = colection.Count - 1; i >= 0; i--)
                {
                    result.Add(colection[i]);
                }
                return result;  
            };
            colection = fnc(colection);
            colection = reverse(colection); 
            Console.WriteLine(String.Join(" ", colection));
        }
    }
}