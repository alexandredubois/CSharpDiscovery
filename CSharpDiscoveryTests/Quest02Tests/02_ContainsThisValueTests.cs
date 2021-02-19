using CSharpDiscovery.Quest02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDiscoveryTests.Quest02Tests
{
    [TestClass]
    public class _02_ContainsThisValueTests
    {
        [TestMethod]
        public void ContainsThisValue_ContainsValue_True()
        {
            var tab = new int[5] { 99, 98, 92, 97, 95 };
            Assert.IsTrue(_02_ContainsThisValue.ContainsThisValue(tab, 97), "La méthode doit retourner \"true\" si le tableau contient la valeur passée en paramètre");
        }

        [TestMethod]
        public void ContainsThisValue_DoNotContainValue_False()
        {
            var tab = new int[5] { 99, 98, 92, 97, 95 };
            Assert.IsFalse(_02_ContainsThisValue.ContainsThisValue(tab, 2), "La méthode doit retourner \"false\" si le tableau ne contient pas la valeur passée en paramètre");
        }

        [TestMethod]
        public void ContainsThisValue_NullTable_False()
        {
            Assert.IsFalse(_02_ContainsThisValue.ContainsThisValue(null, 2), "La méthode doit retourner \"false\" si le tableau est vide ou nul");
        }
    }
}
