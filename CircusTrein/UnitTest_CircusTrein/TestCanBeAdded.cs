using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest_CircusTrein
{
    [TestClass]
    public class TestCanBeAdded
    {
        Animals dog = new Animals("Zabbel", AnimalSize.Small, AnimalDiet.Carnivore);
        Animals Trex = new Animals("Rexie", AnimalSize.Large, AnimalDiet.Carnivore);
        Wagon wagon = new Wagon();
        [TestMethod]
        public void CanBeAddedTest1()
        {            
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(dog);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void CanBeAddedTest2()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(Trex);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
