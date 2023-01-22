using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Bird : Animal
    {
        public double WingSize { get; set; }

        public Bird(string name, double weight, int foodEaten, double wingsize) 
            : base(name, weight, foodEaten)
        {
            WingSize = wingsize;
        }
        
        public override void AskForFood(Food food)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
