using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> list =new List<string>();
            for (int i = 0; i < num; i++)
            {
                List<string> name = Console.ReadLine().Split(' ').ToList();
                if (name[2]=="going!")
                {
                    if (list.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                    else list.Add(name[0]);

                }
                else
                { 
                    if (list.Contains(name[0]))
                    {
                        list.Remove(name[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }

                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
