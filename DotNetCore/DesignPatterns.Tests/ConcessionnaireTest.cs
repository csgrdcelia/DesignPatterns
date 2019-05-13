using Microsoft.VisualStudio.TestTools.UnitTesting;
using Concessionnaire;


namespace DesignPatterns.Tests
{
    [TestClass]
    public class ConcessionnaireTest
    {
        [TestMethod]
        public void ShouldCar_PaidInCash_Return5000()
        {
            Command command = new Command();
            command.AddCar(new Car());
            command.AddPaymentMode(new Cash());
            
            Assert.AreEqual(5000, command.Pay());
        }

        [TestMethod]
        public void ShouldCar_PaidIn10Months_Return5100()
        {
            Command command = new Command();
            command.AddCar(new Car());
            command.AddPaymentMode(new Credit(new TenPayments()));
            
            Assert.AreEqual(5100, command.Pay());
        }
    }
}