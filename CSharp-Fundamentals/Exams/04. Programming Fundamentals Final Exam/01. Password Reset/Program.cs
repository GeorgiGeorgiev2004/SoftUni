using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] com = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (com[0] != "Done")
            {
                bool help = true;
                switch (com[0]) 
                {
                    case "TakeOdd":
                        var chararr = password.ToCharArray();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 1; i < chararr.Length; i++)
                        {
                            if (i%2!=0)
                            {
                                sb.Append(chararr[i]);
                            }
                        }
                        password = sb.ToString();
                        break;
                    case "Cut":
                        string subs = password.Substring(int.Parse(com[1]), int.Parse(com[2]));
                        if (password.Contains(subs))
                        {
                           password =password.Remove(password.IndexOf(subs), int.Parse(com[2]));

                        }
                        break;
                    case "Substitute":
                        if (password.Contains(com[1]))
                        {
                        password = password.Replace(com[1], com[2]);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                            help = false;
                        }
                        break;
                }
                if (help)
                {
                    Console.WriteLine(password);
                }
                com = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine("Your password is: " + password);
        }
    }
}