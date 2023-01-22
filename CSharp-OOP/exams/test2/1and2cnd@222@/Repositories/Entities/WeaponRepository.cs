using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories.Entities
{
    internal class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> weapons;
        public WeaponRepository()
        {
                this.weapons = new List<IWeapon>();
        }
        public IReadOnlyCollection<IWeapon> Models => this.weapons;

        public void AddItem(IWeapon model)
        {
            this.weapons.Add(model);
        }

        public IWeapon FindByName(string name) => this.weapons.FirstOrDefault(x => x.GetType().Name == name);

        public bool RemoveItem(string weaponName) => this.weapons.Remove(this.weapons.FirstOrDefault(x => x.GetType().Name == weaponName));
    }
}
