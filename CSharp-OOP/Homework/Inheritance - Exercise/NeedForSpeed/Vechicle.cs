using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public  class Vechicle
    {
        const double DefaultFuelConsumption = 1.25;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public Vechicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public virtual void Drive(double kilometers)
        {
            if (Fuel - (FuelConsumption * kilometers)>=0)
            {
                Fuel -= FuelConsumption * kilometers;
            }
        }
    }
}
