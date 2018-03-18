using System;

namespace SimpleFactory
{
    public static class SimpleFactory
    {
        public static AbstractOperation GetOperation(string symbol)
        {
            switch (symbol)
            {
                case "+":
                    return new AddOperation();
                case "-":
                    return new SubtractOperation();
                case "*":
                    return new MultiOperation();
                case "/":
                    return new DivOperation();
                default:
                    throw new ArgumentException(nameof(symbol));
            }
        }
    }
}