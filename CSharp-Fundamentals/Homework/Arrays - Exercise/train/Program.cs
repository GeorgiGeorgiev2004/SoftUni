using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");

            }
            Console.WriteLine("");
            Console.WriteLine(sum);
        }
    }
}
