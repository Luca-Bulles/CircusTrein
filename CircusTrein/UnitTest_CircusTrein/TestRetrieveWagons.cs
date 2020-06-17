using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest
{
    [TestClass]
    public class TestRetrieveWagons
    {
        //Test Fields
        private List<CircusTrein.Wagon> expectedValue = new List<CircusTrein.Wagon>();
        CircusTrein.Train train = new CircusTrein.Train();

        [TestMethod]
        public void RetrieveWagons()
        {
            var actualValue = train.RetrieveWagons();

            Assert.AreEqual(expectedValue.ToString(), actualValue.ToString());
        }
    }
}
