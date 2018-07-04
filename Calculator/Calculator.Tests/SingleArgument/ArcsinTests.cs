using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class ArcsinTests
    {
        [TestCase(0.5, 0.7853981)]
        [TestCase(0.3, 0.3046926)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");       
            Assert.Throws<Exception>(() => singlecalculator.SingleCalculate(4));
        }
    }


}

