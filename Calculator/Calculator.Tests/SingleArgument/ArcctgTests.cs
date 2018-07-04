using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    class ArcctgTests
    {
        [TestCase(1, 0.7853981)]
        [TestCase(0, 1.5707963)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arcctg();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
