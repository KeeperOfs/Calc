using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    class CosTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("cos");
            double result = singlecalculator.SingleCalculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
