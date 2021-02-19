using CSharpDiscovery.Quest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest01Tests
{
    [TestClass]
    public class _01_HelloWorldTests
    {
        [TestMethod]
        public void HelloWorld_Basic_ReceiveHelloWorld()
        {
            var result = _01_HelloWorld.HelloWorld();
            Assert.AreEqual("Hello World !", result, "La chaîne de caractères retournée n'est pas égale à \"Hello World !\"");
        }
    }
}
