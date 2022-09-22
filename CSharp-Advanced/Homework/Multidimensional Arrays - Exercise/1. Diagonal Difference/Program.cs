using System;
using System.Collections.Generic;
using System.Linq;
namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = b[j];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0,j=n-1; i < n; i++,j--)
            {
                sum1+=a[i,i];
                sum2 += a[j, i];
            }
            Console.WriteLine(Math.Abs(sum1-sum2));
            
        }
    }
}