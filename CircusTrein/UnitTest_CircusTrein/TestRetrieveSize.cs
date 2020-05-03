using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;

namespace UnitTest_CircusTrein
{
    [TestClass]
    public class TestRetrieveSize
    {
        Animals giraffe = new Animals("Luigi", AnimalSize.Large, AnimalDiet.Herbivore);
        Animals horse = new Animals("Gerard", AnimalSize.Medium, AnimalDiet.Herbivore);
        Animals babyShark = new Animals("doo doo, doo doo doo doo", AnimalSize.Small, AnimalDiet.Carnivore);

        private double accuracy = 0.01;
        [TestMethod]
        public void RetrieveSizeTest1()
        {
            int expectedValue = 5;
            int actualValue = giraffe.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }

        public void RetrieveSizeTest2()
        {
            int expectedValue = 3;
            int actualValue = horse.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }

        public void RetrieveSizeTest3()
        {
            int expectedValue = 1;
            int actualValue = babyShark.RetrieveSize();
            Assert.AreEqual(expectedValue, actualValue, accuracy);
        }
    }
}
