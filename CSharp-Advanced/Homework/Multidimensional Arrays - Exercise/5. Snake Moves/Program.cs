using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToList();
            string word = Console.ReadLine();
            char[,] a = new char[n[0], n[1]];
            int x = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (x==word.Length)
                        {
                            x = 0;
                        }
                        a[i, j] = word[x];
                        x++;
                    }
                }
                else
                {
                    for (int j = a.GetLength(1)-1; j >= 0; j--)
                    {
                        if (x == word.Length)
                        {
                            x = 0;
                        }
                        a[i, j] = word[x];
                        x++;
                    }
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}