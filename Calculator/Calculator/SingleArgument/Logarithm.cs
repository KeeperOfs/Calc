using System;

namespace Calculator.SingleArgument
{
    class Logarithm : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
        {
            return Math.Log(Argument);
        }
   
    }
}
