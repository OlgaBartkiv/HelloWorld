using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public interface CoffeeMachine
    {
        string GetCoffeeMachineMake();
        int GetNumberOfDrinksAvailable();
        string GetMainFunction();
    }

    class Nestle : CoffeeMachine
    {
        public string GetCoffeeMachineMake()
        {
            return "Nescafe Vertuo Plus";
        }
        public int GetNumberOfDrinksAvailable()
        {
            return 25;
        }
        public string GetMainFunction()
        {
            return "grinds coffee beans";
        }
    }

    class Hamilton : CoffeeMachine
    {
        public string GetCoffeeMachineMake()
        {
            return "The Scoop";
        }
        public int GetNumberOfDrinksAvailable()
        {
            return 10;
        }
        public string GetMainFunction()
        {
            return "brews coffee";
        }
    }

    class Melitta : CoffeeMachine
    {
        public string GetCoffeeMachineMake()
        {
            return "Barista T Smart";
        }
        public int GetNumberOfDrinksAvailable()
        {
            return 15;
        }
        public string GetMainFunction()
        {
            return "foams milk";
        }
    }
}
