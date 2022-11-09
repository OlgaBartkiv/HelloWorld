using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HelloWorld
{
    public class ArgumentsCases
    {
        public bool CompareStringsConsiderCase(string firstString, string secondString, StringComparison stringComparison = StringComparison.Ordinal)
        {
            return String.Equals(firstString, secondString, stringComparison);
        }

        public bool CompareStringsConsiderSpaces(string firstString, string secondString, bool ignoreSpace = false)
        {
            if (ignoreSpace)
            {
                return String.Equals(firstString.Replace(" ", String.Empty), secondString.Replace(" ", String.Empty));
            }
            return String.Equals(firstString, secondString);
        }

        public bool CompareDecimalsWholeValue(decimal firstDecimal, decimal secondDecimal, bool ignoreAfterDecimalPoint = false)
        {
            if (ignoreAfterDecimalPoint)
            {
                return Decimal.Equals((int)firstDecimal, (int)secondDecimal);
            }
            return Decimal.Equals(firstDecimal, secondDecimal);
        }

        public bool CompareStringsConsiderSpacesAndCase(string firstString, string secondString, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase, bool ignoreSpace = true)
        {
            if (ignoreSpace)
            {
                return String.Equals(firstString.Replace(" ", String.Empty), secondString.Replace(" ", String.Empty), stringComparison);
            }
            return String.Equals(firstString, secondString, stringComparison);
        }
       
    }
}
