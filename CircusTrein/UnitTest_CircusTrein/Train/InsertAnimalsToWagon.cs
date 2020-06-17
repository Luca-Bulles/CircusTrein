using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Train
{
    [TestClass]
    public class InsertAnimalsToWagon
    {
        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void InserAnimalsToWagonTest1()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest2()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[1]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest3()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[1]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }
        [TestMethod]
        public void InserAnimalsToWagonTest4()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[1]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest5()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[1]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[8]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(3, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest6()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.InsertAnimalsToWagon();

            Assert.AreEqual(2, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest7()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[10]);

            train.InsertAnimalsToWagon();

            Assert.AreEqual(5, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest8()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[15]);

            train.InsertAnimalsToWagon();

            Assert.AreEqual(4, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest9()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);

            train.InsertAnimalsToWagon();

            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }

        [TestMethod]
        public void InserAnimalsToWagonTest10()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[15]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[12]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[9]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);

            train.InsertAnimalsToWagon();

            Assert.AreEqual(4, train.RetrieveWagons().Count);
        }
    }
}
