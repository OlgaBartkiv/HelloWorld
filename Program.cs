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
        }
    }
}
