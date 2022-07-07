using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void NxN(int n) 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(n+" ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                NxN(n);
                Console.WriteLine();
            }
        }
    }
}
