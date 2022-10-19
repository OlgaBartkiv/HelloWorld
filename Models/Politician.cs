using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class Politician
    {
        [JsonProperty(Required = Required.DisallowNull)]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty(Required = Required.DisallowNull)]
        public string LastName { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("hobbies")]
        public List<string> Hobbies { get; set; }

        [JsonProperty("pets")]
        public List<string> Pets { get; set; }

        [JsonProperty("salary")]
        public List<int> Salary { get; set; }

        public Politician() { }

        public Politician (int Id, string FirstName, string LastName, int Age, string Position)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Position = Position;
        }
    }
}
