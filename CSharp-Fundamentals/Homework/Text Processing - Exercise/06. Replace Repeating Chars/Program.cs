using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char[] chars = a.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i-1] == chars[i])
                {
                    continue;
                }
                else
                {
                    sb.Append(chars[i-1]);
                }  
            }sb.Append(chars[chars.Length-1]);
            Console.WriteLine(sb);
        }
    }
}