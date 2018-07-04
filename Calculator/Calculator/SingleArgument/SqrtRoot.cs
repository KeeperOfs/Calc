using System;

namespace Calculator.SingleArgument
{
    class SqrtRoot : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
        {
            return Math.Sqrt(Argument);
        }
    }
}
