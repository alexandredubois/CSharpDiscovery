using CSharpDiscovery.Quest05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDiscoveryTests.Quest05Tests
{
    [TestClass]
    public class _03_AreEqualsTests
    {
        [TestMethod]
        public void AreEquals_SameTable_True()
        {
            var tab = new int[]{ 1, 2, 3, 4, 5};

            Assert.IsTrue(_03_AreEquals.AreEquals(tab, tab));
        }

        [TestMethod]
        public void AreEquals_DifferentTable_False()
        {
            var tab1 = new int[] { 1, 2, 3, 4, 5 };
            var tab2 = new int[] { 1, 2, 3, 4, 6 };

            Assert.IsFalse(_03_AreEquals.AreEquals(tab1, tab2));
        }

        [TestMethod]
        public void AreEquals_DifferentSize_False()
        {
            var tab1 = new int[] { 1, 2, 3, 4, 5 };
            var tab2 = new int[] { 1, 2, 3, 4 };

            Assert.IsFalse(_03_AreEquals.AreEquals(tab1, tab2));
        }
    }
}
