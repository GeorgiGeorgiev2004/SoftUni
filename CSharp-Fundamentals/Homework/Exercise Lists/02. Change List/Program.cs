using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> element = Console.ReadLine().Split(' ').ToList();
            while (element[0] != "end")
            {
                if (element.Count == 2)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(element[1]))
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    list.Insert(int.Parse(element[2]), int.Parse(element[1]));
                }
                element = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

