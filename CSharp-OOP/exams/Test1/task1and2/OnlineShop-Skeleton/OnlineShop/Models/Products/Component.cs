using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace OnlineShop.Models.Products
{
    public abstract class Component : Product
    {
        private int generation;
        public Component(int id, string manufacturer, string model, decimal price, double myOverallPerformanceVar, int generatopn) : base(id, manufacturer, model, price, myOverallPerformanceVar)
        {
            Generation = generatopn;
        }
        public int Generation
        {
            get { return generation; }
            set { generation = value; }
        }
        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType().Name}: {Manufacturer} {Model} (Id: {Id}) Generation: {Generation}";
        }
    }
}
