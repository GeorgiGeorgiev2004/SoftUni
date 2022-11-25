namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class DatabaseTests
    {
        
        public Person pesho;
        public Person gosho;

        [SetUp]
        public void TestInit()
        {
            pesho = new Person(114560, "Pesho");
            gosho = new Person(447788556699, "Gosho");
        }

        [Test]
        public void ConstructorShouldInitializeDataCorrectly() 
        {

        }
    }
}