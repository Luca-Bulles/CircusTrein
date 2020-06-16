using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CircusTrein;
using CirusTreinUnitTest.MockData;

namespace CirusTreinUnitTest.Train
{
    [TestClass]
    public class DoesAnimalHaveASpot
    {




        [TestMethod]
        public void DoesAnimalHaveASpotTest1()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            animals.Add(MockAnimals.testAnimals[0]);
            List<CircusTrein.Animal> actualList = new List<Animal>();

            // Act
            train.InsertAnimalsToWagon();
            var actualValue = train.RetrieveWagons();
            foreach (var wagon in actualValue)
            {
                actualList = wagon.RetrieveAnimals();
            }

            // Assert      
            CollectionAssert.AreEqual(animals, actualList);
            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest2()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[4]);
            animals.Add(MockAnimals.testAnimals[4]);
            animals.Add(MockAnimals.testAnimals[0]);
            List<CircusTrein.Animal> actualList = new List<Animal>();


            // Act
            train.InsertAnimalsToWagon();
            var actualValue = train.RetrieveWagons();
            foreach (var wagon in actualValue)
            {
                actualList = wagon.RetrieveAnimals();
            }

            // Assert      
            CollectionAssert.AreEqual(animals, actualList);
            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest3()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[4]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[4]);
            animals.Add(MockAnimals.testAnimals[0]);
            List<CircusTrein.Animal> actualList = new List<Animal>();

            // Act
            train.InsertAnimalsToWagon();
            var actualValue = train.RetrieveWagons();
            foreach (var wagon in actualValue)
            {
                actualList = wagon.RetrieveAnimals();
            }

            // Assert      
            CollectionAssert.AreEqual(animals, actualList);
            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest4()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[4]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[4]);
            animals.Add(MockAnimals.testAnimals[0]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest5()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[7]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[4]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);

            animals.Add(MockAnimals.testAnimals[8]);
            animals.Add(MockAnimals.testAnimals[7]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[4]);
            animals.Add(MockAnimals.testAnimals[0]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(3, train.RetrieveWagons().Count);
        }

        //Alleen carnivores
        [TestMethod]
        public void DoesAnimalHaveASpotTest6()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);

            animals.Add(MockAnimals.testAnimals[10]);
            animals.Add(MockAnimals.testAnimals[9]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest7()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[15]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[11]);

            animals.Add(MockAnimals.testAnimals[15]);
            animals.Add(MockAnimals.testAnimals[12]);
            animals.Add(MockAnimals.testAnimals[11]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(3, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest8()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[15]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[11]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);

            animals.Add(MockAnimals.testAnimals[15]);
            animals.Add(MockAnimals.testAnimals[12]);
            animals.Add(MockAnimals.testAnimals[11]);
            animals.Add(MockAnimals.testAnimals[10]);
            animals.Add(MockAnimals.testAnimals[9]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(5, train.RetrieveWagons().Count);
        }
        //Carnivores + Herbivores
        [TestMethod]
        public void DoesAnimalHaveASpotTest9()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);

            animals.Add(MockAnimals.testAnimals[9]);
            animals.Add(MockAnimals.testAnimals[0]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest10()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);

            animals.Add(MockAnimals.testAnimals[12]);
            animals.Add(MockAnimals.testAnimals[3]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest11()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[15]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);

            animals.Add(MockAnimals.testAnimals[15]);
            animals.Add(MockAnimals.testAnimals[8]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest12()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[14]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[2]);

            animals.Add(MockAnimals.testAnimals[8]);
            animals.Add(MockAnimals.testAnimals[14]);
            animals.Add(MockAnimals.testAnimals[2]);

            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest13()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[7]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[2]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);

            animals.Add(MockAnimals.testAnimals[8]);
            animals.Add(MockAnimals.testAnimals[7]);
            animals.Add(MockAnimals.testAnimals[6]);
            animals.Add(MockAnimals.testAnimals[3]);
            animals.Add(MockAnimals.testAnimals[2]);
            animals.Add(MockAnimals.testAnimals[0]);


            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void DoesAnimalHaveASpotTest14()
        {
            CircusTrein.Train train = new CircusTrein.Train();
            List<CircusTrein.Animal> animals = new List<Animal>();
            // Arrange
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[7]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[5]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);

            animals.Add(MockAnimals.testAnimals[7]);
            animals.Add(MockAnimals.testAnimals[12]);
            animals.Add(MockAnimals.testAnimals[5]);
            animals.Add(MockAnimals.testAnimals[9]);
            animals.Add(MockAnimals.testAnimals[0]);


            List<Animal> actualAnimals = new List<Animal>();

            train.InsertAnimalsToWagon();

            foreach (var wagon in train.RetrieveWagons())
            {
                foreach (var animal in wagon.RetrieveAnimals())
                {
                    actualAnimals.Add(animal);
                }
            }

            CollectionAssert.AreEqual(animals, actualAnimals);
            Assert.AreEqual(3, train.RetrieveWagons().Count);
        }
    }
}
