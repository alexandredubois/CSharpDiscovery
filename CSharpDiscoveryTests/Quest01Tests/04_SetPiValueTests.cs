using CSharpDiscovery.Quest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest01Tests
{
    [TestClass]
    public class _04_SetPiValueTests
    {
        [TestMethod]
        public void setPiValue_RandomFloat_OK()
        {
            Assert.AreEqual(3.14159f, _04_SetPiValue.setPiValue(0));
        }
    }
}
