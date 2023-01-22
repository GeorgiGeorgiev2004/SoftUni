using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace PlanetWars.Models
{
    public class Planet : IPlanet
    {
        private string name;
        private double militaryPower;
        private double budget;
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidPlanetName);
                }
                name = value; 
            }
        }
        public double Budget
        {
            get { return budget; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidBudgetAmount);
                }
                budget = value;
            }
        }
        public double MilitaryPower
        {
            get { return militaryPower; }
            set { 

                militaryPower = value; 
            }
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => throw new NotImplementedException();

        public IReadOnlyCollection<IWeapon> Weapons => throw new NotImplementedException();

        public void AddUnit(IMilitaryUnit unit)
        {
            throw new NotImplementedException();
        }

        public void AddWeapon(IWeapon weapon)
        {
            throw new NotImplementedException();
        }

        public string PlanetInfo()
        {
            throw new NotImplementedException();
        }

        public void Profit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Spend(double amount)
        {
            throw new NotImplementedException();
        }

        public void TrainArmy()
        {
            throw new NotImplementedException();
        }
    }
}
