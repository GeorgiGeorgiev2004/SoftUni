using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        double fuelquantity;
        double fuelconsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity 
        {
            get => this.fuelquantity;
            set
            {
                fuelquantity = value;
            }
        }
        public double FuelConsumption 
        {
            get => this.fuelconsumption;
            set 
            {
                fuelconsumption = value;
            }
        }
        public abstract void Drive(double kms);
        public abstract void Refuel(double lit);
    }
}
