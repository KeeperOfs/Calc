using System;

namespace Calculator
{
    class Sin : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
    {
        return Math.Sin(Argument);
    }
    
    }
}
