using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string b = "Stefan";
            Console.WriteLine(int.TryParse(b , out a));
        }
    }
}
