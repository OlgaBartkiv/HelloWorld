using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConditionalMethods conditionalMethods = new ConditionalMethods();
            conditionalMethods.CompareBooleanVariables();
            conditionalMethods.CompareNumericVariables();
            conditionalMethods.CompareStringsUsingTernaryOperator();
            conditionalMethods.CompareOperandsUsingLogicalAND();
            conditionalMethods.CompareOperandsUsingConditionalLogicalAND();
            conditionalMethods.CompareOperandsUsingLogicalOR();
            conditionalMethods.CompareOperandsUsingConditionalLogicalOR();
            conditionalMethods.ComparingUsingEqualityOperatorAndEqualsMethod();
            conditionalMethods.UsingBitwiseOperators();
            conditionalMethods.DefineAge();
        }
    }
}
