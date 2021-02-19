using CSharpDiscovery.Quest05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CSharpDiscoveryTests.Quest05Tests
{
    [TestClass]
    public class _02_SortTableTests
    {
        [TestMethod]
        public void SortTable_UnorderedTable_TableSorted()
        {
            var tab = new int[] { 1, 5, 2, 4, 3 };
            var sortedTab = new int[] { 1, 2, 3, 4, 5 };
            Assert.IsTrue(sortedTab.SequenceEqual(_02_SortTable.SortTable(tab)));
        }

        [TestMethod]
        public void SortTable_OrderedTable_TableSorted()
        {
            var sortedTab = new int[] { 1, 2, 3, 4, 6 };
            Assert.IsTrue(sortedTab.SequenceEqual(_02_SortTable.SortTable(sortedTab)));
        }
    }
}
