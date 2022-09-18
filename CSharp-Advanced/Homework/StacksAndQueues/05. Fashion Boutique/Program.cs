using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int rackMax = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackcount = 0;
            while (stack.Count>0)
            {
                sum += stack.Pop();     
                if (stack.Peek()+sum>rackMax)
                {
                    sum = 0;
                    rackcount++;
                }
                else if (stack.Peek() + sum == rackMax)
                {
                    stack.Pop();
                    sum = 0;
                    rackcount++;
                }
                if (stack.Count==1&&stack.Sum()<rackMax)
                {
                    rackcount++;
                    break;
                }
            }
            Console.WriteLine(rackcount);
        }
    }
}