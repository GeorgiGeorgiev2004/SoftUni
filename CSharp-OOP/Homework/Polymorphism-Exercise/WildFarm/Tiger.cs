using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double IncreaseInWeight = 1;

        public Tiger(string name, double weight, int foodEaten,
            string livingregion, string breed) 
            : base(name, weight, foodEaten, livingregion, breed)
        {

        }
        public override void AskForFood(Food food)
        {
            Console.WriteLine("ROAR!!!");
            if (food.name == "Meat")
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
