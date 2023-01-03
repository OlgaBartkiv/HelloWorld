using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class AuthToken : JsonModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        public AuthToken() { }
    }
}
