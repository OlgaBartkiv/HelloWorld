using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HelloWorld
{
    public class ExceptionsCases
    {
        public void DivideInteger(int x, int y)
        {
           try
            {
                Debug.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Debug.WriteLine($"Division of {x} by zero");
                throw new Exception("Cannot divide by zero!");
            }

        }

        public void DivideInteger(string x, string y)
        {
            try
            {
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (OverflowException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
            }
            catch (DivideByZeroException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                throw e.InnerException;
            }
            catch (FormatException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
            }
            catch (SystemException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
            }
        }

        public void DivideInteger(int x, string y)
        {
            try
            {
                Debug.WriteLine(x / int.Parse(y));
            }
            catch (Exception e)
            {
                if (e is FormatException || e is DivideByZeroException || e is OverflowException)
                {
                    Debug.WriteLine($"An Exception has occured: {e}");
                    return;
                }
                throw new SystemException($"System Exception is thrown: {e.InnerException}, {e.Message}");
            }
        }

        public void DivideIntegerWithSwitch(string x, string y)
        {
            try
            {
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (SystemException ex)
            {
                switch (ex)
                {
                    case FormatException f:
                        Debug.WriteLine($"An Exception has occured: {f}");
                        break;
                    case DivideByZeroException d:
                        Debug.WriteLine($"An Exception has occured: {d}");
                        break;
                    case OverflowException o:
                        Debug.WriteLine($"An Exception has occured: {o}");
                        break;
                }
            }

        }

        //public void DivideIntegerWithSwitchPattern(string x, string y)
        //{
        //    try
        //    {
        //        Debug.WriteLine(int.Parse(x) / int.Parse(y));
        //    }
        //    catch (SystemException ex)
        //    {
        //        string str = ex switch
        //        {
        //            FormatException => "Format Exception!",
        //            DivideByZeroException => "Divide By Zero Exception!",
        //            OverflowException => "Overflow Exception!",
        //            _ => "Unknown Exception!"
        //        };
        //        Debug.WriteLine(str);

        //    }
        //}

        public void FindItemInCollection(int x)
        {
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet("Hamster", "Koko", 1));
            pets.Add(new Pet("Dog", "Chester", 14));
            pets.Add(new Pet("Cat", "Masha", 5));

            try
            {
                Pet found = pets.Find(item => item.Weight == x);
                Debug.WriteLine($"{ found.Type}, { found.Alias}");
            }
            catch (NullReferenceException n)
            {
                Debug.WriteLine($"An Exception has occured: {n}");
                throw new Exception($"The given item was not found");
            }

        }

        public void CreateFile()
        {
            string path = @"C:\Users\obartkiv\source\repos\HelloWorld\FileC.txt";
            string message = "What a beautiful day!";

            try
            {
                FileStream fs = File.Create(path);
                fs.Close();
                File.WriteAllText(path, message);

                if (path.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
                {
                    Debug.WriteLine("File name contains forbidden characters");
                }
                else
                {
                    Debug.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");
                }
            }
            catch (ArgumentException) { }
            catch (NotSupportedException) { }
            finally
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }

        }
    }
}
