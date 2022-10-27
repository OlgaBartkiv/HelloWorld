using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class JsonDeserializationService
    {
        public  static T DeserializeJson<T>(this string jsonString) where T : JsonModel
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"There was an error during object serialization: {ex.InnerException}");
            }
        }
    }
}
