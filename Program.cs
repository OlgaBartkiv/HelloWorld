using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //struct can be initialized without using 'new' operator
            CarStruct myCar;
            myCar.make = "BMW";
            myCar.mileage = 29000;
            myCar.Print();
            //struct initialized using 'new', in this case one of the parameters (e.g. mileage) can be skipped, a default value will be assigned for it
            CarStruct anotherCar = new CarStruct()
            {
                make = "Audi"
            };
            anotherCar.Print();

            //creating new object and calling method of class using class object
            CarClass dreamCar = new CarClass();
            dreamCar.CarDetails("Range Rover", 1000);
        }
    }
}
