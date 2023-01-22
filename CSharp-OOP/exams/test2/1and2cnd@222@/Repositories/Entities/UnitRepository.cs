using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories.Entities
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private List<IMilitaryUnit> units;

        public UnitRepository()
        {
            this.units = new List<IMilitaryUnit>();
        }
        public IReadOnlyCollection<IMilitaryUnit> Models => this.units;

        public void AddItem(IMilitaryUnit model)
        {
            this.units.Add(model);
        }

        public IMilitaryUnit FindByName(string name) => this.units.FirstOrDefault(x => x.GetType().Name == name);

        public bool RemoveItem(string unitName) => this.units.Remove(this.units.FirstOrDefault(x => x.GetType().Name == unitName));
    }
}
