using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (!dic.ContainsKey(input[0]))
                {
                    dic[input[0]] = new Dictionary<string, int>();
                }
                for (int j = 1; j < input.Count(); j++)
                {
                    if (!dic[input[0]].ContainsKey(input[j]))
                    {
                        dic[input[0]].Add(input[j], 0);
                    }
                    dic[input[0]][input[j]]++;
                }
            }
            var lookingfor = Console.ReadLine().Split(' ').ToList();
            foreach (var CBC in dic)
            {
                Console.WriteLine($"{CBC.Key} clothes:");
                foreach (var C in CBC.Value)
                {
                    string output = $"* {C.Key} - {C.Value} ";
                    if (CBC.Key == lookingfor[0] && C.Key == lookingfor[1])
                    {
                        output += "(found!)";
                    }
                    Console.WriteLine(output);
                }
            }
        }
    }
}