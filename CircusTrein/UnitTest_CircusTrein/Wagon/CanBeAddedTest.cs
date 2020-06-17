using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Wagon
{
    [TestClass]
    public class CanBeAddedTest
    {
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();

        [TestMethod]
        public void CanBeAddedToFilledList1()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[12]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[13]);

            Assert.AreEqual(false, actualValue);
        }
        [TestMethod]
        public void CanBeAddedToFilledList2()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[12]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[6]);

            Assert.AreEqual(true, actualValue);
        }

        [TestMethod]
        public void CanBeAddedToFilledList3()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[6]);
            wagon.InsertInWagon(MockAnimals.testAnimals[5]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[6]);

            Assert.AreEqual(false, actualValue);
        }

        [TestMethod]
        public void CanBeAddedToFilledList4()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[9]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[9]);

            Assert.AreEqual(false, actualValue);
        }

        [TestMethod]
        public void CanBeAddedToFilledList5()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[17]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[15]);

            Assert.AreEqual(false, actualValue);
        }

        [TestMethod]
        public void CanBeAddedToFilledList6()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            bool actualValue = wagon.CanBeAdded(MockAnimals.testAnimals[17]);

            Assert.AreEqual(false, actualValue);
        }
    }
}
