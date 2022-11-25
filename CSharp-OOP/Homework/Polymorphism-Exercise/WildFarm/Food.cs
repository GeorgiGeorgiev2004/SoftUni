using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WildFarm
{
    public class Food
    {
        private int quant;
        public List<string> Foods;
        public Food()
        {
            Foods = new List<string>() { "Vegetable", "Fruit", "Meat", "Seeds" };
        }
        public int Quantity 
        {
            get => this.quant;
            set =>this.quant = value;
        }
    }
}
