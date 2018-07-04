using System;

namespace Calculator.SingleArgument
{
    public class Ctg : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }

    }
    
    
}
