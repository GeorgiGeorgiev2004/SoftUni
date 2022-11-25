using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten,
            string livingregion, string breed) 
            : base(name, weight, foodEaten, livingregion, breed)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
