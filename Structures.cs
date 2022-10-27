using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    // defining structure
    public struct CarStruct
    {
        // declaring data types
        public string make;
        public int mileage;

        // method of structure
        public void Print()
        {
            Debug.WriteLine($"Make: {make}, mileage: {mileage}");
        }
    }

    // class declaration
    public class CarClass
    {
        // data members of class
        public string make;
        public int mileage;

        // method of class
        public void CarDetails(string make, int mileage)
        {
            this.make = make;
            this.mileage = mileage;
            Debug.WriteLine($"Make: {make}, mileage: {mileage}");
        }
    }
}
