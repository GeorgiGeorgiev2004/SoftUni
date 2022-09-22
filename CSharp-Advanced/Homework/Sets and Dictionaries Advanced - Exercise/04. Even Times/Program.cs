using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int maxcount = 0;
            int repeatednum = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                int counter=0;
                foreach (var item in list)
                {
                    if (list[i]==item)
                    {
                        counter++;
                    }
                }
                if (counter>maxcount&&counter%2==0)
                {
                    maxcount = counter;
                    repeatednum = list[i];
                }
            }
            Console.WriteLine(repeatednum);
        }
    }
}