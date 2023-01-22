using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            private string name = "Planetotroshachka2022";
            private double price = 2202.69;
            private int destructionLevel = 5;
            private string planetname = "Jupiter";
            private double budget = 5555;
            Weapon weapon;
            Planet planet;
            [SetUp]
            public void SetUp()
            {
                weapon = new Weapon(name, price, destructionLevel);
                planet = new Planet(planetname, budget);
            }
            [Test]
            public void WeaponConstructorShouldInitialiseName()
            {
                Assert.DoesNotThrow(() => { weapon = new Weapon(name, price, destructionLevel); });
            }
            [Test]
            public void WeaponPriceShouldThrowIfInvalid()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Weapon weapon = new Weapon(name, -1, destructionLevel);
                }, "Price cannot be negative.");
            }
            [Test]
            public void WeaponDestructionLevelMethodShouldIncreaseDL()
            {
                weapon.IncreaseDestructionLevel();
                destructionLevel++;
                Assert.AreEqual(weapon.DestructionLevel, destructionLevel);
            }
            [Test]
            public void WeaponIsNuclearShouldThrowFalseIfBellow10()
            {
                weapon.DestructionLevel = 9;
                Assert.IsFalse(weapon.IsNuclear);
            }
            [Test]
            public void WeaponIsNuclearShouldThrowTrueif10orAbove()
            {
                weapon.DestructionLevel = 11;
                Assert.IsTrue(weapon.IsNuclear);
            }
            [Test]
            public void PlanetConstructorShouldWork()
            {
                Assert.DoesNotThrow(() => { planet = new Planet(planetname, 20); });
            }
            [Test]
            public void PlanetConstructorShouldInitialiseListOfWeapons()
            {
                Assert.AreEqual(planet.Weapons.Count, 0);
            }
            [Test]
            public void PlanetConstructorShouldThrowAEIfNameIsNULL()
            {
                Assert.Throws<ArgumentException>(
              () => new Planet(null, 20),
              $"Invalid planet name.");

            }
            [Test]
            public void PlanetConstructorShouldThrowAEIfNameIsEmpty()
            {
                Assert.Throws<ArgumentException>(
              () => new Planet("", 20),
              $"Invalid planet name.");
            }
            [Test]
            public void PlanetConstructorShouldThrowAEIfBudgetIsInValid()
            {
                Assert.Throws<ArgumentException>(
              () => new Planet("Jupiter", -20),
              $"Budget cannot drop below Zero!");
            }
            [Test]
            public void PlanetMilitaryPowerShouldBeTrue()
            {
                Weapon weapon1 = new Weapon("Stronk", 1234, 19);
                planet.AddWeapon(weapon1);
                planet.AddWeapon(weapon);
                Assert.AreEqual(weapon.DestructionLevel + weapon1.DestructionLevel, planet.MilitaryPowerRatio);
            }
            [Test]
            public void PlanetProfitShouldAddBudget()
            {
                planet.Profit(20);
                budget += 20;
                Assert.AreEqual(planet.Budget, budget);
            }
            [Test]
            public void PlanetSpendFundsShouldThrowIfNoMoneyToSpend()
            {

                Assert.Throws<InvalidOperationException>(() => 
                {
                    planet.SpendFunds(6666);
                }, "Not enough funds to finalize the deal.");
            }
            [Test]
            public void PlanetSpendFundsWorks()
            {
                planet.SpendFunds(1202.69);
                budget -= 1202.69;
                Assert.AreEqual(planet.Budget, budget);
            }
            [Test]
            public void PlanetAddWeaponThrowsIOEIfWeaponAlreadyExists()
            {
                planet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => 
                {
                    planet.AddWeapon(weapon);
                });
            }
            [Test]
            public void PlanetAddWeaponWorks()
            {
                planet.AddWeapon(weapon);
                Assert.AreEqual(planet.Weapons.Count, 1);
            }
            [Test]
            public void PlanetRemoveWeapon()
            {
                planet.AddWeapon(weapon);
                planet.RemoveWeapon(weapon.Name);
                Assert.AreEqual(planet.Weapons.Count, 0);
            }
            [Test]
            public void PlanetUpgradeWeaponThrowsIOEIfNoWeaponIsFound()
            {
                planet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => 
                {
                    planet.UpgradeWeapon("KirilGreshniq");
                });
            }
            [Test]
            public void PlanetUpgradeWeaponWorks()
            {
                planet.AddWeapon(weapon);
                planet.UpgradeWeapon(weapon.Name);
                weapon.IncreaseDestructionLevel();
                Assert.AreEqual(planet.MilitaryPowerRatio, weapon.DestructionLevel);
            }
            [Test]
            public void PlanetDestructOponentThrowsIOE()
            {
                Planet oponentplanet = new Planet("Simitlii", 2222);
                oponentplanet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => { planet.DestructOpponent(oponentplanet); });
            }
            [Test]
            public void PlanetDestructOponentWorks()
            {
                Planet opponent = new Planet("Simitlii", 2222);
                planet.AddWeapon(weapon);
                Assert.AreEqual($"{opponent.Name} is destructed!", planet.DestructOpponent(opponent));
            }
        }
    }
}
