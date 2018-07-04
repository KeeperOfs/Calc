using System;

namespace Calculator.SingleArgument
{
    public class SqrtRoot : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}
