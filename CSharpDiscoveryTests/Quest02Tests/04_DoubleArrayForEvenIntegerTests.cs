using CSharpDiscovery.Quest02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CSharpDiscoveryTests.Quest02Tests
{
    [TestClass]
    public class _04_DoubleArrayForEvenIntegerTests
    {
        [TestMethod]
        public void DoubleArrayForEvenInteger_simpleArray_OK()
        {
            var inputTab = new int[] { 1, 32, 7, 33 };
            var resultTab = new int[] { 2, 32, 14, 66 };
            Assert.IsTrue(resultTab.SequenceEqual(_04_DoubleArrayForEvenInteger.DoubleArrayForEvenInteger(inputTab)), "La méthode doit retourner [2, 32, 14, 66] pour [1, 32, 7, 33] en entrée.");
        }
    }
}
