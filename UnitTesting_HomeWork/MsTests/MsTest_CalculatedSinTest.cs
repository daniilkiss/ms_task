using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedSinTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }
        private int _value;

        [TestInitialize]
        public void InitializeTest()
        {
            _value = 270;
        }

        [TestMethod]
        public void SinTest()
        {
            double result = _calculator.Sin(_value);

            Assert.IsFalse(result >= 0);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
