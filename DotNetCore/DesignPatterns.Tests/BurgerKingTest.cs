using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurgerKing;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class BurgerKingTest
    {
        [TestMethod]
        public void Should_LittleCheeseburger_and_LightKetchup_return_9()
        {
            double price = new Ketchup(new Light(), new LittleCheeseburger()).GetPrice();
            Assert.AreEqual(9, price);
        }

        [TestMethod]
        public void Should_BaconCheeseburger_and_PlentyKetchup_return_14()
        {
            double price = new Ketchup(new Plenty(), new BaconCheeseburger()).GetPrice();
            Assert.AreEqual(15, price);
        }
        [TestMethod]
        public void Should_Cheeseburger_and_NormalKetchup_and_PlentyMustard_return_17() {
            double price = new Mustard(new Plenty(), new Ketchup(new Normal(), new Cheeseburger())).GetPrice();
            Assert.AreEqual(18, price);
        }
    }
}