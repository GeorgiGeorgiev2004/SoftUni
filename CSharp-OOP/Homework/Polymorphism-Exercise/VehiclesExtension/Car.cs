using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtended
{
    public class Car : Vehicle
    {
        private static readonly double ADDITIONAL_CONSUMPTION = 0.90;

        public Car(double fuelQuantity, double fuelConsumption,double tankcap)
            : base(fuelQuantity, fuelConsumption + ADDITIONAL_CONSUMPTION,tankcap)
        { }
    }
}
