using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld.Models
{
    public class Cat
    {
        [DefaultValue("Taras")] // Default value for Name 
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [DefaultValue(0)] // DisallowNull for Age 
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore)]
        public int Age { get; set; }

    }
}
