using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name{ get; set; }
        public Product(string name,decimal price)
        {
            Price = price;
            Name = name;
        }
    }
}
