using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Operators
    {
        public void MathOperations()
        {
            int a, b, c;
            a = 5; b = 2;
            c = a + b;
            b += 3;
            a -= 4;

            Debug.WriteLine($"a={a}, b={b}, c={c}");
        }

        public void MathOperationsForString()
        {
            string a = "Beautiful ";
            string b = "day";
            Debug.WriteLine(a + b);

            a += "garden";
            Debug.WriteLine(a);
        }

    }
    public class NullValidation
    {
        public object RetrieveRandomItem()
        {
            List<object> myList = new List<object>() { 1, 1.1111, "Sharad", null, 'c', 2.79769313486232E+3 };

            Random rnd = new Random();
            object result = myList[rnd.Next(0, myList.Count)];
            if (result != null)
                Debug.WriteLine($"random item: {result}");
            return result;
        }

        public void RetrieveItemUsingCycle()
        {
            object newObject = null;
            while (newObject == null)
            {
                newObject = RetrieveRandomItem();
                Debug.WriteLine(newObject);
            }
        }

        public void AddNotNullItemsToCollection()
        {
            List <object> secondList = new List<object> () { 10, "Donald", 2.79769313486232E+3, 's', 35.5, null };

            object newObject1 = RetrieveRandomItem();
            object newObject2 = RetrieveRandomItem();
            object newObject3 = RetrieveRandomItem();

            if (newObject1 != null)
            {
                secondList.Add(newObject1);
                Debug.WriteLine(newObject1);
            }
            if (newObject2 != null)
            {
                secondList.Add(newObject2);
                Debug.WriteLine(newObject2);
            }
            if (newObject3 != null)
            {
                secondList.Add(newObject3);
                Debug.WriteLine(newObject3);
            }

            Debug.WriteLine(String.Join(", ", secondList));
        }

        public void AddNotNullItemsToCollectionVersionTwo()
        {
            List<object> secondList = new List<object>() { 10, "Donald", 2.79769313486232E+3, 's', 35.5, null };

            object item;
            int secondListInitialSize = secondList.Count;
            do
            {
                item = RetrieveRandomItem();
                if (item != null)
                {
                    secondList.Add(item);
                }
                continue;
                    
            }
            while (secondList.Count < secondListInitialSize + 3);
            Debug.WriteLine(String.Join(", ", secondList));

        }



    }
}
