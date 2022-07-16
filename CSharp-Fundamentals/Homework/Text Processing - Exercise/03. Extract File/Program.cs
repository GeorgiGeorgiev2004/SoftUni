using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('\\').ToList();
            List<string> elements = input[input.Count - 1].Split('.').ToList();
            Console.WriteLine($"File name: {elements[0]}");
            Console.WriteLine($"File extension: {elements[1]}");
        }
    }
}