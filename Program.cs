﻿using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Operators operators = new Operators();
            operators.MathOperations();
            NullValidation nullValidation = new NullValidation();
            nullValidation.RetrieveRandomItem();
            nullValidation.RetrieveItemUsingCycle();
            nullValidation.AddNotNullItemsToCollection();

        }
    }
}
