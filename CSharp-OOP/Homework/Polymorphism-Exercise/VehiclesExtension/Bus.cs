using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using VehiclesExtended;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private static readonly double ADDITIONAL_CONSUMPTION = 1.4;
        private double mix;
        private double initialfuelconst;
        public Bus(double fuelQuantity, double fuelConsumption, double tankcap) :
            base(fuelQuantity, fuelConsumption, tankcap)
        {
            mix= fuelConsumption+1.4;
            initialfuelconst = fuelConsumption;
        }
        public void FullOREmpty(bool IDK) 
        {
            if (IDK)
            {
                this.FuelConsumption = mix;
            }
            else 
            {
                this.FuelConsumption = initialfuelconst;
            }
        }
    }
}
