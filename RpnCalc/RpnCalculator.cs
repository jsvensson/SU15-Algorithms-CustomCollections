using System;
using MyCollection;

namespace RpnCalc
{
    public static class RpnCalculator
    {
        public static double Calculate(string expression)
        {
            var stack = new MyStack<string> {expression.Split(' ')};
            return Evaluate(stack);
        }

        private static double Evaluate(MyStack<string> stack)
        {
            double a, b;
            string symbol = stack.Pop();

            if (double.TryParse(symbol, out a)) return a;

            a = Evaluate(stack);
            b = Evaluate(stack);

            switch (symbol)
            {
                case "+":
                    return a + b;
                case "-":
                    return b - a;
                case "*":
                    return a * b;
                case "/":
                    return b / a;
                default:
                    throw new ArgumentException("Invalid RPN syntax");
            }
        }
    }
}
