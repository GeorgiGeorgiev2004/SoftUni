namespace VehiclesExtended
{ 
    using System;
    public abstract class Vehicle
    {
       

        private double fuelQuantity;
        private double fuelConsumptionInLitersPerKm;
        private double tankcap;
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankcap)
        {
            this.FuelQuantity = fuelQuantity > tankcap ? 0 : fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.tankcap = tankcap;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set => this.fuelQuantity = value;
        }
        public double FuelConsumption
        {
            get => this.fuelConsumptionInLitersPerKm;
            set => this.fuelConsumptionInLitersPerKm = value;
        }
        public double TankCap
        {
            get => this.tankcap;
            set => this.tankcap = value;
        }
        public string Drive(double distance)
        {
            if (distance * FuelConsumption > FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= distance * this.FuelConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity<1)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (quantity+fuelQuantity>TankCap)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                return;
            }
            this.FuelQuantity += quantity;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}