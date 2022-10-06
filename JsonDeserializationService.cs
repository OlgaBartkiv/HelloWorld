using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class JsonDeserializationService
    {
        public  static string DeserializeJson<T>(T customObject) where T : JsonModel
        {
            var myString = JsonConvert.SerializeObject(customObject, Formatting.Indented);
            var deserializedObject = JsonConvert.DeserializeObject<T>(myString);
            return deserializedObject.ToString();
        }
    }
}
