using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestAddAnimalToQueue
    {
        //Test Fields
        private List<Animal> expectedValue = new List<Animal>() { new Animal("Spike", AnimalSize.Medium, AnimalDiet.Carnivore) };
        public List<Animal> animalsToAdd = new List<Animal>();

        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void AddAnimalToQueue()
        {
            Animal animal = new Animal("Spike", AnimalSize.Medium, AnimalDiet.Carnivore);

            train.AddAnimalToQueue(animal);
            Assert.AreEqual(expectedValue.ToString(), animalsToAdd.ToString());
        }
    }
}
