using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (sum+a>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += a;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
