using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedAbsTest
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
        public void AbsTest()
        {
            double result = _calculator.Abs(_value);

            Assert.AreEqual(25, result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
