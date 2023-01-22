namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        Bag bag;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
        }
        [Test]
        public void PresentsConstructorShouldWork()
        {
            Present present = new Present("Pepkicha", 222);
            Assert.IsNotNull(present);
        }
        [Test]
        public void BagConstructorShouldWork()
        {
            Bag bag = new Bag();
            Assert.IsNotNull(bag);
        }
        [Test]
        public void CreateMethodShouldThrowIfNull()
        {
            Present present = null;
            Assert.Throws<ArgumentNullException>(() =>
            {
                bag.Create(present);
            }, "Present is null");
        }
        [Test]
        public void CreateMethodShouldThrowIfPresentAlreadyExists()
        {
            Present present = new Present("Pepkicha", 222);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() =>
            {
                bag.Create(present);
            }, "This present already exists!");
        }
        [Test]
        public void CreateMethodShouldAddPresentsToListIfAllGoesWell()
        {
            Present present = new Present("Pepkicha", 222);
            bag.Create(present);
            Assert.AreEqual(1, bag.GetPresents().Count);
        }
        [Test]
        public void RemoveShouldRemoveItemFromList()
        {
            Present present = new Present("Pepkicha", 2);
            Present present1 = new Present("Stefi", 22);
            Present present2 = new Present("Stefi", 2222);
            bag.Create(present);
            bag.Create(present1);
            bag.Remove(present1);
            Assert.AreEqual(1, bag.GetPresents().Count);
        }
        [Test]
        public void GetPresentsWithLeastMagicShouldReturnThatPresent()
        {
            Present present = new Present("Pepkicha", 2);
            Present present1 = new Present("Stefi", 22);
            Present present2 = new Present("Stefi", 222);
            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);
            Assert.AreEqual(bag.GetPresentWithLeastMagic(), present);
        }
        [Test]
        public void GetPresentShouldReturnPresentWithThatName()
        {
            Present present = new Present("Pepkicha", 2);
            Present present1 = new Present("Stefi", 22);
            Present present2 = new Present("Stefi", 222);
            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);
            Assert.AreEqual(bag.GetPresent("Pepkicha"), present);
        }
        [Test]
        public void GetPresentsShouldReturnListOfPresents()
        {
            Present present = new Present("Pepkicha", 2);
            Present present1 = new Present("Stefi", 22);
            Present present2 = new Present("Stefi", 222);
            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);
            List<Present> presents = new List<Present>() { present, present1, present2 };
            Assert.AreEqual(presents, bag.GetPresents());
            

        }
    }
}
