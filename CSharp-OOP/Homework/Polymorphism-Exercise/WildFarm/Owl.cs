using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingsize)
            : base(name, weight, foodEaten, wingsize)
        {

        }
        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
