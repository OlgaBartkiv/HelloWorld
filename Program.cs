using System;

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
        }
    }
}
