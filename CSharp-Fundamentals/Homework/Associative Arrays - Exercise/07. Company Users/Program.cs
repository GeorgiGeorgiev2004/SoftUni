using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> annals = new Dictionary<string, List<string>>();
            while (true)
            {
                var inp = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inp[0]=="End")
                {
                    break;
                }
                var companyname = inp[0];
                var id = inp[1];
                if (!annals.ContainsKey(companyname))
                {
                    annals[companyname] = new List<string>();
                }
                if (annals[companyname].Contains(id)) 
                    continue;
                annals[companyname].Add(id);
            }
            foreach (var company in annals)
            {
                Console.WriteLine(company.Key);
                foreach (var ID in company.Value)
                {                   
                  Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}