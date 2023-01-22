using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;

        protected Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
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
        public string Size
        {
            get { return size; }
            private set { size = value; }
        }
        public double Price
        {
            get { return price; }
            private set
            { 
                double pricecalculus = value / 3;
                if (this.size == "Large")
                {
                    price = value; 
                }
                if (this.size == "Middle")
                {
                    price = pricecalculus*2;
                }
                if (this.size == "Small")
                {
                    price = pricecalculus;
                }
            }
        }
        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price:f2} lv";
        }
    }
}
