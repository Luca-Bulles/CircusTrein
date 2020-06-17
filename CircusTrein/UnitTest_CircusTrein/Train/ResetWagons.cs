using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Train
{
    [TestClass]
    public class ResetWagons
    {
        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void ResetWagons1()
        {
            train.AddAnimalToQueue(MockAnimals.testAnimals[0]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[3]);
            train.AddAnimalToQueue(MockAnimals.testAnimals[6]);

            train.ResetWagons();

            Assert.AreEqual(1, train.RetrieveWagons().Count);
        }
    }
}
