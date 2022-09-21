using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class HomeActivity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("day")]
        public string WeekDay { get; set; }

        public HomeActivity(string Name, int Duration, string WeekDay)
        {
            
            this.Name = Name;
            this.Duration = Duration;
            this.WeekDay = WeekDay;
        }

        public HomeActivity() { }
    }
}
