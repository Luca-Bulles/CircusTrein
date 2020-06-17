using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestInsertAnimalsToWagon
    {
        //Test Fields
        static Animal shark = new Animal("Shark", AnimalSize.Large, AnimalDiet.Carnivore);
        static Animal pidgeon = new Animal("Annoying bird", AnimalSize.Medium, AnimalDiet.Herbivore);

        private List<CircusTrein.Wagon> wagons = new List<CircusTrein.Wagon>();
        private List<Animal> animalsToAdd = new List<Animal>() { shark, pidgeon };
        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void InsertAnimalsToWagon()
        {
            train.InsertAnimalsToWagon();
            wagons.Add(new CircusTrein.Wagon());
            train.InsertAnimalsToWagon();
            wagons.Add(new CircusTrein.Wagon());


            Assert.AreEqual(2, wagons.Count);
        }
    }
}
