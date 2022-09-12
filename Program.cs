using System;
using System.Diagnostics;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            B b = new B("Bob", 14);
            Animal cow = new Animal("Masha", 700, 5);
            Debug.WriteLine(cow);
            cow.Eat("grass", 700);
            cow.Drink("water");
            cow.Sleep(10);
            cow.Poop();
            cow.Sound("Mooooooo");
            cow.Sound(SoundTypes.Mooooooo);
            int mySound = (int)SoundTypes.CluckCluck; // int value casted to enum
            Debug.WriteLine(mySound);
            Debug.WriteLine($"Integral value of {SoundTypes.CluckCluck} is {(int)mySound}");
            Dog dog = new Dog("Chester", 15, 8);
            dog.Bark();
            dog.Sleep(default);
            dog.Chew("sock");
            dog.Chew(OwnerClothItems.Hat);
            int myClothes = (int)OwnerClothItems.Pants; // int value casted to enum
            Debug.WriteLine(myClothes);
            Debug.WriteLine($"Integral value of {OwnerClothItems.Pants} is {(int)myClothes}");
            Cat cat = new Cat("Musya", 5, 4);
            cat.Meow();
            cat.Sleep(default);
            cat.Scratch("sofa");
            cat.Scratch(FurnitureItems.Doors);
            int myFurniture = (int)FurnitureItems.Table; // int value casted to enum
            Debug.WriteLine(myFurniture);
            Debug.WriteLine($"Integral value of {FurnitureItems.Table} is {(int)myFurniture}");

        }
    }
}
