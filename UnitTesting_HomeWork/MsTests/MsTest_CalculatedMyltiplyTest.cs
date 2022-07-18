using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    public class MsTest_CalculatedMyltiplyTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }
        private double _firstValue;
        private double _secondValue;

        [TestInitialize]
        public void InitializeTest()
        {
            _firstValue = 1;
            _secondValue = 4;
        }

        [TestMethod]
        public void MultiplyTest()
        {
            double result = _calculator.Multiply(_firstValue, _secondValue);

            Assert.IsTrue(result > 0);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
