using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static int Add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
        static int Substract(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(Add(a, b), c));
        }
    }
}
