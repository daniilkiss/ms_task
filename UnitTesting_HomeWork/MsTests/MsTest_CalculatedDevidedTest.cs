using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedDevidedTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataRow(4.4,2.2)]
        public void DevideTest(double firstValue, double secondValue)
        {
            double result = _calculator.Divide(firstValue, secondValue);

            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
