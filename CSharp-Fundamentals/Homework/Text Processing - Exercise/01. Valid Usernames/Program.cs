using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> users = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> fin = new List<string>();
            for (int i = 0; i < users.Count; i++)
            {
                char[]chars =  users[i].ToCharArray();
                bool viable = true;
                if (chars.Length > 3 && chars.Length < 16)
                {
                    foreach (var sym in chars)
                    {
                        if (char.IsLetterOrDigit(sym) || sym == '-' || sym == '_')
                        {
                            continue;
                        }
                        else
                        {
                            viable = false;
                            break;
                        }
                    }
                    if (viable)
                    {
                        fin.Add(users[i]);
                    }
                }
                
            }
            for (int i = 0; i < fin.Count; i++)
            {
                Console.WriteLine(fin[i]);
            }
            
        }
    }
}