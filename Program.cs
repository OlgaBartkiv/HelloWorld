using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Operators operators = new Operators();
            operators.MathOperations();
            operators.RetrieveRandomItem();
        }
    }
}
