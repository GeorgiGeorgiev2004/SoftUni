using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }
        public string Name
        {
            get=>this.name;
            
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }
        public decimal Money
        {
            get=> this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public string AddProductToBag(Product product)
        {
            if (this.Money < product.Price)
            {
                return $"{this.Name} can't afford {product.Name}";
            }
            this.Money -= product.Price;
            this.bag.Add(product);
            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            return $"{this.Name} - {String.Join(", ", this.bag.Select(p => p.Name))}";
        }
    }
}
