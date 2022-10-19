using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    /// <summary>
    /// Interface
    /// </summary>
    interface ICoffeeMaker
    {
        void BrewCoffee();
        void GrindCoffee();
        void FoamMilk();
        // interface methods (do not have body)
    }

    /// <summary>
    /// AeroPress class implements ICoffeeMaker interface
    /// </summary>
    class AeroPress : ICoffeeMaker
    {
        public void BrewCoffee()
        {
            Debug.WriteLine("The coffee is brewed by AeroPress");
        }

        void ICoffeeMaker.GrindCoffee() // explicit interface implementation // this method is not visible to the outside of class
        {
            Debug.WriteLine("Not used by AeroPress");
        }

        void ICoffeeMaker.FoamMilk() // explicit interface implementation // this method is not visible to the outside of class
        {
            Debug.WriteLine("Not used by AeroPress too");
        }
    }

    /// <summary>
    /// DelonghiMagnifica class implements ICoffeeMaker interface
    /// </summary>
    class DelonghiMagnifica : ICoffeeMaker
    {
        public void BrewCoffee()
        {
            Debug.WriteLine("The coffee is brewed by DelonghiMagnifica");
        }

        public void FoamMilk()
        {
            Debug.WriteLine("The milk is foamed by DelonghiMagnifica");
        }

        void ICoffeeMaker.GrindCoffee() // explicit interface implementation // this method is not visible to the outside of class
        {
            Debug.WriteLine("Not used by DelonghiMagnifica"); 
        }
    }

    /// <summary>
    /// BrevilleBarista class implements ICoffeeMaker interface
    /// </summary>
    class BrevilleBarista : ICoffeeMaker
    {
        public void BrewCoffee()
        {
            Debug.WriteLine("The coffee is brewed by BrevilleBarista");
        }

        public void GrindCoffee()
        {
            Debug.WriteLine("The coffee is grinded by BrevilleBarista");
        }

        public void FoamMilk()
        {
            Debug.WriteLine("The milk is foamed by BrevilleBarista");
        }
    }
}
