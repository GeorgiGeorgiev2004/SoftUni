using System;
using System.Linq;
namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++)
            {
                for (int h = i+1; h < nums.Length; h++)
                {
                    if (n-nums[i]==nums[h])
                    {
                        Console.WriteLine(nums[i]+" "+nums[h]);
                    }
                }
            }
        }
    }
}
