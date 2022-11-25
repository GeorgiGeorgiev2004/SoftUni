using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtended

{
    public class Truck : Vehicle
    {
        private static readonly double ADDITIONAL_CONSUMPTION = 1.6;
        private static readonly double QTY_MODIFIER = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption,double tankcap)
            : base(fuelQuantity, fuelConsumption + ADDITIONAL_CONSUMPTION,tankcap)
        {

        }

        public override void Refuel(double quantity)
        {
            if (quantity < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (quantity + FuelQuantity > TankCap)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                return;
            }
            FuelQuantity += (quantity * QTY_MODIFIER);
        }
    }
}
