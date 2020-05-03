using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest_CircusTrein
{
    [TestClass]
    public class TestInsertInWagon
    {
        Animals mouse = new Animals("Onacor", AnimalSize.Small, AnimalDiet.Herbivore);
        Animals cat = new Animals("Mittens", AnimalSize.Medium, AnimalDiet.Carnivore);
        Wagon wagon = new Wagon();
        [TestMethod]
        public void InsertInWagonTest1()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(mouse);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonTest2()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(cat);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
