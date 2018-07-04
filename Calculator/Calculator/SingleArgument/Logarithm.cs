using System;

namespace Calculator.SingleArgument
{
    public class Logarithm : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Log(argument);
        }
   
    }
}
