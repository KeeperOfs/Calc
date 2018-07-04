using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
        [TestFixture]
        public class SumTests
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Sum();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
    }
}