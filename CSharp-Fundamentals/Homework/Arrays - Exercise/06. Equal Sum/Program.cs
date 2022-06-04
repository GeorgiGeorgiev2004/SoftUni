using System;
using System.Linq;
namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length<=1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftsum = 0;
                for (int f = i; f > 0; f--)
                {
                    int NextElement = f - 1;
                    if (f>0)
                    {
                        leftsum += arr[NextElement];
                    }
                }
                rightsum = 0;
                for (int f = i; f < arr.Length; f++)
                {
                    int NextElement = f + 1;
                    if (f < arr.Length-1)
                    {
                        rightsum += arr[NextElement];
                    }
                }
                if (rightsum==leftsum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
