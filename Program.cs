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
        }
    }
}
