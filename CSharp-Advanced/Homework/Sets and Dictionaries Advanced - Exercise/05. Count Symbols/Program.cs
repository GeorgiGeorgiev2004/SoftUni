using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if (!dictionary.ContainsKey(ch))
                {
                    dictionary.Add(ch, 1);
                }
                else
                {
                    dictionary[ch]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}