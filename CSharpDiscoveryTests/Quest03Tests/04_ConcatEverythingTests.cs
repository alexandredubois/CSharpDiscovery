using CSharpDiscovery.Quest03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest03Tests
{
    [TestClass]
    public class _04_ConcatEverythingTests
    {
        [TestMethod]
        public void ConcatEverything_tableWithStrings_ConcatedString()
        {
            Assert.AreEqual("successfull", _04_ConcatEverything.ConcatEverything(new string[] { "success", "full" }),"Cette méthode doit concaténer les différentes chaînes du tableau.");
        }

        [TestMethod]
        public void ConcatEverything_tableWithEmptyStrings_ConcatedString()
        {
            Assert.AreEqual("success", _04_ConcatEverything.ConcatEverything(new string[] { "success", "" }), "Cette méthode doit concaténer les différentes chaînes du tableau.");
        }
    }
}
