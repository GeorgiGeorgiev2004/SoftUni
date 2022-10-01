using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Func<List<int>, int> fnc = (list) =>
            {
                int ans = int.MaxValue;
                foreach (var item in list)
                {
                    if (item<ans)
                    {
                        ans = item;
                    }
                }
                return ans;
            };
            Console.WriteLine(fnc(list));
        }
    }
}