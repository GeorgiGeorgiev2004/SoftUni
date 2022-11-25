using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        private string name;
        private int power;

        protected BaseHero(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Power
        {
            get => this.power;
            set => this.power = value;
        }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.name} ... for {this.power}";
        }
    }
}
