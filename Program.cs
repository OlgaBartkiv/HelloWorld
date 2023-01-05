using Newtonsoft.Json;
using HelloWorld.Models;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using RateSetter.WorkingDays;
using static HelloWorld.HomeDevicesFactory;

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
            /*Lesson<Student> studentLesson = new Lesson<Student>(); */// No error, because Student has parameterless constructor
            /* Lesson<Student> studentLesson = new Lesson<Student>(); */// No error, because Student has parameterless constructor
            /*Lesson<Teacher> teacherLesson = new Lesson<Teacher>();*/ // Error, because Teacher has constructor with parameter
                                                                       ///// 'new' constraint implementation
                                                                       //Lesson<Student> studentLesson = new Lesson<Student>(); // No error, because Student has parameterless constructor
            ///*Lesson<Teacher> teacherLesson = new Lesson<Teacher>();*/ // Error, because Teacher has constructor with parameter

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


            //TaxiDriver taxiDriver = new TaxiDriver() { SleepHours = 8 };
            //Debug.WriteLine(taxiDriver.SleepHours);
            //TaxiDriverExtensions.CompareAndStoreBiggerValue(ref taxiDriver.SleepHours, 6);
            //Debug.WriteLine(taxiDriver.SleepHours);
            //TaxiDriverExtensions.AddingHours(out int sleepHours, out int workHours, out int total);
            //Debug.WriteLine($"Sleep hours = {sleepHours}, work hours = {workHours}, in total = {total} hours");

            //Employee employee = new Employee();
            //employee.PrintGreeting("Olga");

            //Employee newEmployee = new Employee();
            //var candidate = new Employee() { Salary = 4000, FeedbackScore = 10 };
            //newEmployee.DoOffer(candidate);
            //FileOperationsCases fileOperationsCases = new FileOperationsCases();
            //HomeActivity myHomeActivity = new HomeActivity("Ironing", 2, "Saturday");
            //string serialized = JsonConvert.SerializeObject(myHomeActivity, Formatting.Indented);
            //Debug.WriteLine(serialized.DeserializeJson<HomeActivity>());
            //Debug.WriteLine($"{myHomeActivity.Name}, {myHomeActivity.Duration}, {myHomeActivity.WeekDay}");
            //fileOperationsCases.WritingJsonToFile(myHomeActivity);
            //fileOperationsCases.ReadingFromFile();


            //ArgumentsCases argumentsCases = new ArgumentsCases();
            //Debug.WriteLine(argumentsCases.CompareStringsConsiderCase("COCONUT", "coconut"));// false
            //Debug.WriteLine(argumentsCases.CompareStringsConsiderSpaces("Good morning!", "Goodmorning!"));// false
            //Debug.WriteLine(argumentsCases.CompareDecimalsWholeValue(2.1m, 2.2m));// false
            //Debug.WriteLine(argumentsCases.CompareStringsConsiderSpacesAndCase("Happy birthday", "happy birthday", ignoreSpace: false));// true
            //FileOperationsCases fileOperationsCases = new FileOperationsCases();
            //HomeActivity myHomeActivity = new HomeActivity("Ironing", 2, "Saturday");
            //string serialized = JsonConvert.SerializeObject(myHomeActivity, Formatting.Indented);
            //Debug.WriteLine(serialized);
            //Debug.WriteLine(serialized.DeserializeJson<HomeActivity>());
            //Debug.WriteLine($"{myHomeActivity.Name}, {myHomeActivity.Duration}, {myHomeActivity.WeekDay}");
            //fileOperationsCases.WritingJsonToFile(myHomeActivity);
            //fileOperationsCases.ReadingFromFile();

            //ActivityData weekDay = ActivityData.WeekDay;
            //int enumInt = weekDay.GetIntValueOfEnum();
            //Debug.WriteLine(enumInt);

            //DateTime date = DateTime.Now;
            //var culture = CultureInfo.CreateSpecificCulture("es-ES");
            //Debug.WriteLine($"{culture} Culture, {date.DateTimeToStringCultureWise(culture)}");

            //DateTime today = DateTime.Now;
            //Debug.WriteLine(today.DateTimeToStringWithFormatting(StringFormatting.DateWithDashes));

            //string example = "45ghjkk?//23c[45z6]}$#56yu";
            //var result = example.ExtractNumeric();
            //Debug.WriteLine(result);

            //string alphabeticRegex = @"[0-9\s]";
            //string exampleString = "He was born on the 3rd of December 1990";
            //Debug.WriteLine(exampleString.GetSubstringFromString(alphabeticRegex));

            //HomeActivity newHomeActivity = new HomeActivity("Cooking", 2, "Friday");
            //Debug.WriteLine(newHomeActivity.SerializeToJson(Formatting.Indented));

            //Collections collections = new Collections();
            //collections.PoliticianToJsonAndBack();
            //JsonCases jsonCases = new JsonCases();
            //jsonCases.AddJsonProperty();
            //jsonCases.AddRequiredProperties();
            //jsonCases.DefaultAndDisallowNullNotSpecified();
            //jsonCases.RequiredAlwaysNotSpecified();
            //jsonCases.DisallowNullIsNull();
            //jsonCases.DeserializeStringWhereIntExpected();

            //collections.ListCollectionMethods();
            //collections.LinkedListCollectionMethods();
            //collections.HashSetCollectionMethods();
            ////collections.HashMapCollectionMethods();
            //collections.IdentifyUniqueArrayElements();
            //collections.PetsListMethods();
            //collections.PoliticiansSortedListMethods();
            //ValidParentheses validParentheses = new ValidParentheses();
            //string input1 = "(3+5)*4/7+(7-3))";
            //Debug.WriteLine(validParentheses.Valid(input1));
            //object[] array = new object[5] { 1, 1.1111, "Sharad", 'c', 2.79769313486232E+3 };
            //validParentheses.ValidArray(array);


            //Dictionary<int, string> Flowers = new Dictionary<int, string>();// creating a new Dictionary
            //Flowers.Add(1, "Rose");// adding first element to Dictionary
            //Flowers.Add(2, "Camomile");// adding second element to Dictionary
            //Flowers.Add(3, "Poppy");// adding third element to Dictionary
            //Debug.WriteLine(MethodsSignatureCases.SearchByKeyFirstOption(3, Flowers));// searching value by key using First method
            //Debug.WriteLine(MethodsSignatureCases.SearchByKeySecondOption<Dictionary<int, string>, int, string>(Flowers, 3));// searching value by key using Second method
            //Debug.WriteLine(Flowers.SearchByKeySecondOption<Dictionary<int, string>, int, string>(3));

            //Flowers.Add(4, "Tulip");// adding fourth element to Dictionary
            //Flowers.Add(5, "Jasmine");// adding fifth element to Dictionary
            //Flowers.Remove(1);// deleting element with a specified key
            //Flowers.Remove(4);// deleting element with a specified key
            //MethodsSignatureCases.AddNewOrUpdateExisting(Flowers, 5, "Sunflower");// adding new element or replacing if specified key already exists
            //Flowers.AddNewOrUpdateExisting(5, "Sunflower");
            //MethodsSignatureCases.DeleteByKey<Dictionary<int, string>, int, string>(Flowers, 2);// deleting element with a specified key
            //Flowers.DeleteByKey<Dictionary<int, string>, int, string>(2);

            //var listToAdd = new List<KeyValuePair<int, string>>() // creating a list of key-value pairs
            //{
            //    new KeyValuePair<int, string>(6, "Daisy"),
            //    new KeyValuePair<int, string>(7, "Iris")
            //};
            //MethodsSignatureCases.AddRange(Flowers, listToAdd); // adding list of key-value pairs to Dictionary

            //foreach (KeyValuePair<int, string> pair in Flowers)
            //{
            //    Debug.WriteLine(pair.Key, pair.Value);
            //}

            //MethodsSignatureCases.AddRange(Flowers, new KeyValuePair<int, string>(8, "Orchid"), new KeyValuePair<int, string>(9, "Lily")); // adding several elements to Dictionary at once
            //foreach (KeyValuePair<int, string> pair in Flowers)
            //{
            //    Debug.WriteLine(pair.Key, pair.Value);
            //}

            // using checked keyword
            //checked
            //{
            //    int n = int.MaxValue;
            //    Debug.WriteLine(n + 10); // output: System.OverflowException
            //}

            // using unchecked keyword
            //unchecked
            //{
            //    int n = int.MaxValue;
            //    Debug.WriteLine(n + 10); // No Exception// output: -2147483639
            //}

            //FileOperationsAdvancedCases fileOperationsAdvancedCases = new FileOperationsAdvancedCases();
            //fileOperationsAdvancedCases.CreateFile(@"\FirstFile.txt");
            //fileOperationsAdvancedCases.WriteToFile();
            //fileOperationsAdvancedCases.ReadFile();
            //fileOperationsAdvancedCases.ViewFileInfo();
            //fileOperationsAdvancedCases.CreateFile(@"\SecondFile.txt");
            //fileOperationsAdvancedCases.CreateFile(@"\ThirdFile.txt");
            //fileOperationsAdvancedCases.CreateFile(@"\FourthFile.txt");
            //fileOperationsAdvancedCases.ListFiles();
            //fileOperationsAdvancedCases.CreateDirectory(@"Directory1");
            //fileOperationsAdvancedCases.CreateDirectory(@"Directory2");
            //fileOperationsAdvancedCases.CreateDirectory(@"Directory3");
            //fileOperationsAdvancedCases.ListDirectories();

            var add = WorkingDayHelper.Instance.AddWorkingDays(DateTime.Today, 3);
            Debug.WriteLine(add); // output: 12/9/2022 12:00:00 AM

            // 'Chain of Responsibility' pattern usage:
            Customer customer = new Customer()
            {
                Name = "Carl Vosper Mortimer",
                Age = 17
            };
            Request request = new Request() { Data = customer };
            var ageHandler = new AgeHandler();
            var nameHandler = new NameHandler();
            ageHandler.SetTheNextHandler(nameHandler);
            ageHandler.Process(request);
            foreach (string message in request.ValidationMessages)
            {
                Debug.WriteLine(message);
            }

            // 'Abstract Factory' pattern usage:
            HomeDevice homeDevice = null;
            HomeDevicesFactory homeDevicesFactory = null;
            homeDevicesFactory = HomeDevicesFactory.CreateHomeDevicesFactory("Kitchen");
            Debug.WriteLine("Home Devices Factory type : " + homeDevicesFactory.GetType().Name);
            homeDevice = homeDevicesFactory.GetDevice("Kettle");
            Debug.WriteLine("Device Type : " + homeDevice.GetType().Name);
            Debug.WriteLine(homeDevice.GetType().Name + " is " + homeDevice.feature());
            homeDevicesFactory = HomeDevicesFactory.CreateHomeDevicesFactory("Cleaning");
            Debug.WriteLine("Home Devices Factory type : " + homeDevicesFactory.GetType().Name);
            homeDevice = homeDevicesFactory.GetDevice("Hoover");
            Debug.WriteLine("Device Type : " + homeDevice.GetType().Name);
            Debug.WriteLine(homeDevice.GetType().Name + " is " + homeDevice.feature());

            // 'Factory Design' pattern usage:
            string coffeeMachineMake = "Barista T Smart";
            CoffeeMachine coffeeMachineDetails = null;

            if (coffeeMachineMake == "Nescafe Vertuo Plus")
            {
                coffeeMachineDetails = new Nestle();
            }
            else if (coffeeMachineMake == "The Scoop")
            {
                coffeeMachineDetails = new Hamilton();
            }
            else if (coffeeMachineMake == "Barista T Smart")
            {
                coffeeMachineDetails = new Melitta();
            }
            if (coffeeMachineDetails != null)
            {
                Debug.WriteLine("Coffee Machine make : " + coffeeMachineDetails.GetCoffeeMachineMake());
                Debug.WriteLine("Number of drinks available : " + coffeeMachineDetails.GetNumberOfDrinksAvailable());
                Debug.WriteLine("Main function : " + coffeeMachineDetails.GetMainFunction());
            }
            else
            {
                Debug.Write("Unknown coffee machine make");
            }

            // 'Facade Design' pattern usage:
            Purchase purchase = new Purchase();
            purchase.MakePurchase();
            







        }


    }
}
