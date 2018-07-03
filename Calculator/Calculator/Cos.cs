using System;

namespace Calculator
{
    class Cos : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
    {
        return Math.Cos(Argument);
    }
    
    }
}
