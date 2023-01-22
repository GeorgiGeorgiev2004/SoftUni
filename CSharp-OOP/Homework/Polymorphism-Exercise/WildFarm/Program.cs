using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<string> Info;
            List<Animal> Animals = new List<Animal>();
            while ((Info= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList())[0] != "End")
            {
                var foodinfo = Console.ReadLine().Split().ToList();
                Type type = Info[0].GetType();
                Food Food = new Food(foodinfo[0] ,double.Parse(foodinfo[1]));
                var an = Factory(Info);
                an.AskForFood(Food);
                Animals.Add(an);
            }
            foreach (Animal anim in Animals)
            {
                Console.WriteLine(anim.ToString());
            }
        } 
        public static Animal Factory(List<string> Info) 
        {
            string type = Info[0];
            string name = Info[1];
            double weight = double.Parse(Info[2]);
            if (Info.Count == 5)
            {
                string livingregion = Info[3];
                string breed = Info[4];
                if (type=="Cat")
                {
                    return new Cat(name, weight, 0, livingregion, breed);
                }
                if (type == "Tiger")
                {
                    return new Tiger(name, weight, 0, livingregion, breed);
                }
            }
            else if (Info.Count == 4)
            {
                double WingSize = 0;
                if (double.TryParse(Info[3],out WingSize))
                {
                    if (type == "Owl")
                    {
                        return new Owl(name, weight, 0, WingSize);
                    }
                    if (type == "Hen")
                    {
                        return new Hen(name, weight, 0, WingSize);
                    }
                }
                else
                {
                    string livingregion = Info[3];
                    if (type == "Mouse")
                    {
                        return new Mouse(name, weight, 0, livingregion);
                    }
                    if (type == "Dog")
                    {
                        return new Dog(name, weight, 0, livingregion);
                    }
                }
            }
            else Environment.Exit(0);
            return null;
        }
    }
}
