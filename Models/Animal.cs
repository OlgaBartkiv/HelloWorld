using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class Animal
    {
        [JsonProperty(Required = Required.Always)] // Type Required.Always
        public string Type { get; set; }

        [JsonProperty(Required = Required.Always)] // Alias Required.Always
        public string Alias { get; set; }

        [JsonProperty(Required = Required.AllowNull)] // Weight AllowNull
        public int? Weight { get; set; }

        public Animal() { }

        public Animal(string Type, string Alias, int Weight)
        {
            this.Type = Type;
            this.Alias = Alias;
            this.Weight = Weight;
        }
    }
}
