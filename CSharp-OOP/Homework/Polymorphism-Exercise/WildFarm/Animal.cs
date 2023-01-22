using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }

        public string Name{ get; set; }
        public double Weight { get; set; }
        public double FoodEaten { get; set; }
        public abstract void AskForFood(Food food);
    }
}
