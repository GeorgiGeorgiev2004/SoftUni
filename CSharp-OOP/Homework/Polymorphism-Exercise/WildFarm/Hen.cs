using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double IncreaseInWeight = 0.35;
        public Hen(string name, double weight, int foodEaten, double wingsize)
            : base(name, weight, foodEaten, wingsize)
        {

        }
        public override void AskForFood(Food food)
        {
            Console.WriteLine("Cluck");
            if (food.name == "Vegetale" | food.name == "Fruit"| food.name == "Meat" | food.name == "Seeds")
            {
                this.Weight += IncreaseInWeight * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.name}!");
            }
        }
    }
}
