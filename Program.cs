using Newtonsoft.Json;
using HelloWorld.Models;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using HelloWorld.Services;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Drink drink = new Drink()
            //{
            //    Ingredients = new List<string>
            //    {
            //        "coffee",
            //        "milk",
            //        "juice"
            //    }
            //};
            //Soup soup = new Soup
            //{
            //    Ingredients = new List<string>
            //    {
            //        "broccoli",
            //        "carrot",
            //        "sour cream"
            //    }
            //};
            //MainCourse mainCourse = new MainCourse
            //{
            //    Ingredients = new List<string>
            //    {
            //        "cheese",
            //        "salmon",
            //        "veel"
            //    }
            //};
            //Dessert dessert = new Dessert
            //{
            //    Ingredients = new List<string>
            //    {
            //        "chocolate",
            //        "cream",
            //        "coconut"
            //    }
            //};

            //DairyFood<Drink> dairyDrink = new DairyFood<Drink>();
            //string result = dairyDrink.DairyFree(drink);
            //Debug.WriteLine(result);

            //DairyFood<Soup> dairySoup = new DairyFood<Soup>();
            //result = dairySoup.DairyFree(soup);
            //Debug.WriteLine(result);

            //DairyFood<MainCourse> dairyMainCourse = new DairyFood<MainCourse>();
            //result = dairyMainCourse.DairyFree(mainCourse);
            //Debug.WriteLine(result);

            //DairyFood<Dessert> dairyDessert = new DairyFood<Dessert>();
            //result = dairyDessert.DairyFree(dessert);
            //Debug.WriteLine(result);

            /// 'new' constraint implementation
            /*Lesson<Student> studentLesson = new Lesson<Student>();*/ // No error, because Student has parameterless constructor
            /*Lesson<Teacher> teacherLesson = new Lesson<Teacher>();*/ // Error, because Teacher has constructor with parameter

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

            //ExceptionsCases exceptionsCases = new ExceptionsCases();
            //exceptionsCases.DivideInteger(55, 0);
            //exceptionsCases.DivideInteger("44", "0");
            //exceptionsCases.DivideInteger(12, "0");
            //exceptionsCases.DivideIntegerWithSwitch("33", "0");
            //exceptionsCases.DivideIntegerWithSwitchPattern("77", "0");
            //exceptionsCases.FindItemInCollection(4);
            //exceptionsCases.CreateFile();
            //exceptionsCases.DifferentLogLevels();
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

            //FileOperationsCases fileOperationsCases = new FileOperationsCases();
            //HomeActivity myHomeActivity = new HomeActivity("Ironing", 2, "Saturday");
            //string serialized = JsonConvert.SerializeObject(myHomeActivity, Formatting.Indented);
            //Debug.WriteLine(serialized.DeserializeJson<HomeActivity>());
            //Debug.WriteLine($"{myHomeActivity.Name}, {myHomeActivity.Duration}, {myHomeActivity.WeekDay}");
            //fileOperationsCases.WritingJsonToFile(myHomeActivity);
            //fileOperationsCases.ReadingFromFile();


            //var dictionary1 = new Dictionary<int, Enum?> { { 1, null }, { 2, null }, { 3, null }, { 4, null }, { 5, null } };
            //var dictionary2 = new Dictionary<int, Enum?> { {1, null },{ 2, Achievement.Special }, { 3, null }, { 4, Achievement.Complimented }, { 5, Achievement.Identified } };
            //var dictionary3 = new Dictionary<int, Enum?> { { 1, Achievement.Awards }, { 2, Achievement.Reorganized }, { 3, Achievement.Complimented }, { 4, Achievement.Identified }, { 5, Achievement.Developed } };
            //var dictionary4 = new Dictionary<int, Enum?> { { 1, Achievement.Developed }, { 2, null }, {3, Achievement.Reorganized }, { 4, Achievement.Identified }, { 5, null } };
            //var dictionary5 = new Dictionary<int, Enum?> { { 1, Achievement.Complimented }, { 2, null }, { 3, null }, { 4, null }, { 5, null } };
            //List<Employee> meteorTeam = new List<Employee>()
            //{
            //    new Employee() { FirstName = "Alex", LastName = "Bradbury", Position = "Developer", AchievementsByMonth = dictionary1, IsAwarded = false },
            //    new Employee() { FirstName = "Olya", LastName = "Bartkiv", Position = "QA", AchievementsByMonth = dictionary2, IsAwarded = false},
            //    new Employee() { FirstName = "Taras", LastName = "Onyshko", Position = "Developer", AchievementsByMonth = dictionary3, IsAwarded = true},
            //    new Employee() { FirstName = "Davinder", LastName = "Kainth", Position = "Developer", AchievementsByMonth = dictionary4, IsAwarded = false},
            //    new Employee() { FirstName = "Olha", LastName = "Bodnarchuk", Position = "QA", AchievementsByMonth = dictionary5, IsAwarded = false}
            //};

            //EmployeeService employeeService = new EmployeeService();
            //employeeService.Goat(1, meteorTeam);
            //employeeService.Goat(2, meteorTeam);
            //employeeService.Goat(3, meteorTeam);
            //employeeService.Goat(4, meteorTeam);
            //employeeService.Goat(5, meteorTeam);


            TaxiDriver taxiDriver = new TaxiDriver();
            Debug.WriteLine(taxiDriver.CompareAndStoreBiggerValue(8, 10));
            taxiDriver.AddingHours(out int sleepHours, out int workHours, out int total);
            Debug.WriteLine($"Sleep hours = {sleepHours}, work hours = {workHours}, in total = {total} hours");

            Employee employee = new Employee();
            employee.PrintGreeting("Olga");

            Employee newEmployee = new Employee();
            var candidate = new Employee() { Salary = 4000, FeedbackScore = 10 };
            newEmployee.DoOffer(candidate);

        }


    }
}
