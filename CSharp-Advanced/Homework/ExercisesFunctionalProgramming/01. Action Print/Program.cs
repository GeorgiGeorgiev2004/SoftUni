using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToList();
            Action<string> action = (input) => Console.WriteLine(input);
            for (int i = 0; i < input.Count; i++)
            {
              action(input[i]); 
            }
        }
    }
}