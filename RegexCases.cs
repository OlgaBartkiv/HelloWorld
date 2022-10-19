using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class RegexCases
    {
        public void ExtractDigitsFromText()
        {
            string myString = "He was born on the 3rd of December 1990";
            string pattern = @"\D";
            string target = "";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(myString, target);
            Debug.WriteLine(result);

        }

        public void ExtractLettersFromText()
        {
            string myString = "He was born on the 3rd of December 1990";
            string pattern = @"[0-9\s]";
            string target = "";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(myString, target);
            Debug.WriteLine(result);
        }

        public void ExtractTextAfterDefinedSymbol()
        {
            string myString = "He was born on the 3rd of December 1990";
            Regex pattern = new Regex(@"on\s(.*)"); // extracting everything after 'on'
            Match match = pattern.Match(myString);
            string result = match.Groups[1].Value;
            Debug.WriteLine(result);
        }

        public void ExtractIPAddress()
        {
            string myString = "name = DBConnectionString connectionString = Provider = sqloledb; IPAddress = 91.245.223.55; Network Library = DBMSSOCN; Initial Catalog = ourDB";
            Regex pattern = new Regex(@"^.+?((?:\d+\.){3}\d+).+$"); // extracting IP Address
            Match match = pattern.Match(myString);
            string result = match.Groups[1].Value;
            Debug.WriteLine(result);
        }

        public void CreateFileAndExtractIPAddress()
        {
            Regex pattern = new Regex(@"^.+?((?:\d+\.){3}\d+).+$");
            using (StreamReader reader = new StreamReader(@"C:\Users\obartkiv\source\repos\HelloWorld\RandomText.txt"))
            {
                string result;
                while ((result = reader.ReadLine()) != null)
                {
                    Match match = pattern.Match(result);
                    if (match.Success)
                    {
                        string v = match.Groups[1].Value;
                        Debug.WriteLine(v);
                    }
                }
            }
        }
      
    }
}
