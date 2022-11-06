using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Telephony
{
    public class Smartphone : IPhoneCall, IBrowseTheWeb
    {
        public void BrowseTheWWW(string url)
        {
            char[] chars = url.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Call(string phone)
        {
            char[] chars = phone.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                if (!char.IsDigit(chars[i]))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            Console.WriteLine($"Calling... {phone}");
        }
    }
}
