using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (long i = 0; i < arr.Length; i++)
            {
                bool isItBigger = true;
                for (long j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
