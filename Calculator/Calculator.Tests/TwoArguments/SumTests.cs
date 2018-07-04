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
            [Test]
            public void CalculateTest()
            {
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("sum");
                double result = calculator.Calculate(4,4);
                Assert.AreEqual(8, result);
            }
        }
    }