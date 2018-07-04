using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("division");
            double result = calculator.Calculate(44, 4);
            Assert.AreEqual(11, result);
        }
    }
}
