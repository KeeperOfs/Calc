using System;

namespace Calculator.SingleArgument
{
    class Sin : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
    {
        return Math.Sin(argument);
    }
    
    }
}
