using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = list[0];
            int s = list[1];
            int x = list[2];
            Queue<int> stack = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = stack.Min();
                Console.WriteLine(min);
            }
        }
    }
}