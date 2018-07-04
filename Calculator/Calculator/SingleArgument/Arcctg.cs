using System;

namespace Calculator.SingleArgument
{
    public class Arcctg : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return 1 / Math.Atan(argument);
        }

    }
     
}
