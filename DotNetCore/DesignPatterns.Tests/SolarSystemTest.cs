using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        [TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = Sun.Instance;
            var secondSun = Sun.Instance;
            
            Assert.AreEqual(secondSun, firstSun);
        }
    }
}
