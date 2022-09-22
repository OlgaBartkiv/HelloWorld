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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void DivideInteger(int x, int y)
        {
           try
            {
                log.Info(String.Format("Attempting to divide {0} by {1}", x, y));
                Debug.WriteLine(x / y);
            }
            catch (DivideByZeroException d)
            {
                Debug.WriteLine($"Division of {x} by zero");
                log.Error(String.Format("Exception is thrown: {0}", d));
                throw new Exception("Cannot divide by zero!");
            }

        }

        public void DivideInteger(string x, string y)
        {
            try
            {
                log.Info(String.Format("Attempting to divide {0} by {1}", x, y));
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (OverflowException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn(String.Format("Exception is caught: {0}", e));
            }
            catch (DivideByZeroException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Error(String.Format("Exception is thrown: {0}", e));
                throw e.InnerException;
            }
            catch (FormatException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn(String.Format("Exception is caught: {0}", e));
            }
            catch (SystemException e)
            {
                Debug.WriteLine($"An Exception has occured: {e}");
                log.Warn(String.Format("Exception is caught: {0}", e));
            }
        }

        public void DivideInteger(int x, string y)
        {
            try
            {
                log.Info(String.Format("Attempting to divide {0} by {1}", x, y));
                Debug.WriteLine(x / int.Parse(y));
            }
            catch (Exception e)
            {
                if (e is FormatException || e is DivideByZeroException || e is OverflowException)
                {
                    Debug.WriteLine($"An Exception has occured: {e}");
                    log.Error(String.Format("Exception is thrown: {0}", e));
                    return;
                }
                throw new SystemException($"System Exception is thrown: {e.InnerException}, {e.Message}");
            }
        }

        public void DivideIntegerWithSwitch(string x, string y)
        {
            try
            {
                log.Info(String.Format("Attempting to divide {0} by {1}", x, y));
                Debug.WriteLine(int.Parse(x) / int.Parse(y));
            }
            catch (SystemException ex)
            {
                switch (ex)
                {
                    case FormatException f:
                        Debug.WriteLine($"An Exception has occured: {f}");
                        log.Warn(String.Format("Exception is caught: {0}", f));
                        break;
                    case DivideByZeroException d:
                        Debug.WriteLine($"An Exception has occured: {d}");
                        log.Warn(String.Format("Exception is caught: {0}", d));
                        break;
                    case OverflowException o:
                        Debug.WriteLine($"An Exception has occured: {o}");
                        log.Warn(String.Format("Exception is caught: {0}", o));
                        break;
                }
            }

        }

        public void DivideIntegerWithSwitchPattern(string x, string y)
        {
            try
            {
                log.Info(String.Format("Attempting to divide {0} by {1}", x, y));
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
                log.Warn(String.Format("Exception is caught: {0}", ex));

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
                log.Info(String.Format("Looking for pet with weight = {0}", x));
                Pet found = pets.Find(item => item.Weight == x);
                Debug.WriteLine($"{ found.Type}, { found.Alias}");
            }
            catch (SystemException n)
            {
                Debug.WriteLine($"An Exception has occured: {n}");
                log.Error(String.Format("Exception is thrown: {0}", n));
                throw new Exception($"The given item was not found");
            }

        }

        public void CreateFile()
        {
            string path = @"C:\Users\obartkiv\source\repos\HelloWorld\FileC.txt";
            string message = "What a beautiful day!";

            try
            {
                log.Info(String.Format("Creating a file {0}", path));
                FileStream fs = File.Create(path);
                fs.Close();
                log.Info(String.Format("Writing the next message in the file : {0}", message));
                File.WriteAllText(path, message);

                if (path.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
                {
                    log.Warn(String.Format("Invalid file name"));
                    Debug.WriteLine("File name contains forbidden characters");
                }
                else
                {
                    Debug.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");
                }
            }
            catch (ArgumentException a) 
            {
                log.Warn(String.Format("Exception is caught: {0}", a));
            }
            catch (NotSupportedException n) 
            {
                log.Warn(String.Format("Exception is caught: {0}", n));
            }
            finally
            {
                if (File.Exists(path))
                {
                    log.Info(String.Format("Deleting the file {0}", path));
                    File.Delete(path);
                }
            }
        }

        public void DifferentLogLevels()
        {
            var politician1 = new Politician(8, "Donald", "Trump", 60, "Ex-President");
            // logging different log levels
            log.Info(String.Format("Politician1: {0}", politician1));
            log.Warn(String.Format("Warning accrued at {0}", DateTime.Now));
            log.Error(String.Format("Error accrued at {0}", DateTime.Now));
        }

    }
}
