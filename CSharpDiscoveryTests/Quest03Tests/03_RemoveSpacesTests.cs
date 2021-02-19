using CSharpDiscovery.Quest03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest03Tests
{
    [TestClass]
    public class _03_RemoveSpacesTests
    {
        [TestMethod]
        public void RemoveSpaces_stringWithSpaceAtTheEnd_stringTrimmed()
        {
            Assert.AreEqual("NoSpaceLeftAtTheEnd", _03_RemoveSpaces.RemoveSpaces("NoSpaceLeftAtTheEnd "),"La méthode doit supprimer les espaces en fin de chaîne");
        }

        [TestMethod]
        public void RemoveSpaces_stringWithSpaceAtTheBeginning_stringTrimmed()
        {
            Assert.AreEqual("NoSpaceLeftAtTheBeginning", _03_RemoveSpaces.RemoveSpaces(" NoSpaceLeftAtTheBeginning"), "La méthode doit supprimer les espaces en début de chaîne");
        }

        [TestMethod]
        public void RemoveSpaces_stringWithSpaceEverywhere_stringTrimmed()
        {
            Assert.AreEqual("No Space Left At The Beginning Nor The End", _03_RemoveSpaces.RemoveSpaces(" No Space Left At The Beginning Nor The End "), "La méthode doit supprimer les espaces en début et fin de chaîne uniquement");
        }

        [TestMethod]
        public void RemoveSpaces_onlySpaces_emptyString()
        {
            Assert.AreEqual(string.Empty, _03_RemoveSpaces.RemoveSpaces("         "), "La méthode doit supprimer les espaces en début et fin de chaîne. S'il n'y a que des espaces elle renvoit une chaîne vide");
        }
    }
}
