using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedSubstructTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }
        private readonly Random _random = new Random();
        private double _firstValue;
        private double _secondValue;

        [TestInitialize]
        public void InitializeTest()
        {
            _firstValue = Convert.ToDouble(_random.Next(100) / 100.0);
            _secondValue = Convert.ToDouble(_random.Next(100) / 100.0);
        }

        [TestMethod]
        public void SubstractTest()
        {
            double result = _calculator.Sub(_firstValue, _secondValue);

            Assert.AreEqual(_firstValue - _secondValue, result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
