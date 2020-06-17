using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestRetrieveAnimals
    {
        //Test fields
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();
        List<Animal> animals = new List<Animal>();

        [TestMethod]
        public void TestRetrieveAnimalsList()
        {
            List<Animal> expectedValue = animals;
            List<Animal> actualValue = wagon.RetrieveAnimals();
            Assert.AreEqual(expectedValue.ToString(), actualValue.ToString());
        }
    }
}
