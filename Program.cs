using Newtonsoft.Json;
using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

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
            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();
            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();
            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();
            //StringCases stringCases = new StringCases();
            //stringCases.ParseStringToJson();
            //stringCases.ConcatenateStrings();
            //stringCases.TrimString();
            //stringCases.SplitStringAndPrintSeparate();
            //stringCases.SplitStringAndCleanEmptySpaces();
            //stringCases.ConvertingCharToUppercase();
            //stringCases.ConvertStringToUppercase();
            //stringCases.ParseValuesFromString();

            //BasicVariables basicVariables = new BasicVariables();
            //basicVariables.CompareUnassignedValues();
            //basicVariables.CompareDifferentAssignedValues();
            //basicVariables.CompareSameAssignedValues();
            //basicVariables.CompareFloatAndDouble();
            //basicVariables.CompareFloatAndDoubleUsingCycle();
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
            //ConditionalMethods conditionalMethods = new ConditionalMethods();
            //conditionalMethods.CompareBooleanVariables();
            //conditionalMethods.CompareNumericVariables();
            //conditionalMethods.CompareStringsUsingTernaryOperator();
            //conditionalMethods.CompareOperandsUsingLogicalAND();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalAND();
            //conditionalMethods.CompareOperandsUsingLogicalOR();
            //conditionalMethods.CompareOperandsUsingConditionalLogicalOR();
            //conditionalMethods.ComparingUsingEqualityOperatorAndEqualsMethod();
            //conditionalMethods.UsingBitwiseOperators();
            //conditionalMethods.DefineAge();

            //Collections collections = new Collections();
            //collections.ListCollectionMethods();
            //collections.LinkedListCollectionMethods();
            //collections.HashSetCollectionMethods();
            //collections.HashMapCollectionMethods();
            //collections.IdentifyUniqueArrayElements();
            //collections.PetsListMethods();
            //collections.PoliticiansSortedListMethods();
            //ValidParentheses validParentheses = new ValidParentheses();
            //string input1 = "(3+5)*4/7+(7-3))";
            //Debug.WriteLine(validParentheses.Valid(input1));
            //object[] array = new object[5] { 1, 1.1111, "Sharad", 'c', 2.79769313486232E+3 };
            //validParentheses.ValidArray(array);

            ExceptionsCases exceptionsCases = new ExceptionsCases();
            exceptionsCases.DivideInteger(55, 0);
            exceptionsCases.DivideInteger("44", "0");
            exceptionsCases.DivideInteger(12, "0");
            exceptionsCases.DivideIntegerWithSwitch("33", "0");
            exceptionsCases.DivideIntegerWithSwitchPattern("77", "0");
            exceptionsCases.FindItemInCollection(4);
            exceptionsCases.CreateFile();
            exceptionsCases.DifferentLogLevels();
            //conditionalMethods.DefineAge();

            //Collections collections = new Collections();
            //collections.ListCollectionMethods();
            //collections.LinkedListCollectionMethods();
            //collections.HashSetCollectionMethods();
            //collections.HashMapCollectionMethods();
            //collections.IdentifyUniqueArrayElements();
            //collections.PetsListMethods();
            //collections.PoliticiansSortedListMethods();
            //ValidParentheses validParentheses = new ValidParentheses();
            //string input1 = "(3+5)*4/7+(7-3))";
            //Debug.WriteLine(validParentheses.Valid(input1));
            //object[] array = new object[5] { 1, 1.1111, "Sharad", 'c', 2.79769313486232E+3 };
            //validParentheses.ValidArray(array);
            //conditionalMethods.DefineAge();
            //conditionalMethods.DefineAge();

            //Collections collections = new Collections();
            //collections.ListCollectionMethods();
            //collections.LinkedListCollectionMethods();
            //collections.HashSetCollectionMethods();
            //collections.HashMapCollectionMethods();
            //collections.IdentifyUniqueArrayElements();
            //collections.PetsListMethods();
            //collections.PoliticiansSortedListMethods();
            //ValidParentheses validParentheses = new ValidParentheses();
            //string input1 = "(3+5)*4/7+(7-3))";
            //Debug.WriteLine(validParentheses.Valid(input1));
            //object[] array = new object[5] { 1, 1.1111, "Sharad", 'c', 2.79769313486232E+3 };
            //validParentheses.ValidArray(array);

            FileOperationsCases fileOperationsCases = new FileOperationsCases();
            HomeActivity myHomeActivity = new HomeActivity("Ironing", 2, "Saturday");
            string serialized = JsonConvert.SerializeObject(myHomeActivity, Formatting.Indented);
            Debug.WriteLine(serialized.DeserializeJson<HomeActivity>());
            Debug.WriteLine($"{myHomeActivity.Name}, {myHomeActivity.Duration}, {myHomeActivity.WeekDay}");
            fileOperationsCases.WritingJsonToFile(myHomeActivity);
            fileOperationsCases.ReadingFromFile();

        }
    }
}
