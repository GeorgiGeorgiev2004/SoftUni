using ChristmasPastryShop.Models.Delicacies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public abstract class Delicacy : IDelicacy
    {
        private string name;
        private double price;

        public Delicacy(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }
        public override string ToString()
        {
            return $"{name} - {price:f2} lv";
        }
    }
}
