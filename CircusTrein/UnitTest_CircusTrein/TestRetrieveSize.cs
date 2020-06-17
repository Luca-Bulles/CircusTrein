using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestRetrieveSize
    {
        Animal giraffe = new Animal("Luigi", AnimalSize.Large, AnimalDiet.Herbivore);
        Animal horse = new Animal("Gerard", AnimalSize.Medium, AnimalDiet.Herbivore);
        Animal babyShark = new Animal("doo doo, doo doo doo doo", AnimalSize.Small, AnimalDiet.Carnivore);

        private double accuracy = 0.01;
        [TestMethod]
        public void RetrieveSizeTest1()
        {
            int expectedValue = 5;
            int actualValue = giraffe.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }
        [TestMethod]
        public void RetrieveSizeTest2()
        {
            int expectedValue = 3;
            int actualValue = horse.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }
        [TestMethod]
        public void RetrieveSizeTest3()
        {
            int expectedValue = 1;
            int actualValue = babyShark.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }
    }
}
