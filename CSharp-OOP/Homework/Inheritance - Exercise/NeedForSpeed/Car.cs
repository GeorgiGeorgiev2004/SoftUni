using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vechicle
    {
        private const double DefaultCarFuelConsumption = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption
            => DefaultCarFuelConsumption;
    }
}
