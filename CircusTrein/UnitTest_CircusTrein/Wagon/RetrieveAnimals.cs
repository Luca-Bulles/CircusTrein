using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Wagon
{
    [TestClass]
    public class RetrieveAnimals
    {
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();

        [TestMethod]
        public void RetrieveAnimals1()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            wagon.InsertInWagon(MockAnimals.testAnimals[1]);
            wagon.InsertInWagon(MockAnimals.testAnimals[2]);

            int actualValue = wagon.RetrieveAnimals().Count;
            Assert.AreEqual(3, actualValue);
        }

        [TestMethod]
        public void RetrieveAnimals2()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[4]);
            wagon.InsertInWagon(MockAnimals.testAnimals[4]);

            int actualValue = wagon.RetrieveAnimals().Count;
            Assert.AreEqual(2, actualValue);
        }

        [TestMethod]
        public void RetrieveAnimals3()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[7]);
            wagon.InsertInWagon(MockAnimals.testAnimals[7]);

            int actualValue = wagon.RetrieveAnimals().Count;
            Assert.AreEqual(2, actualValue);
        }

        [TestMethod]
        public void RetrieveAnimals4()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[12]);
            wagon.InsertInWagon(MockAnimals.testAnimals[11]);

            int actualValue = wagon.RetrieveAnimals().Count;
            Assert.AreEqual(2, actualValue);
        }
    }
}
