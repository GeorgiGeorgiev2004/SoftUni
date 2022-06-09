using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static bool Palindromes(string a)
        {
            char[] arr = a.ToCharArray();
            char[] arr2 = a.ToCharArray();
            Array.Reverse(arr);
            bool k = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=arr2[i])
                {
                    k = false;
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                if (Palindromes(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
    }
}
