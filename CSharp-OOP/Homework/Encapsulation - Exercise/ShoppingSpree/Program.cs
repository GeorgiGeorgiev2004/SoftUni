using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                people = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToList()
                    .Select(t => t.Split('='))
                    .Select(p => new Person(p[0], decimal.Parse(p[1])))
                    .ToList();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                    .Select(t => t.Split('='))
                    .Select(p => new Product(p[0], decimal.Parse(p[1])))
                    .ToList();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();
                var person = people.First(p => p.Name == tokens[0]);
                var product = products.First(p => p.Name == tokens[1]);
                Console.WriteLine(person.AddProductToBag(product));
            }
            people.ForEach(p => Console.WriteLine(p));
        }
    } 
}
