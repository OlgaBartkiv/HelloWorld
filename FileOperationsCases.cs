using HelloWorld.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HelloWorld
{
    public enum ActivityData
    {
        Name = 0,
        Duration = 1,
        WeekDay = 2
    }

    public class FileOperationsCases
    {

        public void WritingJsonToFile(HomeActivity homeActivity)
        {
            var testDirectory = TestContext.CurrentContext.TestDirectory;

            string serialized = JsonConvert.SerializeObject(homeActivity, Formatting.Indented);

            if (IsValidJson(serialized))
            {
                File.WriteAllText(testDirectory + @"\FileA.txt", JsonConvert.SerializeObject(homeActivity));
            }
        }

        // 'using' statement is used here
        public void ReadingFromFile()
        {
            var testDirectory = TestContext.CurrentContext.TestDirectory;

            List<HomeActivity> listOfActivities = new List<HomeActivity>();
            string line;

            using (StreamReader file = new StreamReader(testDirectory + @"\FileB.txt"))
            {
                if (File.Exists(testDirectory + @"\FileB.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                        {
                            continue;
                        }
                        string[] words = line.Split(',');
                        listOfActivities.Add(new HomeActivity(words[(int)ActivityData.Name], int.Parse(words[(int)ActivityData.Duration]), words[(int)ActivityData.WeekDay]));
                    }
                    foreach (var item in listOfActivities)
                    {
                        Debug.WriteLine($"{item.Name}, {item.Duration}, {item.WeekDay}");
                    }
                    file.Close();
                }
                else
                {
                    Debug.WriteLine("Specified file does not exist");
                }

            }
                


            // re-writing to FileB in Json format
            string serializedB = JsonConvert.SerializeObject(listOfActivities, Formatting.Indented);

            if (IsValidJson(serializedB))
                File.WriteAllText(testDirectory + @"\FileB.txt", JsonConvert.SerializeObject(listOfActivities));
        }


        private static bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
