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

            Cycles cycles = new Cycles();
            cycles.ForLoop();
            cycles.WhileLoop();
            cycles.DoWhileLoop();
            Console.WriteLine($"Factorial number is: {cycles.FactorialWithExit(5)}");
            //Console.WriteLine($"Factorial number is: {cycles.FactorialNoExit(5)}");// Stack Overflow exception
            //cycles.InfiniteLoopFor();// is executed indefinitely
            cycles.PrintingArrayUsingForeach();
            Console.WriteLine($"Reversed number: {cycles.ReverseNumber(753081)}");
            cycles.CheckIfPalindrome(753357);
        }
    }
}
