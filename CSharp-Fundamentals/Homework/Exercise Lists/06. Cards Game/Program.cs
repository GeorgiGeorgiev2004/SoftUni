using System;
using System.Linq;
using System.Collections.Generic;
namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            while (hand1.Count>0 && hand2.Count>0)
            {
                if (hand1[0]>hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.Add(hand2[0]);
                    hand2.RemoveAt(0);
                    hand1.RemoveAt(0);
                }
                else if (hand2[0] > hand1[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.Add(hand1[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }else if (hand1[0] == hand2[0])
                {
                    hand2.RemoveAt(0);
                    hand1.RemoveAt(0);
                }

            }

            if (hand1.Count>0)
            {
                for (int i = 0; i < hand1.Count; i++)
                {
                    sum += hand1[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < hand2.Count; i++)
                {
                    sum += hand2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
