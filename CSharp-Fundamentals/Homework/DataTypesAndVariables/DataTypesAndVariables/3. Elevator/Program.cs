using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int trips = 0;
            while (a>0)
            {
                trips++;
                a -= b;
                if (b > a && a > 0)
                {
                    trips++;
                    break;
                }
            }
            Console.WriteLine(trips);
        }
    }
}
