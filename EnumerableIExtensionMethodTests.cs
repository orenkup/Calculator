using NUnit.Framework;
using System.Collections.Generic;
using Calculator;
using System.Linq;

namespace Calculator.Tests
{
    public class EnumerableIExtensionMethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetIndexesOfItem_ReturnAsteriskAtPosition2_Success()
        {
            IEnumerable<string> items = new List<string>() { "1", "2", "*", "3", "4" };

            var asteriskPosition = items.GetIndexesOfItem("*").First();

            Assert.AreEqual(2, asteriskPosition);
        }

        [Test]
        public void GetIndexesOfItem_2AsterisksInList()
        {
            IEnumerable<string> items = new List<string>() { "1", "2", "*", "*", "4" };

            var p = items.GetIndexesOfItem("*");

            Assert.AreEqual(2, p.Count());
        }
    }
}