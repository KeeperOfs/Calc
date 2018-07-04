using System;

namespace Calculator.SingleArgument
{
    public class Arctan : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            
            return Math.Atan(argument);
        }
    
    }
}
