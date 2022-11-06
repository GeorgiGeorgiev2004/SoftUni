using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public Vehicle(int horsePower, double fuel)
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
