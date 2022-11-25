using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Feline : Mammal
    {
        public Feline(string name, double weight, int foodEaten,
            string livingregion, string breed) 
            : base(name, weight, foodEaten, livingregion)
        {
            Breed = breed;
        }
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
