using System;
using System.Collections.Generic;
using System.Linq;
namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool valid = false;
            foreach (var y in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && y == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && y == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && y == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(y);
            }
            if (!stack.Any())
            {
                valid = true;
            }
            if (valid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}