using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestInsertInWagon
    {
        Animal mouse = new Animal("Onacor", AnimalSize.Small, AnimalDiet.Herbivore);
        Animal fish = new Animal("Fish", AnimalSize.Medium, AnimalDiet.Herbivore);
        Animal whale = new Animal("Moby-Dick", AnimalSize.Large, AnimalDiet.Herbivore);

        Animal ant = new Animal("Ant", AnimalSize.Small, AnimalDiet.Carnivore);
        Animal cat = new Animal("Mittens", AnimalSize.Medium, AnimalDiet.Carnivore);
        Animal lion = new Animal("Mufasa", AnimalSize.Large, AnimalDiet.Carnivore);
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();
        [TestMethod]
        public void InsertInWagonSmallHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(mouse);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonMediumHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(fish);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonLargeHerbivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(whale);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonSmallCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(ant);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonMediumCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(cat);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InsertInWagonLargeCarnivore()
        {
            bool expectedValue = true;
            bool actualValue = wagon.InsertInWagon(lion);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
