using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.ClassLevel)]
namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedAddTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataRow(1,2)]
        [DataRow(8,-4)]
        public void AddTest(double firstValue, double secondValue)
        {
            double result = _calculator.Add(firstValue, secondValue);
            Assert.AreEqual(firstValue + secondValue, result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
