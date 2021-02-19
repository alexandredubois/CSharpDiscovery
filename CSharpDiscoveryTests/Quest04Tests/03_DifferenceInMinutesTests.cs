using CSharpDiscovery.Quest04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDiscoveryTests.Quest05Tests
{
    [TestClass]
    public class _03_DifferenceInMinutesTests
    {
        [TestMethod]
        public void DifferenceInMinutes_2DateTimesTheSameDay_OK()
        {
            var start = new DateTime(2021, 02, 01, 12, 0, 0, 0);
            var end = new DateTime(2021, 02, 01, 18, 0, 0, 0);
            Assert.AreEqual(360, _03_DifferenceInMinutes.DifferenceInMinutes(start, end));
        }

        [TestMethod]
        public void DifferenceInMinutes_2DateTimesTheSameYear_OK()
        {
            var start = new DateTime(2021, 02, 01, 12, 23, 0, 0);
            var end = new DateTime(2021, 08, 01, 18, 0, 0, 0);
            Assert.AreEqual(260977, _03_DifferenceInMinutes.DifferenceInMinutes(start, end));
        }
    }
}
