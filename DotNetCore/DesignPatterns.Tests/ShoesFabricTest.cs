using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoesFabric;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ShoesFabricTest
    {
        [TestMethod]
        public void Should_return_leather_sandal()
        {
            LeatherFabric leatherFabric = new LeatherFabric();  
            
            Assert.IsTrue(leatherFabric.CreateSandal() is LeatherSandal);
        }

        [TestMethod]
        public void Should_return_leather_streetshoe()
        {
            LeatherFabric leatherFabric = new LeatherFabric();  
            
            Assert.IsTrue(leatherFabric.CreateShoe() is LeatherStreetShoe);
        }

        [TestMethod]
        public void Should_return_synthetic_sandal()
        {
            SyntheticFabric syntheticFabric = new SyntheticFabric();  
            
            Assert.IsTrue(syntheticFabric.CreateSandal() is SyntheticSandal);
        }

        [TestMethod]
        public void Should_return_synthetic_shoe()
        {
            SyntheticFabric syntheticFabric = new SyntheticFabric();  
            
            Assert.IsTrue(syntheticFabric.CreateShoe() is SyntheticStreetShoe);
        }



        



        
    }
}