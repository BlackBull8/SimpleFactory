using System;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            AbstractOperation abstractOperation = SimpleFactory.GetOperation("+");
            abstractOperation.Number1 = 2;
            abstractOperation.Number2 = 4;
            Console.WriteLine(abstractOperation.GetResult());
            Console.ReadKey();
        }
    }
}