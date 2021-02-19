using CSharpDiscovery.Quest05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest05Tests
{
    [TestClass]
    public class _04_FindLastIndexTests
    {
        [TestMethod]
        public void FindLastIndex_OnlyOneOccurence_1()
        {
            var tab = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(1, _04_FindLastIndex.FindLastIndex(tab, 2));
        }

        [TestMethod]
        public void FindLastIndex_TwoOccurences_4()
        {
            var tab = new int[] { 1, 2, 3, 4, 2 };
            Assert.AreEqual(4, _04_FindLastIndex.FindLastIndex(tab, 2));
        }

        [TestMethod]
        public void FindLastIndex_NoOccurence_Null()
        {
            var tab = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(null, _04_FindLastIndex.FindLastIndex(tab, 17));
        }

        [TestMethod]
        public void FindLastIndex_NoTable_Null()
        {
            Assert.AreEqual(null, _04_FindLastIndex.FindLastIndex(null, 17));
        }
    }
}
