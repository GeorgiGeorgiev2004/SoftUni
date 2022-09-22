using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var NnM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = NnM[0];
            int m = NnM[1];
            HashSet<int> setn = new HashSet<int>();
            HashSet<int> setm = new HashSet<int>();
            HashSet<int> setfin = new HashSet<int>(); ;
            for (int i = 0; i < n; i++)
            {
                setn.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                setm.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int i in setn) 
            {

                foreach (var item in setm)
                {
                    if (i==item)
                    {
                        setfin.Add(i);
                    }
                }
            }
            Console.WriteLine(String.Join(" ",setfin));
        }
    }
}