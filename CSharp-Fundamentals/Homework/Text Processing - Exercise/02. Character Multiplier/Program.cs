using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string firstword = input[0];
            string secondword = input[1];
            int a = CharMultiplyer(firstword, secondword);
            Console.WriteLine(a);
        }
        public static int CharMultiplyer(string a,string b) 
        {
            char[] chara = a.ToCharArray();
            char[] charb = b.ToCharArray();
            int totalsum = 0;
            if (chara.Length>charb.Length)
            {
                int diff = chara.Length - charb.Length;
                for (int i = 0; i < charb.Length; i++)
                {
                    totalsum += chara[i] * charb[i];
                }
                for (int i = charb.Length; i < chara.Length; i++)
                {
                    totalsum += chara[i];
                }
            }
            else if (chara.Length < charb.Length)
            {
                int diff = charb.Length - chara.Length;
                for (int i = 0; i < chara.Length; i++)
                {
                    totalsum += charb[i] * chara[i];
                }
                for (int i = chara.Length; i < charb.Length; i++)
                {
                    totalsum += charb[i];
                }
            }
            else
            {
                for (int i = 0; i < chara.Length; i++)
                {
                    totalsum += chara[i] * charb[i];
                }
            }
            return totalsum;
        }
    }
}