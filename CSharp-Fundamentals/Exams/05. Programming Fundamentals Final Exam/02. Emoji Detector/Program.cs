using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long coolthreshhold = 1;
            string input = Console.ReadLine();
            string emojpat = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            string numpat = @"\d";
            MatchCollection emojies = Regex.Matches(input, emojpat);
            MatchCollection numbers = Regex.Matches(input, numpat);
            foreach (Match item in numbers)
            {
                coolthreshhold *= long.Parse(item.Value);
            }
            Console.WriteLine($"Cool threshold: {coolthreshhold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in emojies)
            {
                string emoji = item.Groups["emoji"].Value;
                var charra = emoji.ToCharArray();
                int coolness=0;
                foreach (var ch in charra)
                {
                    coolness += (char)ch;
                }
                if (coolness>coolthreshhold)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}