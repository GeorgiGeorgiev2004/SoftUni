using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WildFarm
{
    public class Food
    {
        private double quant;
        public string name;
        public Food( string Name, double quant )
        {
            this.quant = quant;
            this.Name = Name;
        }
        public string Name 
        {
            get => this.name;
            set => this.name = value;
        }
        public double Quantity 
        {
            get => this.quant;
            set =>this.quant = value;
        }
    }
}
