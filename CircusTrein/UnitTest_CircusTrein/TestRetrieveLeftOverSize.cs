using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CircusTrein;

namespace UnitTest_CircusTrein
{
    [TestClass]
    public class TestRetrieveLeftOverSize
    {
        Animals tiger = new Animals("Simba", AnimalSize.Medium, AnimalDiet.Carnivore);
        Wagon wagon = new Wagon();        
        [TestMethod]
        public void RetrieveLeftOverSize()
        {
            int expectedValue = 10;
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
