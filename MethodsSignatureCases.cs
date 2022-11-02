using HelloWorld.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class MethodsSignatureCases
    {
        public static LoggerWrapper log;
        static MethodsSignatureCases()
        {
            log = new LoggerWrapper(log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }

        /// <summary>
        /// Method to search value by key in Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string SearchByKeyFirstOption(int key, Dictionary<int, string > dictionary)
        {
            log.Info($"Searching value by key {key} in {dictionary}");
            return dictionary[key];// searching value by key
;        }

        /// <summary>
        /// Generic method to search value by key in Dictionary 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue SearchByKeySecondOption<T, TKey, TValue>(T dictionary, TKey key) where T: Dictionary<TKey, TValue>
        {
            log.Info($"Searching value by key {key} in {dictionary}");
            return dictionary[key];// searching value by key
        }

        /// <summary>
        /// Generic method to add new element to Dictionary or replace element if the key already exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddNewOrUpdateExisting<T, TKey, TValue>(T dictionary, TKey key, TValue value) where T : Dictionary<TKey, TValue>
        {
            if (dictionary.ContainsKey(key)) // if specified key already exists
            {
                log.Info($"Replacing element with existing key {key} to the new one {key}, {value}");
                dictionary[key] = value; // replacing the value to the new one
            }
            else // if specified key does not exist
            {
                log.Info($"Adding a new element {key}, {value}");
                dictionary.Add(key, value); // add new element
            }

        }

        /// <summary>
        /// Generic method to delete element from Dictionary by key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        public static void DeleteByKey<T, TKey, TValue>(T dictionary, TKey key) where T : Dictionary<TKey, TValue>
        {
            log.Info($"Deleting element with key {key}");
            dictionary.Remove(key);// deleting element by key
        }


        /// <summary>
        /// Method to add a list of items to Dictionary consuming List in parameters
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="itemsToAdd"></param>
        public static void AddRange<TKey, TValue>(Dictionary<TKey, TValue> dictionary, List<KeyValuePair<TKey, TValue>> itemsToAdd)
        {
            itemsToAdd.ForEach(x => dictionary.Add(x.Key, x.Value));
        }

        /// <summary>
        /// Method to add multiple items to Dictionary consuming key-value pairs as params
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddRange<T, TKey, TValue>(Dictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> value)
        {
            dictionary.Add(value.Key, value.Value);
        }




    }
}
