using System;

namespace Calculator.SingleArgument
{
    class SqrtRoot : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}
