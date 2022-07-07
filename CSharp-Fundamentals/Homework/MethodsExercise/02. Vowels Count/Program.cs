using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static int VowelCount(char[] arr)
        {
            int br = 0;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (arr[i]==vowels[j])
                    {
                        br++;
                    }
                }
            }
            return br;

        }
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            Console.WriteLine( VowelCount(arr)); 
        }
    }
}
