﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class DivisionTests
    {
        [TestCase(6, 3, 2)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
