using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
                int n = list[0];
                int s = list[1];
                int x = list[2];
                Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
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