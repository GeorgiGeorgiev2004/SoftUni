using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
            {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number>0)
            {
                sum = sum + number % 10;
                number/= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
