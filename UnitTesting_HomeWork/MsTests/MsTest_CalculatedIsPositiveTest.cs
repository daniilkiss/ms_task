using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    public class MsTest_CalculatedIsPositiveTest
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
        public void IsPositiveTest()
        {
            bool result = _calculator.isPositive(_value);

            Assert.IsTrue(result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
