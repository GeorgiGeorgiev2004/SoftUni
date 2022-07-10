using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char item in arr)
            {
                if (item!=' ')
                {
                    if (!dic.ContainsKey(item))
                    {
                        dic.Add(item, 1);
                    }
                    else
                    {
                        dic[item]++;
                    }
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}