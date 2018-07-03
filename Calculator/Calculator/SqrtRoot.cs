using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
