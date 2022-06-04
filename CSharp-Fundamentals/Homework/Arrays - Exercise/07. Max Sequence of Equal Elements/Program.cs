using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int maxcount = 0;
            int num = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter > maxcount)
                {
                    maxcount = counter;
                    num = nums[i];
                }
            }
            for (int j = 0; j <= maxcount; j++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
