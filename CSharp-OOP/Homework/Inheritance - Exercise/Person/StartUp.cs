using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 15)
            {
                Person child = new Person(age, name);
                Console.WriteLine(child);
            }
            else
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
        }
    }
}