using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strategy.Strategy.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int _a = 7;
        private readonly int _b = 21;

        [TestMethod()]
        public void CalculateTest_Sum()
        {
            Assert.AreEqual(Calculator.Calculate(_a, _b, new SumStrategy()), _a + _b);
        }

        [TestMethod()]
        public void CalculateTest_Subtraction()
        {
            Assert.AreEqual(Calculator.Calculate(_a, _b, new SubtractionStrategy()), _a - _b);
        }

        [TestMethod()]
        public void CalculateTest_Multiplication()
        {
            Assert.AreEqual(Calculator.Calculate(_a, _b, new MultiplicationStrategy()), _a * _b);
        }
    }
}