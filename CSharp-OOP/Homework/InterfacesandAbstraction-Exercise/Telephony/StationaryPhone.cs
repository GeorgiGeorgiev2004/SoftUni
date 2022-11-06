using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IPhoneCall
    {
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
            Console.WriteLine($"Dialing... {phone}");
        }
    }
}
