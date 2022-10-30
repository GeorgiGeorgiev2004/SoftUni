using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name,double Caffein) : base(name,CoffeePrice,CoffeeMilliliters)
        {
           Caffeine = Caffein;

        }
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.5m;
        public double Caffeine { get; set; }
    }
}
