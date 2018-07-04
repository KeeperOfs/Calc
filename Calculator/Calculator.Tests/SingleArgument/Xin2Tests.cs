using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    class Xin2Tests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("x2");
            double result = singlecalculator.SingleCalculate(4);
            Assert.AreEqual(16, result);
        }
    }
}
