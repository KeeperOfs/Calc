using System;

namespace Calculator.SingleArgument
{
    public class Arccos : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            if (argument < -1 || argument > 1)
            {
                throw new Exception("Арк от 0");
            }
            return Math.Acos(argument);
        }

    }
}
