using System;
using System.Collections.Generic;
using System.Text;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestRetrieveLeftOverSize
    {
        Animal tiger = new Animal("Simba", AnimalSize.Medium, AnimalDiet.Carnivore);
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();
        [TestMethod]
        public void RetrieveLeftOverSize()
        {
            int expectedValue = 10;
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
