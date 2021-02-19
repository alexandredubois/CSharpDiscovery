using CSharpDiscovery.Quest05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest05Tests
{
    [TestClass]
    public class _01_FindThisValueTests
    {
        [TestMethod]
        public void FindThisValue_ValueHere_True()
        {
            Assert.IsTrue(_01_FindThisValue.FindThisValue(new int[] { 1, 2, 3, 4, 5 }, 5));
        }

        [TestMethod]
        public void FindThisValue_ValueNotHere_False()
        {
            Assert.IsFalse(_01_FindThisValue.FindThisValue(new int[] { 1, 2, 3, 4, 5 }, 15));
        }

        [TestMethod]
        public void FindThisValue_tabEmpty_False()
        {
            Assert.IsFalse(_01_FindThisValue.FindThisValue(new int[0], 15));
        }

        [TestMethod]
        public void FindThisValue_tabNull_False()
        {
            Assert.IsFalse(_01_FindThisValue.FindThisValue(null, 15));
        }
    }
}
