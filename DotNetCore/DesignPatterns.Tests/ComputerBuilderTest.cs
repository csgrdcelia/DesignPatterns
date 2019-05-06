using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerBuilderNs;
namespace DesignPatterns.Tests
{
    [TestClass]
    public class ComputerBuilderTest
    {
        [TestMethod]
        public void Should_expensive_computer_cost_1140() 
        {
            Computer computer = new ComputerBuilder()
                                    .SetCPU(new I7())
                                    .SetKeyboard(new RazerKeyboard())
                                    .SetMouse(new RazerMouse())
                                    .AddScreen(new Screen23Inches())
                                    .AddScreen(new Screen15Inches())
                                    .AddStorage(new HDD1To())
                                    .AddStorage(new SSD256Go())
                                    .AddRam(new RAM16Go())
                                    .AddRam(new RAM8Go())
                                    .SetHeadphone(new BoseHeadphone())
                                    .Build();
            Assert.AreEqual(300 + 150 + 80 + 80 + 100 + 50 + 40 + 40 + 90 + 40 + 170, computer.GetPrice());
        }
        [TestMethod]
        public void Should_incomplete_computer_return_exception() 
        {
            ComputerBuilder computerBuilder = new ComputerBuilder().SetBag(new EastpakBag());
            Assert.ThrowsException<IncompleteComputerException>(() => computerBuilder.Build());
        }
    }
}