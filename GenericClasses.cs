using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Drink : IFood
    {

        public List<string> Ingredients { get; set; }
        
    }
    public class Soup : IFood
    {
        public List<string> Ingredients { get; set; }
        
    }
    public class MainCourse : IFood
    {
        public List<string> Ingredients { get; set; }
           
    }
    public class Dessert : IFood
    {
        public List<string> Ingredients { get; set; }
           
    }

    public interface IFood
    {
        public List<string> Ingredients { get; }
    }

    public class DairyFood<T> where T : IFood
    {
        private readonly List<string> dairyIngredients = new List<string> { "milk", "sour cream", "cheese", "cream" };
        public string DairyFree(T food)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, food.Ingredients.Count);

            while (IsDairyIngredient(food.Ingredients[num]))
            {
                num = rnd.Next(0, food.Ingredients.Count);
            }
            return food.Ingredients[num];
        }
        public bool IsDairyIngredient(string ingredient)
        {
            return dairyIngredients.Contains(ingredient);
        }
    }


    /// <summary>
    /// 'new' constraint implementation
    /// </summary>
    public class Student
    {
        public Student() { } // constructor with no parameters
    }

    public class Teacher
    {
        public Teacher(string course) { } // constructor with parameter
    }

    public class Lesson<T> where T : new() { }



    


}
