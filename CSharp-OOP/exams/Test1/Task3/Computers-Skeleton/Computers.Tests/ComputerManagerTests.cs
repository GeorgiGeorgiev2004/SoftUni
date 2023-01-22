using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        private Computer defaultComputer;
        private readonly string defaultManufacturer = "Asus";
        private readonly string defaultModel = "X55";
        private readonly decimal defaultPrice = 1500;

        private ComputerManager computerManager;
        [SetUp]
        public void Setup()
        {
            this.defaultComputer = new Computer(defaultManufacturer, defaultModel, defaultPrice);
            this.computerManager = new ComputerManager();
        }

        [Test]
        public void ComputerManagerCosntructorShouldWork()
        {
            Assert.That(computerManager.Count, Is.EqualTo(0));
            Assert.That(computerManager.Computers, Is.Empty);
        }
        [Test]
        public void ComputersShouldAddWhenAComputerIsAdded()
        {
            computerManager.AddComputer(defaultComputer);
            Assert.That(computerManager.Count, Is.EqualTo(1));
            Assert.That(computerManager.Computers, !Is.Empty);
        }
    }
}