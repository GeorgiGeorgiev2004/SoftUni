﻿namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double mililiters) : base(name, price)
        {
            Mililiters=mililiters;
        }
        public double Mililiters{ get; set; }
    }

}
