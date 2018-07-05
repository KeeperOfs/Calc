using System;

namespace Calculator.SingleArgument
{
    public class Arcctg : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Atan(1 / argument);
        }

    }
     
}
