using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IPersonOrPet
    {
        public Citizen(string iD, string name, string birthdate)
        {
            ID = iD;
            Name = name;
            Birthdate = birthdate;
        }

        public string ID { get; set; }
        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
