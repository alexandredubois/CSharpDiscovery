using CSharpDiscovery.Quest03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest03Tests
{
    [TestClass]
    public class _02_CapitalizeTests
    {
        [TestMethod]
        public void Capitalize_Ynov_YNOV()
        {
            Assert.AreEqual("YNOV", _02_Capitalize.Capitalize("Ynov"));
        }
    }
}
