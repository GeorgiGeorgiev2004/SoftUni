using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double max = 0;
            string maxname="";
            for (int i = 0; i < a; i++)
            {
                string name = Console.ReadLine();
                double rad = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double currentmax = Math.PI*rad*rad*height;
                if (currentmax>max)
                {
                    max = currentmax;
                    maxname = name;
                }
            }
            Console.WriteLine(maxname);
        }
    }
}
