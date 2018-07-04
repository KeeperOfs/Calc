using System;

namespace Calculator.SingleArgument
{
    class Sin : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
    {
        return Math.Sin(Argument);
    }
    
    }
}
