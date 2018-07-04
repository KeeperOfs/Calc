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
    class TwoArgumentsFactoryTest
    {
        [TestCase("sum", typeof(Sum))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("multiply", typeof(Multiply))]
        [TestCase("division", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
