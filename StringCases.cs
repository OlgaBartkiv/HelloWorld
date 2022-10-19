using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace HelloWorld
{
     public class StringCases
    {
        string weird = "   egweerw  ererferw  kuy  yu i ";
        
        public void ParseStringToJson()
        {
            string myString = @"[{""name"":""John"", ""age"":30, ""car"":null}]";

            //JObject json = JObject.Parse(myString);
            //Console.WriteLine(json.ToString()); // using Newtonsoft Nuget

            JsonDocument doc = JsonDocument.Parse(myString);
            JsonElement content = doc.RootElement;
            Console.WriteLine(content);

            var a1 = content[0];
            Console.WriteLine(a1.GetProperty("name"));
            Console.WriteLine(a1.GetProperty("age"));
        }

        public void ConcatenateStrings()
        {
            string s1 = "good";
            string s2 = "morning";

            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            string s4 = string.Concat(s1, " ", s2);
            Console.WriteLine(s4);

            string[] values = new string[] { s1, s2 };
            string s5 = string.Join(" ", values);
            Console.WriteLine(s5);
        }

        public void TrimString()
        {
            Console.WriteLine($"Lenght of the string: {weird.Length}");

            weird = weird.Trim();
            Console.WriteLine($"Trimmed lenght: {weird.Length}");
        }

        public void SplitStringAndPrintSeparate()
        {
            string[] words = weird.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

        }

        public void SplitStringAndCleanEmptySpaces()
        {
            string[] words = weird.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }

        public void ConvertingCharToUppercase()
        {
            //converting first 'w' to uppercase
            StringBuilder sb = new StringBuilder(weird);
            char firstLetter = 'w';
            int indexOfChar = weird.IndexOf(firstLetter);
            sb[indexOfChar] = 'W';
            weird = sb.ToString();
            Console.WriteLine(weird);
        }

        public void ConvertStringToUppercase()
        {
            // converting all character to uppercase
            Console.WriteLine(weird.ToUpper());

            // converting all 'w' to uppercase
            weird = weird.Replace("w", "W");
            Console.WriteLine(weird);
        }

        public void ParseValuesFromString()
        {
            string prices = "this item previous price $5.99, Sale price $1.99.";

            Regex regex = new Regex(@"\d+\.?\d*");
            MatchCollection matches = regex.Matches(prices);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
