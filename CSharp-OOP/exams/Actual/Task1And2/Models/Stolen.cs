using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Stolen : Delicacy
    {
        const double PriceForCurrent = 4.00;

        public Stolen(string name) : base(name, PriceForCurrent)
        {
        }
    }
}
