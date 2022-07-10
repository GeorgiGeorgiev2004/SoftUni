using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> Course = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                if (!Course.ContainsKey(input[0]))
                {
                    Course[input[0]]=new List<string>();
                }
                Course[input[0]].Add(input[1]);
                input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var KeyValue in Course)
            {
                Console.WriteLine($"{KeyValue.Key}: {KeyValue.Value.Count}");
                foreach (var item in KeyValue.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}