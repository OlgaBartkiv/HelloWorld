using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BasicVariables basicVariables = new BasicVariables();
            //basicVariables.CompareUnassignedValues();
            //basicVariables.CompareDifferentAssignedValues();
            //basicVariables.CompareSameAssignedValues();
            //basicVariables.CompareFloatAndDouble();
            basicVariables.CompareFloatAndDoubleUsingCycle();
            //basicVariables.DivideValuesByZero();
            //basicVariables.DivideValuesByIntAndAssignResult();
            //basicVariables.DivideValuesByDoubleAndMakeRound();

        }
    }
}
