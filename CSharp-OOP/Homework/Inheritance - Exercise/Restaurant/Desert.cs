using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Desert : Food
    {
        public Desert(string name, decimal price, double grams,double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories{ get; set; }
    }
}
