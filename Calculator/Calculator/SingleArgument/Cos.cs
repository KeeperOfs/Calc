using System;

namespace Calculator.SingleArgument
{
    class Cos : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
    {
        return Math.Cos(argument);
    }
    
    }
}
