using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            Console.WriteLine(q.Max());
            while (q.Count > 0)
            {
                if (amount >= q.Peek())
                {
                    amount-= q.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", q)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");

        }
    }
}