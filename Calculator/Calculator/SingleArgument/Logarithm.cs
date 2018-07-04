using System;

namespace Calculator.SingleArgument
{
    public class Logarithm : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Логарифм отрицательного");
            }
            return Math.Log(argument);
        }
   
    }
}
