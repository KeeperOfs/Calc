using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    class MultiplyTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("multiply");
            double result = calculator.Calculate(3, 4);
            Assert.AreEqual(12, result);
        }
    }
}
