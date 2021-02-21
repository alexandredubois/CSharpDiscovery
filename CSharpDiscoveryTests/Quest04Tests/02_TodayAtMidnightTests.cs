using CSharpDiscovery.Quest04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDiscoveryTests.Quest04Tests
{
    [TestClass]
    public class _02_TodayAtMidnightTests
    {

        [TestMethod]
        public void TodayAtMidnight()
        {
            Assert.AreEqual(DateTime.Today, _02_TodayAtMidnight.TodayAtMidnight(), "Le retour attendu pour cette méthode est " + DateTime.Today.ToString());
        }
    }
}
