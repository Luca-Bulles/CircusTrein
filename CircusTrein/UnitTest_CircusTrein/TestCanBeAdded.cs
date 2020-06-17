using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestCanBeAdded
    {
        Animal dog = new Animal("Zabbel", AnimalSize.Small, AnimalDiet.Carnivore);
        Animal wolf = new Animal("Wolf", AnimalSize.Medium, AnimalDiet.Carnivore);
        Animal Trex = new Animal("Rexie", AnimalSize.Large, AnimalDiet.Carnivore);

        Animal snail = new Animal("Snail", AnimalSize.Small, AnimalDiet.Herbivore);
        Animal zebra = new Animal("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore);
        Animal Giraffe = new Animal("Giraffe", AnimalSize.Large, AnimalDiet.Herbivore);
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();
        [TestMethod]
        public void CanAddSmallCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(dog);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CanAddMediumCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(wolf);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void CanAddLargeCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(Trex);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CanAddSmallHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(snail);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CanAddMediumHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(zebra);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CanAddLargeHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.CanBeAdded(Giraffe);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
