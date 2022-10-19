﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Drink drink = new Drink()
            {
                Ingredients = new List<string>
                {
                    "coffee",
                    "milk",
                    "juice"
                }
            };
            Soup soup = new Soup
            {
                Ingredients = new List<string>
                {
                    "broccoli",
                    "carrot",
                    "sour cream"
                }
            };
            MainCourse mainCourse = new MainCourse
            {
                Ingredients = new List<string>
                {
                    "cheese",
                    "salmon",
                    "veel"
                }
            };
            Dessert dessert = new Dessert
            {
                Ingredients = new List<string>
                {
                    "chocolate",
                    "cream",
                    "coconut"
                }
            };

            DairyFood<Drink> dairyDrink = new DairyFood<Drink>();
            string result = dairyDrink.DairyFree(drink);
            Debug.WriteLine(result);

            DairyFood<Soup> dairySoup = new DairyFood<Soup>();
            result = dairySoup.DairyFree(soup);
            Debug.WriteLine(result);

            DairyFood<MainCourse> dairyMainCourse = new DairyFood<MainCourse>();
            result = dairyMainCourse.DairyFree(mainCourse);
            Debug.WriteLine(result);

            DairyFood<Dessert> dairyDessert = new DairyFood<Dessert>();
            result = dairyDessert.DairyFree(dessert);
            Debug.WriteLine(result);

            /// 'new' constraint implementation
            Lesson<Student> studentLesson = new Lesson<Student>(); // No error, because Student has parameterless constructor
            /*Lesson<Teacher> teacherLesson = new Lesson<Teacher>();*/ // Error, because Teacher has constructor with parameter

            StringCases stringCases = new StringCases();
            stringCases.ParseStringToJson();
            stringCases.ConcatenateStrings();
            stringCases.TrimString();
            stringCases.SplitStringAndPrintSeparate();
            stringCases.SplitStringAndCleanEmptySpaces();
            stringCases.ConvertingCharToUppercase();
            stringCases.ConvertStringToUppercase();
            stringCases.ParseValuesFromString();

            BasicVariables basicVariables = new BasicVariables();
            //basicVariables.CompareUnassignedValues();
            //basicVariables.CompareDifferentAssignedValues();
            //basicVariables.CompareSameAssignedValues();
            //basicVariables.CompareFloatAndDouble();
            basicVariables.CompareFloatAndDoubleUsingCycle();
            //basicVariables.DivideValuesByZero();
            //basicVariables.DivideValuesByIntAndAssignResult();
            //basicVariables.DivideValuesByDoubleAndMakeRound();

            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();

            //Cycles cycles = new Cycles();
            //cycles.ForLoop();
            //cycles.ForLoopReverse();
            //cycles.WhileLoop();
            //cycles.DoWhileLoop();
            //Console.WriteLine($"Factorial number is: {cycles.FactorialWithExit(5)}");
            //Console.WriteLine($"Factorial number is: {cycles.FactorialNoExit(5)}");// Stack Overflow exception
            //cycles.InfiniteLoopFor();// is executed indefinitely
            //cycles.PrintingArrayUsingForeach();
            //Console.WriteLine($"Reversed number: {cycles.ReverseNumber(753081)}");
            //cycles.CheckIfPalindrome(753357);
            //Console.WriteLine("Hello World!");
            ConditionalMethods conditionalMethods = new ConditionalMethods();
            //conditionalMethods.CompareBooleanVariables();
            //conditionalMethods.CompareNumericVariables();
            //conditionalMethods.CompareStringsUsingTernaryOperator();
            //conditionalMethods.CompareOperandsUsingLogicalAND();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalAND();
            //conditionalMethods.CompareOperandsUsingLogicalOR();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalOR();
            //conditionalMethods.ComparingUsingEqualityOperatorAndEqualsMethod();
            //conditionalMethods.UsingBitwiseOperators();
            conditionalMethods.DefineAge();

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

            AeroPress aeroPress = new AeroPress();
            aeroPress.BrewCoffee();
            //aeroPress.GrindCoffee();// gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)aeroPress).GrindCoffee(); // works as expected
            //aeroPress.FoamMilk(); // gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)aeroPress).FoamMilk(); // works as expected
            DelonghiMagnifica delonghiMagnifica = new DelonghiMagnifica();
            delonghiMagnifica.BrewCoffee();
            delonghiMagnifica.FoamMilk();
            //delonghiMagnifica.GrindCoffee(); // gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)delonghiMagnifica).GrindCoffee(); // works as expected
            BrevilleBarista brevilleBarista = new BrevilleBarista();
            brevilleBarista.BrewCoffee();
            brevilleBarista.GrindCoffee();
            brevilleBarista.FoamMilk();


            B b = new B("Bob", 14);
            Animal cow = new Animal("Masha", 700, 5);
            Debug.WriteLine(cow);
            cow.Eat("grass", 700);
            cow.Drink("water");
            cow.Sleep(10);
            cow.Poop();
            cow.Sound("Mooooooo");
            cow.Sound(SoundTypes.Mooooooo);
            int mySound = (int)SoundTypes.CluckCluck; // int value casted to enum
            Debug.WriteLine(mySound);
            Debug.WriteLine($"Integral value of {SoundTypes.CluckCluck} is {(int)mySound}");
            Dog dog = new Dog("Chester", 15, 8);
            dog.Bark();
            dog.Sleep(default);
            dog.Chew("sock");
            dog.Chew(OwnerClothItems.Hat);
            int myClothes = (int)OwnerClothItems.Pants; // int value casted to enum
            Debug.WriteLine(myClothes);
            Debug.WriteLine($"Integral value of {OwnerClothItems.Pants} is {(int)myClothes}");
            Cat cat = new Cat("Musya", 5, 4);
            cat.Meow();
            cat.Sleep(default);
            cat.Scratch("sofa");
            cat.Scratch(FurnitureItems.Doors);
            int myFurniture = (int)FurnitureItems.Table; // int value casted to enum
            Debug.WriteLine(myFurniture);
            Debug.WriteLine($"Integral value of {FurnitureItems.Table} is {(int)myFurniture}");


            //struct can be initialized without using 'new' operator
            CarStruct myCar;
            myCar.make = "BMW";
            myCar.mileage = 29000;
            myCar.Print();
            //struct initialized using 'new', in this case one of the parameters (e.g. mileage) can be skipped, a default value will be assigned for it
            CarStruct anotherCar = new CarStruct()
            {
                make = "Audi"
            };
            anotherCar.Print();

            //creating new object and calling method of class using class object
            CarClass dreamCar = new CarClass();
            dreamCar.CarDetails("Range Rover", 1000);
        }
    }
}
