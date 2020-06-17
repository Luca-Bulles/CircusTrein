using CircusTrein;
using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Wagon
{
    [TestClass]
    public class RetrieveLeftOverSizeTest
    {
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();

        [TestMethod]
        public void RetrieveLeftOverSize1()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(9, actualValue);
        }

        [TestMethod]
        public void RetrieveLeftOverSize2()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[3]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(7, actualValue);
        }
        [TestMethod]
        public void RetrieveLeftOverSize3()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[6]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(5, actualValue);
        }

        [TestMethod]
        public void RetrieveLeftOverSize4()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[6]);
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(4, actualValue);
        }

        [TestMethod]
        public void RetrieveLeftOverSize5()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[6]);
            wagon.InsertInWagon(MockAnimals.testAnimals[3]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(2, actualValue);
        }

        [TestMethod]
        public void RetrieveLeftOverSize6()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[6]);
            wagon.InsertInWagon(MockAnimals.testAnimals[3]);
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            int actualValue = wagon.RetrieveLeftOverSize();
            Assert.AreEqual(1, actualValue);
        }
    }
}
