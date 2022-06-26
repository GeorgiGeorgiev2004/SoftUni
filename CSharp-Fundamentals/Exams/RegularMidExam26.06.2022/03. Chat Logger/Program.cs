using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> input = Console.ReadLine().Split(' ').ToList();
            while (input[0]!="end")
            {
                if (input[0]=="Chat")
                {
                    list.Add(input[1]);
                }
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]==input[1])
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                if (input[0] == "Edit")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == input[1])
                        {
                            list[i] = input[2];
                        }
                    }
                }
                if (input[0] == "Pin")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == input[1])
                        {
                            list.Add(list[i]);
                            list.RemoveAt(i);
                        }
                    }
                }
                if (input[0] == "Spam")
                {
                    for (int i = 1; i < input.Count; i++)
                    {
                        list.Add(input[i]);
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
            for (int i= 0;  i< list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}