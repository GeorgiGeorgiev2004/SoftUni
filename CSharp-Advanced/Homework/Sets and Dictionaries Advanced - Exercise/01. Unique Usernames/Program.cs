using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!list.Contains(name))
                {
                    list.Add(name);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}