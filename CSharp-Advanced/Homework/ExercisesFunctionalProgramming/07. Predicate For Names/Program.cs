using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split().ToList();
            Predicate<string> pred = nz => nz.Length <= n;
            Func<List<string>, List<string>> filter= x=>
            {
                List<string> result = new List<string>();
                foreach (var item in x)
                {
                    if (pred(item))
                    {
                        Console.WriteLine(item);
                    }
                }
                return result;
            };
            filter(list);
        }
    }
}