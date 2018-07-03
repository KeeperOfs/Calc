﻿using System;

namespace Calculator
{
    class SqrtRoot : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double Argument)
        {
            return Math.Sqrt(Argument);
        }
    }
}
