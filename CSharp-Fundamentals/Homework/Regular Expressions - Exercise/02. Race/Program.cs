using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;
namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern1 =new Regex(@"(?<names>[A-Za-z])") ;
            string pattern2 = @"(?<digits>\d+)";
            var names = Console.ReadLine().Split(", ").ToList();
            var participants = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                int sum = 0;
                MatchCollection matchednames = pattern1.Matches(input);
                MatchCollection matcheddigits = Regex.Matches(input,pattern2);
                string currName = string.Join("", matchednames);
                string currDigits = string.Join("", matcheddigits);
                for (int i = 0; i < currDigits.Length; i++)
                {
                    sum += int.Parse(currDigits[i].ToString());
                }
                if (names.Contains(currName))
                {
                    if (!participants.ContainsKey(currName))
                    {
                        participants.Add(currName, sum);
                    }
                    else
                    {
                        participants[currName] += sum;
                    }
                }

                input = Console.ReadLine();
            }
            var winners = participants.OrderByDescending(x => x.Value).Take(3);
            var firstplace = winners.Take(1);
            var secondplace = winners.OrderByDescending
                (x => x.Value).Take(2).OrderBy
                (x => x.Value).Take(1);
            var thirdplace = winners.OrderBy(x => x.Value).Take(1);
            foreach (var fp in firstplace)
            {
                Console.WriteLine($"1st place: {fp.Key}");
            }
            foreach (var sp in secondplace)
            {
                Console.WriteLine($"2nd place: {sp.Key}");
            }
            foreach (var tp in thirdplace)
            {
                Console.WriteLine($"3rd place: {tp.Key}");
            }
        }
    }
}