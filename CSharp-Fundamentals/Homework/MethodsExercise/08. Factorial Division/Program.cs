using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static double Factoriel(double a)
        {
            double faktor = 1;
            for (double i = a; i > 0; i--)
            {
                faktor *= i; 
            }
            return faktor;
        }
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double sum = Factoriel(a) / Factoriel(b);
            Console.WriteLine(sum.ToString("F2"));
        }
    }
}
