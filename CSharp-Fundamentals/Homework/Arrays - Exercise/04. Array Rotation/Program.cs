using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arr = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string last = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = last;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
