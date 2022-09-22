using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n =Console.ReadLine().Split().Select(int.Parse).ToList();
            string[,] a = new string[n[0], n[1]];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var b = Console.ReadLine().Split(" ").ToArray();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = b[j];
                }
            }
            int counter = 0;
            for (int i = 0; i < a.GetLength(0)-1; i++)
            {
                for (int j = 0; j < a.GetLength(1)-1; j++)
                {
                    string b = a[i+1,j];
                    string c = a[i + 1, j+1];
                    string d = a[i , j+1];
                    string e = a[i , j];
                    if (b==c&&c==d&&d==e)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}