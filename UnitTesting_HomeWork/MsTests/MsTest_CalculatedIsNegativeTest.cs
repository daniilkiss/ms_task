using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedIsNegativeTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }
        private int _value;

        [TestInitialize]
        public void InitializeTest()
        {
            _value = 25;
        }

        [TestMethod]
        public void IsNegativeTest()
        {
            bool result = _calculator.isNegative(_value);

            Assert.IsFalse(result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
