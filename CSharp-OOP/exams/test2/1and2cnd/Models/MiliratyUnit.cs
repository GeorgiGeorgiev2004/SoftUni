using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models
{
    using Models.MilitaryUnits.Contracts;
    public abstract class MiliratyUnit : IMilitaryUnit
    {
        private double cost;
        private int enduranceLevel;

        public MiliratyUnit(double cost)
        {
            Cost = cost;
            EnduranceLevel = 1;
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int EnduranceLevel
        {
            get { return enduranceLevel; }
            set { enduranceLevel = value; }
        }

        public void IncreaseEndurance()
        {
            if (this.enduranceLevel + 1 > 20)
            {
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.EnduranceLevelExceeded);
            }
            else enduranceLevel++;
        }
    }
}
