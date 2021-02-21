using CSharpDiscovery.Quest04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDiscoveryTests.Quest04Tests
{
    [TestClass]
    public class _01_DisplayDateWithoutTimeTests
    {
        [TestMethod]
        public void DisplayDateWithoutTime_MinValue_CorrectFormat()
        {
            Assert.AreEqual("01/01/0001", _01_DisplayDateWithoutTime.DisplayDateWithoutTime(DateTime.MinValue));
        }

        [TestMethod]
        public void DisplayDateWithoutTime_DDay_CorrectFormat()
        {
            Assert.AreEqual("06/06/1944", _01_DisplayDateWithoutTime.DisplayDateWithoutTime(new DateTime(1944, 06, 06)));
        }

        [TestMethod]
        public void DisplayDateWithoutTime_DadBirthday_CorrectFormat()
        {
            Assert.AreEqual("20/10/1960", _01_DisplayDateWithoutTime.DisplayDateWithoutTime(new DateTime(1960,10,20)));
        }
    }
}
