using NUnit.Framework;
using System.Collections.Generic;
using Calculator;
using System.Linq;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_StringsAdd_Success()
        {
            Calculator c = new Calculator();
            var res = c.Calculate("1,", "+", "2");
            Assert.AreEqual(res, 3);
        }

        [Test]
        public void Calculate_StringsMultiply_Success()
        {
            Calculator c = new Calculator();
            var res = c.Calculate("3,", "*", "2");
            Assert.AreEqual(res, 6);
        }
    }
}