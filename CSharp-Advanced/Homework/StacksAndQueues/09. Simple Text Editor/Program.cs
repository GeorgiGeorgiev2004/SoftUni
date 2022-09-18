using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> commandlist = new Stack<string>();
            commandlist.Push("");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                switch (input[0])
                {
                    case "1":
                        sb.Append(input[1]);
                        commandlist.Push(sb.ToString());
                        break;
                    case "2":
                        sb.Remove(sb.Length - int.Parse(input[1]), int.Parse(input[1]));
                        commandlist.Push(sb.ToString());
                        break;
                    case "3":
                        int s = int.Parse(input[1]);
                        if (s>=1&&s<=sb.Length)
                        {
                            Console.WriteLine(sb[s-1]);
                        }
                        break;
                    case "4":
                        commandlist.Pop();
                        sb = new StringBuilder(commandlist.Peek());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}