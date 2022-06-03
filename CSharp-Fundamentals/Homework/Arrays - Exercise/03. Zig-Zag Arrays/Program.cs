using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] combinedarr1 = new int[n];
            int[] combinedarr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    combinedarr1[i] = arr1[0];
                    combinedarr2[i] = arr1[1];
                }
                else
                {
                    combinedarr1[i] = arr1[1];
                    combinedarr2[i] = arr1[0];
                }
            }
            Console.WriteLine(string.Join(" ",combinedarr1));
            Console.WriteLine(string.Join(" ", combinedarr2));
        }
    }
}
