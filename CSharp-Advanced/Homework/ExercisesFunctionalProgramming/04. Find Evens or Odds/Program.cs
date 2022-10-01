using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var limit = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isodd = Console.ReadLine() == "odd";
            List<int> list = new List<int>();
            List<int> output = new List<int>();
            Predicate<int> even = num => num % 2 == 0;
            Predicate<int> odd = num => num % 2 != 0;
            for (int i = limit[0]; i <= limit[1]; i++)
            {
               list.Add(i);
            }
            if (isodd)
            {
                output = list.FindAll(odd);
            }
            else
            {
                output = list.FindAll(even);
            }
            Console.WriteLine(String.Join(" ",output));
        }
    }
}