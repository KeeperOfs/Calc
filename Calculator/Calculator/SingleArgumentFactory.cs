using System;

namespace Calculator
{
    class SingleArgumentFactory
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
