using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class CoffeeMachineFactory
    {
        public static CoffeeMachine GetCoffeeMachine(string coffeeMachineMake)
        {
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
            return coffeeMachineDetails;

        }
    }
}
