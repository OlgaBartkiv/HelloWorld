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
        public string DairyFree(T food)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 3);
            return food.Ingredients[num];
        }
    }

}
