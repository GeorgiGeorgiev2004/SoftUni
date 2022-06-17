using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int limit = int.Parse(Console.ReadLine());
            List<string> pass = Console.ReadLine().Split(' ').ToList();
            while (pass[0]!="end")
            {
                
                if (pass.Count==2)
                {
                    wagons.Add(int.Parse(pass[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+int.Parse(pass[0])<=limit)
                        {
                            wagons[i] += int.Parse(pass[0]);
                            break;
                        }
                    }
                }
                pass= Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
