using HelloWorld.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class MethodsSignatureCases
    {
        public LoggerWrapper log;
        public MethodsSignatureCases()
        {
            log = new LoggerWrapper(log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }

        public void SearchDictionaryByKeyFirstOption()
        {
            Dictionary<int, string> Flowers = new Dictionary<int, string>();// creating a new Dictionary
            Flowers.Add(1, "Rose");// adding first element to Dictionary
            Flowers.Add(2, "Camomile");// adding second element to Dictionary
            Flowers.Add(3, "Poppy");// adding third element to Dictionary

            string thePrettiest = Flowers[3];// searching value by key
            log.Info($"Found the prettiest flower {thePrettiest} by key");// logging the found result
        }

        public static TValue SearchDictionaryByKeySecondOption<T, TKey, TValue>(T dictionary, TKey key) where T: Dictionary<TKey, TValue>
        {
            return dictionary[key];
        }

        




        //public static void SearchDictionaryByKeySecondOption<T>(this Dictionary<T, K> dictionary) where T : Dictionary<TKey, TValue>
        //{
        //    Dictionary<int, string> Flowers = new Dictionary<int, string>();// creating a new Dictionary
        //    Flowers.Add(1, "Rose");// adding first element to Dictionary
        //    Flowers.Add(2, "Camomile");// adding second element to Dictionary
        //    Flowers.Add(3, "Poppy");// adding third element to Dictionary
        //}


    }
}
