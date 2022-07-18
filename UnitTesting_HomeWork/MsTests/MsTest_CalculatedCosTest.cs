using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedCosTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }
        private string _value;

        [TestInitialize]
        public void InitializeTest()
        {
            _value = "25";
        }

        [TestMethod]
        public void CosTest()
        {
            double result = _calculator.Cos(_value);

            Assert.IsTrue(result >= 0);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
