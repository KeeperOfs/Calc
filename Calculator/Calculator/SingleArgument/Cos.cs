using System;

namespace Calculator.SingleArgument
{
    public class Cos : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
    {
        return Math.Cos(argument);
    }
    
    }
}
