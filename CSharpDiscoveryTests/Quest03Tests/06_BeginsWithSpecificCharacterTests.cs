using CSharpDiscovery.Quest03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest03Tests
{
    [TestClass]
    public class _06_BeginsWithSpecificCharacterTests
    {
        [TestMethod]
        public void BeginsWithSpecificCharacter_basic_doStart()
        {
            Assert.IsTrue(_06_BeginsWithSpecificCharacter.BeginsWithSpecificCharacter("alexandre", 'a'));
        }

        [TestMethod]
        public void BeginsWithSpecificCharacter_basic_doNotStart()
        {
            Assert.IsTrue(_06_BeginsWithSpecificCharacter.BeginsWithSpecificCharacter("alexandre", 'g'));
        }
    }
}
