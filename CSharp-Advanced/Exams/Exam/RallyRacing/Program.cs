using System;
using System.Collections.Generic;
using System.Linq;

namespace RallyRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string CarNumber = Console.ReadLine();
            char[,] matrix = new char[n, n];
            bool reachedFinish = false;
            int TracedCarRow = 0;
            int TracedCarCol = 0;
            int Tunnel1Row = 0;
            int Tunnel1Col = 0;
            int Tunnel2Row = 0;
            int Tunnel2Col = 0;
            int finishRow = 0;
            int finishCol = 0;
            int kilometers = 0;
            bool hasTunnelStart = false;
            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().Where(x => !char.IsWhiteSpace(x)).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'T' && hasTunnelStart == false)
                    {
                        Tunnel1Col = col;
                        Tunnel1Row = row;
                        hasTunnelStart = true;
                    }
                    else if (matrix[row, col] == 'T' && hasTunnelStart)
                    {
                        Tunnel2Col = col;
                        Tunnel2Row = row;
                    }
                    if (matrix[row, col] == 'F')
                    {
                        finishRow = row;
                        finishCol = col;
                    }
                }
            }
            string command = Console.ReadLine();

            while (true)
            {
                if (command=="End")
                {
                    matrix[TracedCarRow, TracedCarCol] = 'C';
                    break;
                }
                char steppedOn = ' ';
                int steppedOnRow = 0;
                int steppedOnCol = 0;
                if (reachedFinish==false)
                {
                    switch (command)
                    {
                        case "up":
                            TracedCarRow--;
                            steppedOn = matrix[TracedCarRow, TracedCarCol];
                            steppedOnRow = TracedCarRow;
                            steppedOnCol = TracedCarCol;
                            break;
                        case "down":
                            TracedCarRow++;
                            steppedOn = matrix[TracedCarRow, TracedCarCol];
                            steppedOnRow = TracedCarRow;
                            steppedOnCol = TracedCarCol;
                            break;
                        case "left":
                            TracedCarCol--;
                            steppedOn = matrix[TracedCarRow, TracedCarCol];
                            steppedOnRow = TracedCarRow;
                            steppedOnCol = TracedCarCol;
                            break;
                        case "right":
                            TracedCarCol++;
                            steppedOn = matrix[TracedCarRow, TracedCarCol];
                            steppedOnRow = TracedCarRow;
                            steppedOnCol = TracedCarCol;
                            break;
                        default:
                            break;
                    }
                    if (steppedOn == 'F')
                    {
                        kilometers += 10;
                        matrix[finishRow, finishCol] = 'C';
                        reachedFinish = true;
                    }
                    if (steppedOn == '.')
                    {
                        kilometers += 10;
                    }
                    if (steppedOn == 'T')
                    {
                        kilometers += 30;
                        if (steppedOnRow == Tunnel1Row && steppedOnCol == Tunnel1Col)
                        {
                            matrix[Tunnel1Row, Tunnel1Col] = '.';
                            TracedCarCol = Tunnel2Col;
                            TracedCarRow = Tunnel2Row;
                            matrix[Tunnel2Row, Tunnel2Col] = '.';
                        }
                        if (steppedOnRow == Tunnel2Row && steppedOnCol == Tunnel2Col)
                        {
                            matrix[Tunnel2Row, Tunnel2Col] = '.';
                            TracedCarCol = Tunnel1Col;
                            TracedCarRow = Tunnel1Row;
                            matrix[Tunnel1Row, Tunnel1Col] = '.';
                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (reachedFinish)
            {
                Console.WriteLine($"Racing car {CarNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {CarNumber} DNF.");
            }
            Console.WriteLine($"Distance covered {kilometers} km.");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}