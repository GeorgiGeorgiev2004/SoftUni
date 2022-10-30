using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        public virtual string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
    }
}
