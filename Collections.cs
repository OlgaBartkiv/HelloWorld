using System;
using System.Collections.Generic;
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


    }
}
