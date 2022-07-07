using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void MidChar(string a)
        {
            char[] arr= a.ToCharArray();
            if (arr.Length % 2==0)
            {
                int b = arr.Length / 2;
                Console.WriteLine(arr[b-1]+""+arr[b]);
            }
            else
            {
                int b = arr.Length / 2;
                Console.WriteLine(arr[b] );
            }
        
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            MidChar(a);
        }
    }
}
