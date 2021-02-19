using CSharpDiscovery.Models;
using CSharpDiscovery.Quest02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDiscoveryTests.Quest02Tests
{
    [TestClass]
    public class _01_NextTrafficLightColorTests
    {
        [TestMethod]
        public void GetNextTrafficLightColor_Red_Green()
        {
            Assert.AreEqual(TrafficLightColor.Green, _01_NextTrafficLightColor.GetNextTrafficLightColor(TrafficLightColor.Red), "La couleur qui suit le rouge doit être le vert");
        }

        [TestMethod]
        public void GetNextTrafficLightColor_Green_Orange()
        {
            Assert.AreEqual(TrafficLightColor.Orange, _01_NextTrafficLightColor.GetNextTrafficLightColor(TrafficLightColor.Green), "La couleur qui suit le vert doit être le orange");
        }

        [TestMethod]
        public void GetNextTrafficLightColor_Orange_Red()
        {
            Assert.AreEqual(TrafficLightColor.Red, _01_NextTrafficLightColor.GetNextTrafficLightColor(TrafficLightColor.Orange), "La couleur qui suit le orange doit être le rouge");
        }
    }
}
