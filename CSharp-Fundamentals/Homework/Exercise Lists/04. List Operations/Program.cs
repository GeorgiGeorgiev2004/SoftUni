using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> task = Console.ReadLine().Split(' ').ToList();
            while (task[0] != "End")
            {
                if (task[0]=="Add")
                {
                    list.Add(int.Parse(task[1]));
                }
                if (task[0]=="Insert")
                {
                    if (int.Parse(task[2]) < list.Count && int.Parse(task[2]) >= 0)
                    {
                       list.Insert(int.Parse(task[2]), int.Parse(task[1])); 
                    }
                    else Console.WriteLine("Invalid index");
                }
                if (task[0] == "Remove")
                {
                    if (int.Parse(task[1])>= list.Count || int.Parse(task[1])<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else list.RemoveAt(int.Parse(task[1]));
                }
                if (task[1] == "left")
                {
                    for (int i = 0; i < int.Parse(task[2]); i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                if (task[1] == "right")
                {
                    for (int i = 0; i < int.Parse(task[2]); i++)
                    {
                        list.Insert(0,list[list.Count - 1]);
                        list.RemoveAt(list.Count-1);
                    }
                }
                task = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
