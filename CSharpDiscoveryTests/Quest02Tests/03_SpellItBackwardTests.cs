using CSharpDiscovery.Quest02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest02Tests
{
    [TestClass]
    public class _03_SpellItBackwardTests
    {
        [TestMethod]
        public void SpellItBackward_HelloWorld_HelloWorldReversed()
        {
            //"helloworld" reçu, on retourne "dlrowolleh"
            Assert.AreEqual("dlrowolleh", _03_SpellItBackward.SpellItBackward("helloworld"), "La méthode doit retourner \"dlrowolleh\" pour \"helloworld\" en entrée");
        }
    }
}
