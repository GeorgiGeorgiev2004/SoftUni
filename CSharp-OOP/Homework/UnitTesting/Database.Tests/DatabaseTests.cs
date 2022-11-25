namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Data.Common;

    [TestFixture]
    public class DatabaseTests
    {
        private Database defDb;

        [SetUp]
        public void SetUp()
        {
            this.defDb = new Database();
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShouldInitializeDataWithCorrectCount(int[] data)
        {
            Database db = new Database(data);
            int expectedCount = data.Length;
            int actualCount = db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
        public void ConstructorShouldThrowExcpetionWhenInputDataIsAbove16Count(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database db = new Database(data);
            }, "Array's capacity must be exactly 16 integers!");
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShouldAddElementsIntoDataField(int[] data)
        {
            Database db = new Database(data);

            int[] expectedData = data;
            int[] actualData = db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void CountShouldReturnCorrectCount(int[] data)
        {
            Database db = new Database(data);
            int expectedCount = data.Length;
            int actualCount = db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void AddingElementsShouldIncreaseCount()
        {
            int expectedCount = 5;
            for (int i = 1; i <= expectedCount; i++)
            {
                this.defDb.Add(i);
            }

            int actualCount = this.defDb.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddingElementsShouldAddThemToTheDataCollection()
        {
            int[] expectedData = new int[5];
            for (int i = 1; i <= 5; i++)
            {
                this.defDb.Add(i);
                expectedData[i - 1] = i;
            }

            int[] actualData = this.defDb.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void AddingMoreThan16ElementsShouldThrowAnException()
        {
            for (int i = 1; i <= 16; i++)
            {
                this.defDb.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.defDb.Add(17);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void RemovingElementShouldDecreaseCount()
        {
            int initialCount = 5;
            for (int i = 1; i <= initialCount; i++)
            {
                this.defDb.Add(i);
            }

            int removeCount = 2;
            for (int i = 1; i <= removeCount; i++)
            {
                this.defDb.Remove();
            }

            int expectedCount = initialCount - removeCount;
            int actualCount = this.defDb.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemovingElementShouldRemoveItFromTheDataCollection()
        {
            int initialCount = 5;
            for (int i = 1; i <= initialCount; i++)
            {
                this.defDb.Add(i);
            }

            int removeCount = 2;
            for (int i = 1; i <= removeCount; i++)
            {
                this.defDb.Remove();
            }

            int[] expectedData = new int[] { 1, 2, 3 };
            int[] actualData = this.defDb.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenThereAreNoElementsInDb()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.defDb.Remove();
            }, "The collection is empty!");
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCollectionWithElementsInTheDb(int[] data)
        {
            Database db = new Database(data);

            int[] expectedData = data;
            int[] actualData = db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}
