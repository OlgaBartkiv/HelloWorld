using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
     public class Pet
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("weight")]
        public float Weight { get; set; }
        public Pet() { }

        public Pet (string Type, string Alias, float Weight)
        {
            this.Type = Type;
            this.Alias = Alias;
            this.Weight = Weight;
        }
        public override string ToString()
        {
            return "[" + Type + "," + Alias + "," + Weight + "]";
        }
    }




    
}
