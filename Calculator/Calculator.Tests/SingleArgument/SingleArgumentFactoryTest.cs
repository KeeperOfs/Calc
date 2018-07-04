using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class SingleArgumentFactoryTest
    {
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("ln", typeof(Logarithm))]
        [TestCase("root", typeof(SqrtRoot))]
        [TestCase("x2", typeof(Xin2))]
        public void SingleCalculateTest(string name, Type type)
        {
            var calculator = SingleArgumentFactory.CreateSingleCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }


    }
}
