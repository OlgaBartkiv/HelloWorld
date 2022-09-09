using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Collections collections = new Collections();
            collections.ListCollectionMethods();
            collections.LinkedListCollectionMethods();
            collections.HashSetCollectionMethods();
            collections.HashMapCollectionMethods();
            collections.IdentifyUniqueArrayElements();
            collections.PetsListMethods();
            collections.PoliticiansSortedListMethods();
            ValidParentheses validParentheses = new ValidParentheses();
            string input1 = "(3+5)*4/7+(7-3))";
            Debug.WriteLine(validParentheses.Valid(input1));
            object[] array = new object[5] { 1, 1.1111, "Sharad", 'c', 2.79769313486232E+3 };
            validParentheses.ValidArray(array);
        }
    }
}
