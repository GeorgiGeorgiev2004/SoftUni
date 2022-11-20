using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck:Vehicle
    {
        const double summerHigh = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override void Drive(double kms)
        {
            if ((this.FuelConsumption + summerHigh) * kms > this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumption + summerHigh) * kms;
                Console.WriteLine($"Truck travelled {kms} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double lit)
        {
            this.FuelQuantity += 95 * lit / 100;
        }
    }
}
