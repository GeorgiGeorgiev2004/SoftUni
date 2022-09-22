using System;
using System.Collections.Generic;
using System.Linq;
namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[,] a = new string[n[0], n[1]];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var b = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = b[j];
                }
            }
            List<string> input = new List<string>() {" ","" };
            while (input[0] !="END")
            {
                input = Console.ReadLine().Split(" ").ToList();
                if (input[0]== "END")
                {
                    break;
                }
                if (input[0]!="swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if(input.Count()-1!=4)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if (a.GetLength(0)< int.Parse(input[1])|| a.GetLength(0) < int.Parse(input[3])|| a.GetLength(1) < int.Parse(input[2])|| a.GetLength(1) < int.Parse(input[4]))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string x = a[int.Parse(input[1]), int.Parse(input[2])];
                    a[int.Parse(input[1]), int.Parse(input[2])] = a[int.Parse(input[3]), int.Parse(input[4])];
                    a[int.Parse(input[3]), int.Parse(input[4])] = x;
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write($"{a[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}