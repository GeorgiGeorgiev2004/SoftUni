using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[,] a = new int[n[0], n[1]];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var b = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = b[j];
                }
            }
            int maxsum = 0;
            int maxstartcharR = 0;
            int maxstartcharC = 0;
            for (int i = 0; i < a.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < a.GetLength(1) - 2; j++)
                {
                    int sum = a[i, j] + a[i, j + 1] + a[i, j + 2] +
                              a[i + 1, j] + a[i + 1, j + 1] + a[i + 1, j + 2] +
                              a[i + 2, j] + a[i + 2, j + 1] + a[i + 2, j + 2];
                    if (sum>maxsum)
                    {
                        maxstartcharC = j;
                        maxstartcharR = i;
                        maxsum = sum;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxsum);
            for (int i = maxstartcharR; i < maxstartcharR + 3; i++)
            {
                for (int j = maxstartcharC; j < maxstartcharC + 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}