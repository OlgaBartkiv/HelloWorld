using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    class BasicVariables
    {
        int intVariable;
        long longVariable;
        double doubleVariable;
        float floatVariable;
        string stringVariable;

        /// <summary>
        /// Compare unassigned values for int, long, float and double
        /// </summary>
        public void CompareUnassignedValues()
        {
            Console.WriteLine($"Compared Int and Long: {intVariable==longVariable}");
            Console.WriteLine($"Compared Long and Double: {longVariable == doubleVariable}");
            Console.WriteLine($"Compared Float and Int: {floatVariable == intVariable}");
        }

        /// <summary>
        /// Compare different values for int, long, float and double
        /// </summary>
        public void CompareDifferentAssignedValues()
        {
            intVariable = 50;
            longVariable = 1234567890123;
            doubleVariable = 123.45678;
            floatVariable = 456.45F;
            stringVariable = "50";

            Console.WriteLine($"Compared assigned different values for Int and Long: {intVariable == longVariable}");
            Console.WriteLine($"Compared assigned different values for Double and Long: {doubleVariable == longVariable}");
            Console.WriteLine($"Compared assigned different values for Float and Double: {floatVariable == doubleVariable}");
            Debug.WriteLine($"Compared assigned different values for String and Int: {stringVariable.Equals(intVariable)}");
        }

        /// <summary>
        /// Compare same values for int, long, float and double
        /// </summary>
        public void CompareSameAssignedValues()
        {
            intVariable = 50;
            longVariable = 50;
            doubleVariable = 50.0000;
            floatVariable = 50.00F;

            Console.WriteLine($"Compared assigned same values for Int and Long: {intVariable == longVariable}");
            Console.WriteLine($"Compared assigned same values for Double and Float: {doubleVariable == floatVariable}");
            Console.WriteLine($"Compared assigned same values for Long and Double: {longVariable == doubleVariable}");

        }

        /// <summary>
        /// Compare Float and Double with the same values
        /// </summary>
        public void CompareFloatAndDouble()
        {
            floatVariable = 0.5F;
            doubleVariable = 0.5;
            Console.WriteLine($"Compared '0.5' value for Float and Double: {floatVariable == doubleVariable}");

            floatVariable = 0.7F;
            doubleVariable = 0.7;
            Console.WriteLine($"Compared '0.7' value for Float and Double: {floatVariable == doubleVariable}");

            floatVariable = 1.0F;
            doubleVariable = 1.0;
            Console.WriteLine($"Compared '1.0' value for Float and Double: {floatVariable == doubleVariable}");

            floatVariable = 0.1F;
            doubleVariable = 0.1;
            Console.WriteLine($"Compared '0.1' value for Float and Double: {floatVariable == doubleVariable}");
        }

        /// <summary>
        /// Compare Float and Double arrays using Cycle
        /// </summary>
        public void CompareFloatAndDoubleUsingCycle()
        {
            float[] floatArray = { 0.5f, 0.7f, 1.0f, 0.1f };
            double[] doubleArray = { 0.5, 0.7, 1.0, 0.1 };

            for (int i=0; i<doubleArray.Length; i++)
            {
                Debug.WriteLine($"{doubleArray[i]} == {floatArray[i]} : {doubleArray[i] == floatArray[i]}");
            }

        }

        /// <summary>
        /// This method will always fail because of System.DivideByZeroException
        /// </summary>
        public void DivideValuesByZero()
        {
            intVariable = 20;
            longVariable = 20;
            doubleVariable = 20.0000;
            floatVariable = 20.00F;

            Console.WriteLine($"Divided Int by zero: {intVariable / 0}");
            Console.WriteLine($"Divided Long by zero: {longVariable / 0}");
            Console.WriteLine($"Divided Double by zero: {doubleVariable / 0}");
            Console.WriteLine($"Divided Float by zero: {floatVariable / 0}");
        }

        /// <summary>
        /// Divide value by int and assign the result to the variable
        /// </summary>
        public void DivideValuesByIntAndAssignResult()
        {
            intVariable = 22;
            longVariable = 22;
            doubleVariable = 22.0000;
            floatVariable = 22.00F;

            intVariable /= 3;
            Console.WriteLine($"Divided Int by '3' and assigned result: {intVariable}");

            longVariable /= 3;
            Console.WriteLine($"Divided Long by '3' and assigned result: {longVariable}");

            doubleVariable /= 3;
            Console.WriteLine($"Divided Double by '3' and assigned result: {doubleVariable}");

            floatVariable /= 3;
            Console.WriteLine($"Divided Float by '3' and assigned result: {floatVariable}");
        }

        /// <summary>
        /// Divide value by double, assign the result to the variable and make Round operation
        /// </summary>
        public void DivideValuesByDoubleAndMakeRound()
        {
            intVariable = 25;
            longVariable = 25;
            doubleVariable = 25.0000;
            floatVariable = 25.00F;

            double myDouble1 = intVariable;
            myDouble1 /= 3.0;
            Console.WriteLine($"Divided Int by '3' and assigned result: {Math.Round(myDouble1)}");

            double myDouble2 = longVariable;
            myDouble2 /= 3.0;
            Console.WriteLine($"Divided Long by '3' and assigned result: {Math.Round(myDouble2)}");

            doubleVariable /= 3.0;
            Console.WriteLine($"Divided Double by '3' and assigned result: {Math.Round(doubleVariable)}");

            double myDouble3 = floatVariable;
            myDouble3 /= 3.0;
            Console.WriteLine($"Divided Float by '3' and assigned result: {Math.Round(myDouble3)}");
        }




    }
}
