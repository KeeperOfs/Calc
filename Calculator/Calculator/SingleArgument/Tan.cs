using System;

namespace Calculator.SingleArgument
{
    class Tan : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
        {
            return Math.Tan(Argument);
        }
    
    }
}
