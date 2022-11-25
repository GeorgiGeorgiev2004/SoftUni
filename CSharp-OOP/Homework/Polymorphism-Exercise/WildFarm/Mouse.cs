using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingregion)
            : base(name, weight, foodEaten, livingregion)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
