using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToList();
            Action<string> action = (input) => Console.WriteLine("Sir "+input);
            for (int i = 0; i < input.Count; i++)
            {
                action(input[i]);
            }
        }
    }
}