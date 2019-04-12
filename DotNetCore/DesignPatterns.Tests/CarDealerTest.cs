using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealer;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class CarDealerTest
    {
        [TestMethod]
        public void Should_calculate_french()
        {
            FrenchOrder frenchOrder = new FrenchOrder(10);
            double result = frenchOrder.CalculateAmount();

            Assert.AreEqual(11.96, result);
        }

        [TestMethod]
        public void Should_calculate_luxembourgist()
        {
            LuxembourgishOrder luxembourgishOrder = new LuxembourgishOrder(5,10);
            double result = luxembourgishOrder.CalculateAmount();

            Assert.AreEqual(17.1, result);
        }
    }
}