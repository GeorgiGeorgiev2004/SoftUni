using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        public virtual int Age 
        {
            get { return age; }
            set {if (value > 0) age = value;} 
        }
        public string Name { get; set; }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
