using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            Func<List<int>, List<int>> add = (nums) =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] += 1;
                }
                return nums;
            };
            Func<List<int>, List<int>> multiply = (nums) =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] *= 2;
                }
                return nums;
            };
            Func<List<int>, List<int>> subtract = (nums) =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] -= 1;
                }
                return nums;
            };
            while (input!="end")
            {
                switch (input)
                {
                    case "add":
                        add(nums);
                        break;
                    case "multiply":
                        multiply(nums);
                        break;
                    case "subtract":
                        subtract(nums);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ",nums));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}