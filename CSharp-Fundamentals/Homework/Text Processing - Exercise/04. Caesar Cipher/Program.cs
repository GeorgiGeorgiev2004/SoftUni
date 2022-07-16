using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char ch in chars)
            {
                if (ch==null)
                {
                    sb.Append("#");
                    continue;
                }
                char newchar = (char)(ch + 3);
                sb.Append(newchar);
            }
            Console.WriteLine(sb);
        }
    }
}