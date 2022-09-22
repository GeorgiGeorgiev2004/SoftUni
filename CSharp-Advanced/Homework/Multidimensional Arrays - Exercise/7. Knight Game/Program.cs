using System;
using System.Collections.Generic;
using System.Linq;
namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size<=2)
            {
                Console.WriteLine(0);return;
            }
            char[,] matrix = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int count = 0;
            while (true)
            {
                int countAtack = 0;
                int rowAtack = 0;
                int colAtack = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (matrix[i,j]=='K')
                        {
                            int attackedKnights = CountAttacked(i, j, size, matrix);
                            if (countAtack<attackedKnights)
                            {
                                countAtack = attackedKnights;
                                rowAtack = i;
                                colAtack = j;
                            }
                        }
                    }
                }
                if (countAtack == 0)
                { 
                   break;
                }
                else
                {
                    matrix[rowAtack, colAtack] = '0';
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static int CountAttacked(int row, int col, int size, char[,] matrix)
        {
            int attackedKnights = 0;
            if (IsValid(row-1,col-2,size))
            {
                if (matrix[row-1,col-2]=='K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 1, col - 2, size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            return attackedKnights;
        }
        static bool IsValid(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}