using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split(' ').ToList();
            while (input[0]!= "Finish")
            {
                if (input[0]=="Add")
                {
                    list.Add(int.Parse(input[1]));
                }
                if (input[0] == "Remove")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(input[1]))
                        {
                            list.Remove(list[i]);
                            break;
                        }
                    }
                }
                if (input[0] == "Replace")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]== int.Parse(input[1]))
                        {
                            list[i] = int.Parse(input[2]);
                            break;
                        }
                   }
                }
                if (input[0] == "Collapse")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (int.Parse(input[1])>list[i])
                        {
                            list[i] = 0;
                        }
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
                while (list.Contains(0))
                {
                    list.Remove(0);
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
