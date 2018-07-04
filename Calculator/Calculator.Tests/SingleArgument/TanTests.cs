using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    class TanTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("tan");
            double result = singlecalculator.SingleCalculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
