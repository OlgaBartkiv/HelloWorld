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
            Dog dog = new Dog("Chester", 15, 8);
            dog.Bark();
            dog.Sleep(default);
            dog.Chew("sock");
            Cat cat = new Cat("Musya", 5, 4);
            cat.Meow();
            cat.Sleep(default);
            cat.Scratch("sofa");





        }
    }
}
