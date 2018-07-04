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
    class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("minus");
            double result = calculator.Calculate(10, 4);
            Assert.AreEqual(6, result);
        }
    }
}
