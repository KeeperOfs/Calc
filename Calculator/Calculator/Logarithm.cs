using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
