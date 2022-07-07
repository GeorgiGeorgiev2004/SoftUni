using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                char b = char.Parse(Console.ReadLine());
                sum += b;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
