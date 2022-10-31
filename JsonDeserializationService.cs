using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    
    public static class JsonDeserializationService
    {
        /// <summary>
        /// Extension method to deserialize json string into model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public  static T DeserializeJson<T>(this string jsonString) where T : JsonModel
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"There was an error during object deserialization: {ex.InnerException}");
            }
        }

        /// <summary>
        /// Extension method to serialize model into json string
        /// </summary>
        /// <param name="theObject"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static string SerializeToJson<T>(this T theObject, Formatting formatting = Formatting.None) where T : JsonModel
        {
            try
            {
                return JsonConvert.SerializeObject(theObject, formatting);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"There was an error during object serialization: {ex.InnerException}");
            }

        }
    }

}
