using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static Animal Factory() 
        {
            var Info = Console.ReadLine().Split(' ').ToList();
            string type = Info[0];
            string name = Info[1];
            double weight = double.Parse(Info[2]);
            if (Info.Count == 5)
            {
                string livingregion = Info[3];
                string breed = Info[4];
                if (type=="Cat")
                {
                    Cat cat= new Cat(name, weight, 0, livingregion, breed);
                    cat.AskForFood();
                    return cat;
                }
                if (type == "Tiger")
                {
                    Tiger tiger = new Tiger(name, weight, 0, livingregion, breed);
                    tiger.AskForFood();
                    return tiger;
                }
            }
            else if (Info.Count == 4)
            {
                if (Info[3].GetType().Name.ToString() == "String")
                {
                    string livingregion = Info[3];
                    if (type == "Mouse")
                    {
                        Mouse mouse = new Mouse(name, weight, 0, livingregion);
                        mouse.AskForFood();
                        return mouse;
                    }
                    if (type == "Dog")
                    {
                        Dog dog =  new Dog(name, weight, 0, livingregion);
                        dog.AskForFood();
                        return dog;
                    }
                }
                else
                {
                    double WingSize = double.Parse(Info[3]);
                    if (type == "Owl")
                    {
                        Owl owl = new Owl(name, weight, 0, WingSize);
                        owl.AskForFood();
                        return owl;
                    }
                    if (type == "Hen")
                    {
                        Hen hen = new Hen(name, weight, 0, WingSize);
                        hen.AskForFood();
                        return hen;
                    }
                }
            }
            else Environment.Exit(0);
            return null;
        }
    }
}
