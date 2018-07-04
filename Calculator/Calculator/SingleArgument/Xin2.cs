using System;

namespace Calculator.SingleArgument
{
    public class Xin2 : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
