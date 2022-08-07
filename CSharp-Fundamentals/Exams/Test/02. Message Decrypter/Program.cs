using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex rgx = new Regex(@"^(\$|\%)(?<Tag>[A-Z][a-z]{2,})\1: \[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$");
                MatchCollection matches = rgx.Matches(input);
                if (rgx.IsMatch(input))
                {
                    int a =1;
                    int b = 1;
                    int c = 1;
                    foreach (Match item in matches)
                    {
                        if (item.Groups.Count > 6) 
                        { 
                            Console.WriteLine("Valid message not found!");
                            continue; 
                        }
                        a = int.Parse(item.Groups["2"].Value);
                        b = int.Parse(item.Groups["3"].Value);
                        c = int.Parse(item.Groups["4"].Value);
                        Console.WriteLine($"{item.Groups["Tag"]}: {(char)a+""+ (char)b +""+ (char)c}");
                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
               
            }
        }
    }
}