using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double IncreaseInWeight = 0.25;
        public Owl(string name, double weight, int foodEaten, double wingsize)
            : base(name, weight, foodEaten, wingsize)
        {

        }
        public override void AskForFood(Food food)
        {
            Console.WriteLine("Hoot Hoot");
            if (food.name=="Meat")
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
