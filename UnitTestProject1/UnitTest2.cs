using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using UnitTestDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        Mock<ICalculator> calculatormock;
        [TestInitialize]
        public void Initialize()
        {
            Program.addResult = Program.divResult = Program.mulResult = Program.subResult = 0;
            calculatormock = new Mock<ICalculator>(MockBehavior.Default);
            calculatormock.CallBase = false;
            calculatormock.Setup(x => x.Add(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Sub(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Divide(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Multiply(10, 15)).Returns(10);
            Program.calc = calculatormock.Object;
        }

        [TestMethod]
        public void TestAddition()
        {
            Program.CallCalculatorMethods(10,15);
            Assert.AreEqual(Program.addResult, 10);
            Assert.AreEqual(Program.divResult, 10);
            Assert.AreEqual(Program.mulResult, 10);
            Assert.AreEqual(Program.subResult, 10);
        }

        [TestCleanup]
        public void Cleanup()
        {
            calculatormock.VerifyAll();
        }
    }
}
