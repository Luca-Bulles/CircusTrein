using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestResetWagons
    {
        //Test Fields
        List<CircusTrein.Wagon> wagons = new List<CircusTrein.Wagon>();
        List<CircusTrein.Wagon> expectedWagons = new List<CircusTrein.Wagon>() { new CircusTrein.Wagon() };
        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void ResetWagons()
        {
            wagons.Add(new CircusTrein.Wagon());

            var expectedValue = expectedWagons;
            train.ResetWagons();
            var actualValue = wagons;

            Assert.AreEqual(expectedValue.ToString(), actualValue.ToString());
        }
    }
}
