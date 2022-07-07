using System;

namespace _10._Top_Number
{
    class Program
    {
        static bool Validation1(int a)
        {
            int sum = 0;
            int a1 = a;
            for (int i = 0; i < a; i++)
            {
                sum += a1 % 10;
                a1 = a1 / 10;
            }
            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Validation2(int a)
        {
            char[] arr = a.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2!=0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (Validation1(i)&&Validation2(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}