using System;

namespace Calculator.SingleArgument
{
    class Cos : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
    {
        return Math.Cos(Argument);
    }
    
    }
}
