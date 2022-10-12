using HelloWorld.Helpers;
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
        public LoggerWrapper log;

        public ExceptionsCases()
        {
            log = new LoggerWrapper(log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }

        public void DivideInteger(int x, int y)
        {
           try
            {
                log.Info($"Attempting to divide {x} by {y}");
                Debug.WriteLine(x / y);
            }
            catch (DivideByZeroException d)
            {
                Debug.WriteLine($"Division of {x} by zero");
                log.Error($"Exception is thrown: {d}");
                throw new Exception("Cannot divide by zero!");
            }

        }

        public void DivideInteger(string x, string y)
        {
            try
            {
                log.Info($"Attempting to divide {x} by {y}");
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (OverflowException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn($"Exception is caught: {e}");
            }
            catch (DivideByZeroException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Error($"Exception is thrown: {e}");
                throw e.InnerException;
            }
            catch (FormatException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn($"Exception is caught: {e}");
            }
            catch (Exception e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn($"Exception is caught: {e}");
            }
        }

        public void DivideInteger(int x, string y)
        {
            try
            {
                log.Info($"Attempting to divide {x} by {y}");
                Debug.WriteLine(x / int.Parse(y));
            }
            catch (Exception e)
            {
                if (e is FormatException || e is DivideByZeroException || e is OverflowException)
                {
                    Debug.WriteLine($"An Exception has occured: {e}");
                    log.Error($"Exception is thrown: {e}");
                    return;
                }
                throw new SystemException($"System Exception is thrown: {e.InnerException}, {e.Message}");
            }
        }

        public void DivideIntegerWithSwitch(string x, string y)
        {
            try
            {
                log.Info($"Attempting to divide {x} by {y}");
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    case FormatException f:
                        Debug.WriteLine($"An Exception has occured: {f}");
                        log.Warn($"Exception is caught: {f}");
                        break;
                    case DivideByZeroException d:
                        Debug.WriteLine($"An Exception has occured: {d}");
                        log.Warn($"Exception is caught: {d}");
                        break;
                    case OverflowException o:
                        Debug.WriteLine($"An Exception has occured: {o}");
                        log.Warn($"Exception is caught: {o}");
                        break;
                }
            }

        }

        public void DivideIntegerWithSwitchPattern(string x, string y)
        {
            try
            {
                log.Info($"Attempting to divide {x} by {y}");
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (SystemException ex)
            {
                string str = ex switch
                {
                    FormatException => "Format Exception!",
                    DivideByZeroException => "Divide By Zero Exception!",
                    OverflowException => "Overflow Exception!",
                    _ => "Unknown Exception!"
                };
                Debug.WriteLine(str);
                log.Warn($"Exception is caught: {ex}");

            }
        }

        public void FindItemInCollection(int x)
        {
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet("Hamster", "Koko", 1));
            pets.Add(new Pet("Dog", "Chester", 14));
            pets.Add(new Pet("Cat", "Masha", 5));

            try
            {
                log.Info($"Looking for pet with weight = {x}");
                Pet found = pets.Find(item => item.Weight == x);
                Debug.WriteLine($"{ found.Type}, { found.Alias}");
            }
            catch (NullReferenceException n)
            {
                Debug.WriteLine($"An Exception has occured: {n}");
                log.Error($"Exception is thrown: {n}");
                throw new Exception($"The given item was not found");
            }

        }

        public void CreateFile()
        {
            string path = @"C:\Users\obartkiv\source\repos\HelloWorld\FileC.txt";
            string message = "What a beautiful day!";

            try
            {
                if (path.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
                {
                    log.Warn("Invalid file name");
                    Debug.WriteLine("File name contains forbidden characters");
                }
                else
                {
                    log.Info($"Creating a file {path}");
                    FileStream fs = File.Create(path);
                    fs.Close();
                    log.Info($"Writing the next message in the file : {message}");
                    File.WriteAllText(path, message);
                }
                Debug.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");
            }
            catch (ArgumentException a) 
            {
                log.Warn($"Exception is caught: {a}");
            }
            catch (NotSupportedException n) 
            {
                log.Warn($"Exception is caught: {n}");
            }
            finally
            {
                if (File.Exists(path))
                {
                    log.Info($"Deleting the file {path}");
                    File.Delete(path);
                }
            }
        }

        public void DifferentLogLevels()
        {
            var politician1 = new Politician(8, "Donald", "Trump", 60, "Ex-President");
            //logging different log levels
            log.Info($"Politician1: {politician1.Id}, {politician1.FirstName}, {politician1.LastName}, {politician1.Age}, {politician1.Position}");
            log.Warn($"Warning accrued at {DateTime.Now}");
            log.Error($"Error accrued at {DateTime.Now}");
        }

    }
}
