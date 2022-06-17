using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double average = list.Average();
            List<int> aboveaverage = new List<int>();
            List<int> top5 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    aboveaverage.Add(list[i]);
                }
            }
            aboveaverage.Sort();
            aboveaverage.Reverse();
            if (aboveaverage.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (aboveaverage.Count <= 5)
            {
                Console.WriteLine(string.Join(" ", aboveaverage));
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(aboveaverage[i] + " ");
                }
            }
            
           
        }
    
    }
}
