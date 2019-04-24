using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Creperie;
namespace DesignPatterns.Tests
{
    [TestClass]
    public class CreperieTest
    {
        [TestMethod]
        public void Should_waffle_and_chocolate_return_7()
        {
            Double price = new Chocolate(new Waffle()).GetPrice();
            Assert.AreEqual(7, price);
        }

        [TestMethod]
        public void Should_waffle_and_chocolate_and_chantilly_return_9()
        {
            Double price = new Chantilly(new Chocolate(new Waffle())).GetPrice();
            Assert.AreEqual(9, price);
        }
    }
}