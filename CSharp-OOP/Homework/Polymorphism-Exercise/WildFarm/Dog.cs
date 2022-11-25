using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingregion)
            : base(name, weight, foodEaten, livingregion)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
