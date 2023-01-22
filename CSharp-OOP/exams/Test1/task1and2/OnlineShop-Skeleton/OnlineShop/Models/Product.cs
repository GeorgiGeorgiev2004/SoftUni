using OnlineShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models
{

    using OnlineShop.Common.Constants;
    public abstract class Product : IProduct
    {
        private int id;
        private string manufacturer;
        private string model;
        private decimal price;
        private double myOverallPerformanceVar;

        protected Product(int id, string manufacturer, string model, decimal price, double myOverallPerformanceVar)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            OverallPerformance= myOverallPerformanceVar;
        }

        public int Id
        {
            get { return id; }
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidProductId);
                }
                else id = value; 
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidManufacturer);
                }
                else manufacturer = value; 
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidModel);
                }
                else model = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }
                else price = value;
            }
        }
        public double OverallPerformance
        {
            get { return myOverallPerformanceVar; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOverallPerformance);
                }
                else myOverallPerformanceVar = value;
            }
        }
        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType().Name}: {manufacturer} {model} (Id: {id})";
        }
    }
}
