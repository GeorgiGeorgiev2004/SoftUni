using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                for (int j = 0; j < line.Count(); j++)
                {
                    set.Add(line[j]);
                } 
            }
            Console.WriteLine(String.Join(" ",set.OrderBy(x=>x)));
        }
    }
}