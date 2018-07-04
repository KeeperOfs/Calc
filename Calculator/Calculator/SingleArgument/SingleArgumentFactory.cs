using System;

namespace Calculator.SingleArgument
{
     public class SingleArgumentFactory
    {
        public static ISingleArgumentCalculatorcs CreateSingleCalculate(string name)
        {
            switch (name)
            {
                case "root":
                    return new SqrtRoot();
                case "ln":
                    return new Logarithm();
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "tan":
                    return new Tan();
                case "x2":
                    return new Xin2();
                case "arcsin":
                    return new Arcsin();
                case "arccos":
                    return new Arccos();
                case "arctan":
                    return new Arctan();
                case "ctg":
                    return new Ctg();
                case "arcctg":
                    return new Arcctg();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
