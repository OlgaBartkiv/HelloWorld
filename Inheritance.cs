using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class A
    {
        public string Name;
        public int Age;

        public A(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class B : A
    {
        //public B()
        //{
        //    Name = "unknown";
        //    Debug.WriteLine(Name);
        //}
        // cannot find parameterless constructor in class A, an error is shown

        public B(string name, int age) : base(name, age)
        {
            Debug.WriteLine("B(string name, int age)");
        }
    }

    public class Animal
    {
        public string Alias;
        public int Weight;
        public int Age;

        public Animal(string alias, int weight, int age)
        {
            Alias = alias;
            Weight = weight;
            Age = age;
        }

        public override string ToString()
        {
            return Alias + "," + Weight + "," + Age;
        }

        public void Eat(string food, int weight)
        {
            Debug.WriteLine($"Food: {food}, Weight: {weight}");
        }
        public void Drink(string liquid)
        {
            Debug.WriteLine($"Drinks: {liquid}");
        }
        public virtual void Sleep(int hours)
        {
            Debug.WriteLine($"Sleep hours: {hours}");
        }
        public void Poop()
        {
            Debug.WriteLine("Daily poop was made");
        }
        public void Sound(string sound)
        {
            Debug.WriteLine(sound);
        }
    }

    public class Dog : Animal
    {
        public Dog(string alias, int weight, int age) : base(alias, weight, age)
        {
            Debug.WriteLine("I am a dog :)");
        }

        public void Bark()
        {
            base.Sound("Woof");
        }

        public override void Sleep(int hours)
        {
            Random rnd = new Random();
            int sleepHours = rnd.Next(8,11);
            Debug.WriteLine(sleepHours);
        }

        public void Chew(string ownersClothItem)
        {
            Debug.WriteLine($"Chewing {ownersClothItem}");
        }
    }

    public class Cat : Animal
    {
        public Cat(string alias, int weight, int age) : base(alias, weight, age)
        {
            Debug.WriteLine("I am a cat :)");
        }

        public void Meow()
        {
            base.Sound("Meow");
        }

        public override void Sleep(int hours)
        {
            Random rnd = new Random();
            int sleepHours = rnd.Next(12, 19);
            Debug.WriteLine(sleepHours);
        }

        public void Scratch(string furnitureType)
        {
            Debug.WriteLine($"Scratching {furnitureType}");
        }
    }
}
