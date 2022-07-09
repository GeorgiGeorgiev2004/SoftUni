using System;
using System.Linq;
using System.Collections.Generic;
namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ').ToList();
            List<Person> Persons = new List<Person>();
            while (people[0]!="End")
            {
                bool k = true;
                var name = people[0]; 
                var id = people[1];
                int age = int.Parse(people[2]);
                var person = new Person(name,id,age);  
                if (Persons.Any(matchingId=>matchingId.ID==id))
                {
                    person.Exchange(Persons,person);
                    k = false;
                }
                if (k)
                {
                    Persons.Add(person);
                }
                people = Console.ReadLine().Split(' ').ToList();
            }
            Persons = Persons.OrderByDescending(x => x.Age).ToList();
            Persons.Reverse();
            for (int i = 0; i < Persons.Count; i++)
            {
                Console.WriteLine(Persons[i].ToString());
            }
            
        }
        
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public void Exchange(List<Person> list, Person person) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID==person.ID)
                {    
                    list[i].Age = person.Age;
                    list[i].Name = person.Name;    
                }
            }
        }
        
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
