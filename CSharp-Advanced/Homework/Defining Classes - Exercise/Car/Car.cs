using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumption;
        double travelledDistance;
        public Car()
        {
            travelledDistance = 0;
        }
        public Car(string model, double fuelAmount, double fuelConsumption)
            :this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }
        public void Drive(double kms, Car car)
        {
            if (car.fuelConsumption*kms>car.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.fuelAmount -= kms*car.FuelConsumption;
                car.travelledDistance+= kms;
            }
        }
        public string Model
        {
            get
            {
                return model; 
            }

            set
            {
                model = value;
            } 
        }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }

            set
            {
                fuelAmount = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }

            set
            {
                fuelConsumption = value;
            }
        }
        public double TravelledDistance
        {
            get
            {
                return travelledDistance;
            }

            set
            {
                travelledDistance = value;
            }
        }

    }
}
