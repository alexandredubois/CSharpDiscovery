using CSharpDiscovery.Quest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDiscoveryTests.Quest01Tests
{
    [TestClass]
    public class _02_AddTwoIntegersTests
    {
        [TestMethod]
        public void AddTwoIntegers_2RandomInts_CorrectSumReceived()
        {
            Random rnd = new Random();
            var a = rnd.Next(0, 100);
            var b = rnd.Next(0, 100);
            Assert.AreEqual(a + b, _02_AddTwoIntegers.AddTwoIntegers(a, b), string.Format("La somme de {0} et {1} devrait retourner {2}", a, b, a + b));
        }
    }
}
