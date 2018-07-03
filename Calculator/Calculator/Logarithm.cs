using System;

namespace Calculator
{
    class Logarithm : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
        {
            return Math.Log(Argument);
        }
   
    }
}
