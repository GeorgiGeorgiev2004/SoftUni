using System;
using System.Collections.Generic;
using System.Linq;
namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] =Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            }
            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i+1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }
                    for (int j = 0; j < matrix[i + 1].Length; j++)
                    {
                        matrix[i + 1][j] /= 2;
                    }
                }
            }
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                if (input[0] == "End")
                {
                    break;
                }
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                double value = double.Parse(input[3]);
                if (input[0] == "Add")
                {
                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                if (input[0] == "Subtract")
                {
                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}