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
    class SqrtRootTests
    {
        [TestCase(64, 8)]
        [TestCase(81, 9)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new SqrtRoot();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
