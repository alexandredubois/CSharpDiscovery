using CSharpDiscovery.Quest03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest03Tests
{
    [TestClass]
    public class _05_ContainsSpecificSubstringTests
    {
        [TestMethod]
        public void ContainsSpecificSubstring_basicstring_doContains()
        {
            Assert.IsTrue(_05_ContainsSpecificSubstring.ContainsSpecificSubstring("allez courage, tu t'en sors bien", "courage"));
        }

        [TestMethod]
        public void ContainsSpecificSubstring_basicstring_doNotContains()
        {
            Assert.IsFalse(_05_ContainsSpecificSubstring.ContainsSpecificSubstring("allez courage, tu t'en sors bien", "soleil"));
        }
    }
}
