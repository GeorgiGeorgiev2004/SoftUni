using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void CharInRange(char a , char b)
        {
            int min = b;
            int max = a;
            if ((int)a < (int)b)
            {
                max = (int)b;
                min = (int)a;
            }
            for (int i = min+1; i < max; i++)
            {
                Console.Write((char)i+" ");
            }
            
        }
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharInRange(a, b);

        }
    }
}
