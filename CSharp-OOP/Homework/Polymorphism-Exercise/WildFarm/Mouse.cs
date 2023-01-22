using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double IncreaseInWeight = 0.10;
        public Mouse(string name, double weight, int foodEaten, string livingregion)
            : base(name, weight, foodEaten, livingregion)
        {

        }
        public override void AskForFood(Food food)
        {
            Console.WriteLine("Squeak");
            if (food.name == "Vegetale"|food.name=="Fruit")
            {
                this.Weight += IncreaseInWeight * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.name}!");
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
