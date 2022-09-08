using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StringCases stringCases = new StringCases();
            stringCases.ParseStringToJson();
            stringCases.ConcatenateStrings();
            stringCases.TrimString();
            stringCases.SplitStringAndPrintSeparate();
            stringCases.SplitStringAndCleanEmptySpaces();
            stringCases.ConvertingCharToUppercase();
            stringCases.ConvertStringToUppercase();
            stringCases.ParseValuesFromString();

            BasicVariables basicVariables = new BasicVariables();
            //basicVariables.CompareUnassignedValues();
            //basicVariables.CompareDifferentAssignedValues();
            //basicVariables.CompareSameAssignedValues();
            //basicVariables.CompareFloatAndDouble();
            basicVariables.CompareFloatAndDoubleUsingCycle();
            //basicVariables.DivideValuesByZero();
            //basicVariables.DivideValuesByIntAndAssignResult();
            //basicVariables.DivideValuesByDoubleAndMakeRound();

            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();

            //Cycles cycles = new Cycles();
            //cycles.ForLoop();
            //cycles.ForLoopReverse();
            //cycles.WhileLoop();
            //cycles.DoWhileLoop();
            //Console.WriteLine($"Factorial number is: {cycles.FactorialWithExit(5)}");
            //Console.WriteLine($"Factorial number is: {cycles.FactorialNoExit(5)}");// Stack Overflow exception
            //cycles.InfiniteLoopFor();// is executed indefinitely
            //cycles.PrintingArrayUsingForeach();
            //Console.WriteLine($"Reversed number: {cycles.ReverseNumber(753081)}");
            //cycles.CheckIfPalindrome(753357);
            //Console.WriteLine("Hello World!");
            ConditionalMethods conditionalMethods = new ConditionalMethods();
            //conditionalMethods.CompareBooleanVariables();
            //conditionalMethods.CompareNumericVariables();
            //conditionalMethods.CompareStringsUsingTernaryOperator();
            //conditionalMethods.CompareOperandsUsingLogicalAND();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalAND();
            //conditionalMethods.CompareOperandsUsingLogicalOR();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalOR();
            //conditionalMethods.ComparingUsingEqualityOperatorAndEqualsMethod();
            //conditionalMethods.UsingBitwiseOperators();
            conditionalMethods.DefineAge();
        }
    }
}
