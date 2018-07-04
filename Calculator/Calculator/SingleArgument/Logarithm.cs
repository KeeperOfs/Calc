using System;

namespace Calculator.SingleArgument
{
    class Logarithm : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Log(argument);
        }
   
    }
}
