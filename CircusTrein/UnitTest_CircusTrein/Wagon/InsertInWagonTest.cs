using CirusTreinUnitTest.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.Wagon
{
    [TestClass]
    public class InsertInWagonTest
    {
        CircusTrein.Wagon wagon = new CircusTrein.Wagon();

        [TestMethod]
        public void IsWagonFull1()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[8]);
            wagon.InsertInWagon(MockAnimals.testAnimals[8]);
            bool actualValue = wagon.IsWagonFull;

            Assert.IsTrue(actualValue);
        }


        [TestMethod]
        public void IsWagonFull2()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[8]);
            bool actualValue = wagon.IsWagonFull;

            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void IsWagonFull3()
        {
            wagon.InsertInWagon(MockAnimals.testAnimals[0]);
            wagon.InsertInWagon(MockAnimals.testAnimals[3]);
            wagon.InsertInWagon(MockAnimals.testAnimals[8]);
            bool actualValue = wagon.IsWagonFull;

            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void IsWagonFull4()
        {
            for (int i = 0; i < 3; i++)
            {
                wagon.InsertInWagon(MockAnimals.testAnimals[0]);
                wagon.InsertInWagon(MockAnimals.testAnimals[1]);
                wagon.InsertInWagon(MockAnimals.testAnimals[2]);
            }

            bool actualValue = wagon.IsWagonFull;

            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void IsWagonFull5()
        {
            for (int i = 0; i < 4; i++)
            {
                wagon.InsertInWagon(MockAnimals.testAnimals[0]);
                wagon.InsertInWagon(MockAnimals.testAnimals[1]);
                wagon.InsertInWagon(MockAnimals.testAnimals[2]);
            }

            bool actualValue = wagon.IsWagonFull;

            Assert.IsTrue(actualValue);
        }
    }
}
