﻿using System;

namespace Calculator.SingleArgument
{
    class Tan : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Tan(argument);
        }
    
    }
}
