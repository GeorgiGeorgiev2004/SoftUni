using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mammal : Animal
    {
        public Mammal(string name, double weight, int foodEaten, string livingregion) 
            : base(name, weight, foodEaten)
        {
            LivingRegion = livingregion;
        }

        public string LivingRegion { get; set; }

        public override void AskForFood()
        {
            throw new NotImplementedException();
        }
    }
}
