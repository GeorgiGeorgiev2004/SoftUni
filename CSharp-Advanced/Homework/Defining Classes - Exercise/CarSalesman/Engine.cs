using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = string.Empty;
            if (Displacement==0)
            {
                displacement = "n/a";
            }
            else displacement=Displacement.ToString();
            string efficiency = string.Empty;
            if (Efficiency==null)
            {
                efficiency = "n/a";
            }
            else efficiency=Efficiency;
            string result =
                $"{Model}:{Environment.NewLine}" +
                $"    Power: {Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";

            return result;
        }
    }
}
