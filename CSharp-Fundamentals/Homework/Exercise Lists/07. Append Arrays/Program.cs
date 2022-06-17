using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();
            List<string> output = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                string[] arr = list[i].Split("//s+").ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != "")
                    {
                        output.Add(arr[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", output).Trim().Replace("   ", " ").Replace("  ", " "));

        }
    }
}
