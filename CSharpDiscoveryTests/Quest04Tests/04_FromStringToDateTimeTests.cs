using CSharpDiscovery.Quest04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDiscoveryTests.Quest04Tests
{
    [TestClass]
    public class _04_FromStringToDateTimeTests
    {
        [TestMethod]
        public void FromStringToDateTime_PatternWithAnH_DateTimeOK()
        {
            Assert.AreEqual(new DateTime(2021, 12, 21, 18, 33, 0, 0), _04_FromStringToDateTime.FromStringToDateTime("21/12/2021 18h33"));
        }
    }
}
