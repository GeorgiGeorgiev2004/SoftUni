using System;
using System.Linq;

namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Phones = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            var Links = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < Phones.Count; i++)
            {
                if (Phones[i].Length == 7)
                {
                    StationaryPhone statphone = new StationaryPhone();
                    statphone.Call(Phones[i]);
                }
                else
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.Call(Phones[i]);
                }
            }
            for (int i = 0; i < Links.Count; i++)
            {
                Smartphone smartphone = new Smartphone();
                smartphone.BrowseTheWWW(Links[i]);
            }
        }
    }
}
