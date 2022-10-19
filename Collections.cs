using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Collections
    {
        
        public void ListCollectionMethods()
        {
            List<string> Countries = new List<string>() { "Ukraine", "Poland", "Lithuania", "Italy" };
            
            // adding elements to collection
            Countries.Add("Spain");
            // printing all the elements in updated collection
            Console.WriteLine(string.Join(",", Countries));

            // get first element of the collection
            string firstCountry = Countries[0];
            Console.WriteLine(firstCountry);

            // removing the first element in collection
            Countries.Remove(firstCountry);
            // printing all the elements in updated collection
            Console.WriteLine(string.Join(",", Countries));

            // counting the number of elements in collection
            Console.WriteLine($"Count of elements: {Countries.Count}");
        }

        public void LinkedListCollectionMethods()
        {
            LinkedList<int> Seasons = new LinkedList<int>();

            // adding elements to the collection
            Seasons.AddFirst(3);
            Seasons.AddFirst(2);
            Seasons.AddFirst(1);
            Seasons.AddLast(4);
            // printing all the elements in collection
            Console.WriteLine("Linked list elements are: ");
            foreach(int i in Seasons)
            {
                Console.WriteLine(i);
            }

            // get the first element value from the collection
            Console.WriteLine($"First element is: {Seasons.First.Value}");

            // removing first element in collection
            Seasons.RemoveLast();
            // printing all the elements in updated collection
            Console.WriteLine("Linked list elements are: ");
            foreach (int i in Seasons)
            {
                Console.WriteLine(i);
            }

            // counting the number of elements in collection
            Console.WriteLine($"Count of elements: {Seasons.Count}");
        }

        public void HashSetCollectionMethods()
        {
            HashSet<int> Salary = new HashSet<int>();

            // adding elements to the collection
            Salary.Add(10);
            Salary.Add(10000);
            Salary.Add(100);
            Salary.Add(200);
            // printing all the elements in collection
            Console.WriteLine("HashSet list of elements are: ");
            foreach (int i in Salary)
            {
                Console.WriteLine(i);
            }

            // if element exists in collection
            var mySalary = Salary.Contains(10000);
            Console.WriteLine($"My salary is: {mySalary}");

            // removing element from collection
            Salary.Remove(10);

            // counting the number of elements in collection
            Console.WriteLine($"Count of elements: {Salary.Count}");
        }

        public void HashMapCollectionMethods()
        {
            Dictionary<int, string> Flowers = new Dictionary<int, string>();

            // adding elements to the collection
            Flowers.Add(5, "Rose");
            Flowers.Add(8, "Camomile");
            Flowers.Add(3, "Poppy");
            // printing the elements of collection
            foreach (var flower in Flowers)
            {
                Console.WriteLine($"Key: {flower.Key} Value: {flower.Value}");
            }

            // get Value from Key
            string theBest = Flowers[3];
            Console.WriteLine($"The best flower is {theBest}");

            // remove element from collection
            Flowers.Remove(5);

            // counting the number of elements in collection
            Console.WriteLine($"Count of elements: {Flowers.Count}");
        }

        public void IdentifyUniqueArrayElements()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 5, 15, 3, 7, 8, 5, 2, 9, 5, 1, 11, 12, 14, 5, 2 };

            var duplicates = myArray.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => new { Item = y.Key, Count = y.Count() }).ToList();

            Debug.WriteLine(String.Join("\n", duplicates));
        }

        public void PetsListMethods()
        {
            Pet pet1 = new Pet ("Dog", "Chester", 15);
            Pet pet2 = new Pet ("Cat", "Musya", 5.5f);
            Pet pet3 = new Pet ("Rabbit","Debby", 1.8f);
            Pet pet4 = new Pet ("Dog", "Rey", 13);
            Pet pet5 = new Pet ("Cat", "Richard", 5.9f);

            List<Pet> pets = new List<Pet>() { pet1, pet2, pet3, pet4, pet5 };


            //sort collection by weight
            Debug.WriteLine("sorted by weight ascending:");

            List<Pet> sorted = pets.OrderBy(x => x.Weight).ToList();
            Debug.WriteLine(String.Join(Environment.NewLine, sorted));

            //calculate capacity
            Debug.WriteLine("Initial Capacity of Pets collection is: " + pets.Capacity);

            //calculate count of elements
            Debug.WriteLine("Initial Count of elements in Pets collection is: " + pets.Count);

            //using TrimExcess method to remove extra capacity
            pets.TrimExcess();
            Debug.WriteLine("After TrimExcess: ");
            Debug.WriteLine("Capacity: " + pets.Capacity);
            Debug.WriteLine("Count: " + pets.Count);

            // adding one more element to collection
            Pet pet6 = new Pet("Chicken", "Bill", 1.1f);
            pets.Add(pet6);
            Debug.WriteLine("After element was added: ");
            Debug.WriteLine("Capacity: " + pets.Capacity);
            Debug.WriteLine("Count: " + pets.Count);

            // find pet by alias using Find method
            Debug.WriteLine(("Found pet with alias \"Rey\": ", pets.Find(x => x.Alias == "Rey")));

            // find pet by alias using IndexOf method
            int index = pets.IndexOf(pet4);
            Debug.WriteLine("Index of pet \"Rey\": " + index);

            // delete element
            pets.RemoveAt(index);
            Debug.WriteLine("After element was removed: ");
            foreach (var a in pets)
            {
                Debug.WriteLine(a);
            }

            // search pet by Type
            string petToFind = "Cat";
            List<Pet> results = pets.FindAll(
            delegate (Pet pt)
            {
                return pt.Type == petToFind;
            }
            ).ToList();
            Debug.WriteLine("Found all Cats:");
            Debug.WriteLine(String.Join(Environment.NewLine, results));
        }

        public void PoliticiansSortedListMethods()
        {
            SortedList<int, string> politicians = new SortedList<int, string>();
            SortedList < int, Politician > politicians2 = new SortedList<int, Politician>();

            string politician1 = "1, Volodymyr, Zelensky, 44, President";
            string politician2 = "2, Boris, Johnson, 58, Prime Minister";
            string politician3 = "3, Huylo, Putin, 69, President";

            politicians.Add(80, politician1);
            politicians.Add(90, politician2);
            politicians.Add(1, politician3);

            // adding politicians using parameterized constructor
            Politician politician4 = new Politician(4, "Bill", "Clinton", 76, "Ex-President");
            Politician politician5 = new Politician(5, "Olaf", "Scholz", 64, "Chancellor");
            Politician politician6 = new Politician(6, "Huylo", "Putin", 69, "President");

            politicians2.Add(35, politician4);
            politicians2.Add(55, politician5);
            politicians2.Add(1, politician6);

            // reading through SortedList
            foreach (KeyValuePair<int, Politician> kvp in politicians2)
            {
                Debug.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, GetPoliticianInfo(kvp.Value));
            }

            // find top-rated politician
            int topRated = politicians2.Keys.Max();
            int indexTopRated = politicians2.IndexOfKey(topRated);
            Debug.WriteLine($"The top-rated politician is: rating:{topRated}, info:{GetPoliticianInfo(politicians2.Values[indexTopRated])}");

            // delete element from SortedList
            string putin = "Putin";
            int keyToRemove = politicians2.FirstOrDefault(s => s.Value.LastName.Contains(putin)).Key;
            politicians2.Remove(keyToRemove);

            foreach (KeyValuePair<int, Politician> kvp in politicians2)
            {
                Debug.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, GetPoliticianInfo(kvp.Value));
            }

        }
        /// <summary>
        /// Get Values of each element in Politician class
        /// </summary>
        /// <param name="politician"></param>
        /// <returns></returns>
        public string GetPoliticianInfo(Politician politician)
        {
            return $"{politician.Id}, {politician.FirstName}, {politician.LastName}, {politician.Age}, {politician.Position}";
        }

        public void PoliticianToJsonAndBack()
        {
            Politician president = new Politician(25, "Barack", "Obama", 61, "Ex-President");
            president.Hobbies = new List<string> { };
            president.Hobbies.Add("tennis");
            president.Hobbies.Add("gardening");
            president.Hobbies.Add("poker");
            president.Pets = new List<string> { };
            president.Pets.Add("dog");
            president.Pets.Add("cat");
            president.Pets.Add("rabbit");
            president.Salary = new List<int> { };
            president.Salary.Add(100);
            president.Salary.Add(500);
            president.Salary.Add(1000);

            var json = JsonConvert.SerializeObject(president, Formatting.Indented);
            Debug.WriteLine(json);

            var deserializedJson = JsonConvert.DeserializeObject<Politician>(json);
            Debug.WriteLine(deserializedJson);
            Debug.WriteLine($"{president.Id}, {president.FirstName}, {president.LastName}, {president.Age}, {president.Position}");

        }

    }
    /// <summary>
    /// Check the balance of parentheses
    /// </summary>
    public class ValidParentheses
    {
        List<int> allowedSymbols = new List<int> { 40, 41, 91, 93, 123, 125 };
        public bool Valid(string s)
        {
            Stack<object> myStack1 = new Stack<object>();
            foreach (char c in s.ToCharArray())
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    myStack1.Push(c); // Get left
                }
                // Compare to right
                else if (c == ')' && myStack1.Count != 0 && (char)myStack1.Peek() == '(')
                {
                    myStack1.Pop();
                }
                else if (c == '}' && myStack1.Count != 0 && (char)myStack1.Peek() == '{')
                {
                    myStack1.Pop();
                }
                else if (c == ']' && myStack1.Count != 0 && (char)myStack1.Peek() == '[')
                {
                    myStack1.Pop();
                }
                else if (!allowedSymbols.Contains(c))
                {
                    continue;
                }
                else
                {
                    return false; // no match
                }
            }
            return true;
        }

        public void ValidArray(object[] array)
        {
            foreach (var item in array)
            {
                Debug.WriteLine(Valid(item.ToString()));
            }
        }
    }
}
