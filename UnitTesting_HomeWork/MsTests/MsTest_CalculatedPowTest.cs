using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting_HomeWork.MsTests
{
    [TestClass]
    public class MsTest_CalculatedPowTest
    {
        private readonly Calculator _calculator = new Calculator();
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","TestData.xml", "Variable", DataAccessMethod.Sequential)]
        public void PowTest()
        {
            int value = Convert.ToInt32(TestContext.DataRow["Value"].ToString()); 
            double power = Convert.ToDouble(TestContext.DataRow["Power"].ToString()); 

            double result = _calculator.Pow(value, power);

            Assert.AreEqual(8, result);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            string result = TestContext.CurrentTestOutcome.ToString();
            TestContext.WriteLine($"Test result: {result}");
        }
    }
}
