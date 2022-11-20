using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        const double summerHigh = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override void Drive(double kms)
        {
            if ((this.FuelConsumption + summerHigh) * kms > this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumption + summerHigh) * kms;
                Console.WriteLine($"Car travelled {kms} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void Refuel(double lit)
        {
            this.FuelQuantity += lit;
        }
    }
}
