using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using NUnit.Framework;
using System.Diagnostics;

namespace HelloWorld
{
    public class FileOperationsAdvancedCases
    {

        public void CreateFile(string fileName)
        {
            FileStream fs = File.Create(TestContext.CurrentContext.TestDirectory + fileName);
            fs.Close();
        }

        public void CreateDirectory(string directoryName)
        {
            DirectoryInfo dir = new DirectoryInfo(TestContext.CurrentContext.TestDirectory);
            DirectoryInfo subDir = dir.CreateSubdirectory(directoryName);
        }

        public void WriteToFile()
        {
            string path = TestContext.CurrentContext.TestDirectory + @"\FirstFile.txt";

            using (var tw = new StreamWriter(path, true))
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "This is the first line!");
                }
                else
                {
                    tw.WriteLine("This is the next line!");
                }
            }
        }

        public void ReadFile()
        {
            using (StreamReader file = new StreamReader(TestContext.CurrentContext.TestDirectory + @"\FirstFile.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Debug.WriteLine(ln);
                    counter++;
                }
                file.Close();
            }
        }

        public void ViewFileInfo()
        {
            FileInfo FileProps = new FileInfo(TestContext.CurrentContext.TestDirectory + @"\FirstFile.txt");
            Debug.WriteLine(nameof(FileProps.FullName) + ": " + FileProps.FullName);
            Debug.WriteLine(nameof(FileProps.CreationTime) + ": " + FileProps.CreationTime);
            Debug.WriteLine(nameof(FileProps.LastAccessTime) + ": " + FileProps.LastAccessTime);
            Debug.WriteLine(nameof(FileProps.LastWriteTime) + ": " + FileProps.LastWriteTime);
            Debug.WriteLine(nameof(FileProps.Length) + ": " + FileProps.Length);
        }

        public void ListFiles()
        {
            string[] filesArray = Directory.GetFiles(TestContext.CurrentContext.TestDirectory);
            foreach (string file in filesArray)
            {
                Debug.WriteLine(file);
            }
        }

        public void ListDirectories()
        {
            string[] directoriesArray = Directory.GetDirectories(TestContext.CurrentContext.TestDirectory);
            foreach (string dir in directoriesArray)
            {
                Debug.WriteLine(dir);
            }
        }

       
    }
}
