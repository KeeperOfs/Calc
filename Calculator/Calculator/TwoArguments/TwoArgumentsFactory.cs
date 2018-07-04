using System;

namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name) {
            switch (name)
            {
                case "sum":
                    return new Sum();
                case "minus":
                    return new Minus();
                case "multiply":
                    return new Multiply();
                case "division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
     
    }
}
