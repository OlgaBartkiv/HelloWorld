using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RegexCases regexCases = new RegexCases();
            regexCases.ExtractDigitsFromText();
            regexCases.ExtractLettersFromText();
            regexCases.ExtractTextAfterDefinedSymbol();
            regexCases.ExtractIPAddress();
            regexCases.CreateFileAndExtractIPAddress();
        }
    }
}
