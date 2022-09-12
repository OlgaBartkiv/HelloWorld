using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AeroPress aeroPress = new AeroPress();
            aeroPress.BrewCoffee();
            //aeroPress.GrindCoffee();// gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)aeroPress).GrindCoffee(); // works as expected
            //aeroPress.FoamMilk(); // gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)aeroPress).FoamMilk(); // works as expected
            DelonghiMagnifica delonghiMagnifica = new DelonghiMagnifica();
            delonghiMagnifica.BrewCoffee();
            delonghiMagnifica.FoamMilk();
            //delonghiMagnifica.GrindCoffee(); // gives error since the method is not visible from AeroPress class
            ((ICoffeeMaker)delonghiMagnifica).GrindCoffee(); // works as expected
            BrevilleBarista brevilleBarista = new BrevilleBarista();
            brevilleBarista.BrewCoffee();
            brevilleBarista.GrindCoffee();
            brevilleBarista.FoamMilk();

        }
    }
}
