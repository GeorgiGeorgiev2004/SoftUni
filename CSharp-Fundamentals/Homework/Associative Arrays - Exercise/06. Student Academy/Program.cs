using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dic.ContainsKey(name))
                {
                    dic[name]=new List<double>();
                }
                dic[name].Add(grade);
            }
            foreach (var item in dic)
            {
                if (item.Value.Average()>=4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}