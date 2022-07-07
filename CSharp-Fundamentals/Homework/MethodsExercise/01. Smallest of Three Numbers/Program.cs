using System;

namespace MethodsExercise
{
    class Program
    {
        static int MinNum(int a, int b, int c)
        {
            int min = Math.Min(Math.Min(a, b), c);
            return (min);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(MinNum(a, b, c));
        }
    }
}
