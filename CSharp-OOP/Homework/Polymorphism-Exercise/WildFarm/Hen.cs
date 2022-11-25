using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    internal class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingsize)
            : base(name, weight, foodEaten, wingsize)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }
    }
}
