using System;
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
            string result1 = dairyDrink.DairyFree(drink);
            Debug.WriteLine(result1);

            DairyFood<Soup> dairySoup = new DairyFood<Soup>();
            string result2 = dairySoup.DairyFree(soup);
            Debug.WriteLine(result2);

            DairyFood<MainCourse> dairyMainCourse = new DairyFood<MainCourse>();
            string result3 = dairyMainCourse.DairyFree(mainCourse);
            Debug.WriteLine(result3);

            DairyFood<Dessert> dairyDessert = new DairyFood<Dessert>();
            string result4 = dairyDessert.DairyFree(dessert);
            Debug.WriteLine(result4);

            /// 'new' constraint implementation
            Lesson<Student> studentLesson = new Lesson<Student>(); // No error, because Student has parameterless constructor
            /*Lesson<Teacher> teacherLesson = new Lesson<Teacher>();*/ // Error, because Teacher has constructor with parameter
        }
    }
}
