using HelloWorld.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HelloWorld
{
     public class FileOperationsCases
    {
        public void WritingJsonToFile()
        {
            HomeActivity homeActivity = new HomeActivity("Ironing", 2, "Saturday");

            string serialized = JsonConvert.SerializeObject(homeActivity, Formatting.Indented);

            if (IsValidJson(serialized))
                File.WriteAllText(@"C:\Users\obartkiv\source\repos\HelloWorld\FileA.txt", JsonConvert.SerializeObject(homeActivity));

        }

        public void ReadingFromFile()
        {
            List<HomeActivity> listOfActivities = new List<HomeActivity>();
            string line;

            StreamReader file = new StreamReader(@"C:\Users\obartkiv\source\repos\HelloWorld\FileB.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line == string.Empty)
                    continue;
                string[] words = line.Split(',');
                listOfActivities.Add(new HomeActivity(words[0], int.Parse(words[1]), words[2]));
            }
            foreach (var item in listOfActivities)
            {
                Debug.WriteLine($"{item.Name}, {item.Duration}, {item.WeekDay}");
            }
            file.Close();

            // re-writing to FileB in Json format
            string serializedB = JsonConvert.SerializeObject(listOfActivities, Formatting.Indented);

            if (IsValidJson(serializedB))
                File.WriteAllText(@"C:\Users\obartkiv\source\repos\HelloWorld\FileB.txt", JsonConvert.SerializeObject(listOfActivities));
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
