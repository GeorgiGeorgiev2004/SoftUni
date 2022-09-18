using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>(Console.ReadLine().Split(", ").ToList());
            while (q.Count>0)
            {
                var inp = Console.ReadLine().Split().ToList();
                switch (inp[0])
                {
                    case "Play":
                        q.Dequeue();
                        break;
                    case "Add":
                        List<string> str = inp;
                        str.RemoveAt(0);
                        string songname = string.Join(" ", str);
                        if (q.Contains(songname))
                        {
                            Console.WriteLine($"{songname} is already contained!");
                        }
                        else
                        {
                            q.Enqueue(songname);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",q));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}