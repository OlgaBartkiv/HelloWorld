using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ConditionalMethods
    {
        public void CompareBooleanVariables()
        {
            bool a = true;
            bool b = true;
            bool c = false;
            bool d = false;

            Console.WriteLine($"Comparing a and b: {a == b}");
            Console.WriteLine($"Comparing b and c: {b == c}");
            Console.WriteLine($"Comparing c and d: {c == d}");
            Console.WriteLine($"Comparing d and a: {d == a}");
        }

        public void CompareNumericVariables()
        {
            int intVariable = 50;
            long longVariable = 1234567890;
            double doubleVariable = 123.456789;
            float floatVariable = 456.45F;

            Console.WriteLine($"Comparing Float and Double: {floatVariable < doubleVariable}");
            Console.WriteLine($"Comparing Int and Long: {intVariable <= longVariable}");
            Console.WriteLine($"Comparing Long and Double: {longVariable != doubleVariable}");
            Console.WriteLine($"Comparing Int and Float: {intVariable == floatVariable}");
            //Console.WriteLine($"Comparing Long and Float: {longVariable === floatVariable}"); // === does not exist in c#, because c# is srictly typed
            Console.WriteLine($"Comparing Double and Int: {doubleVariable >= intVariable }");
            Console.WriteLine($"Comparing Long and Double: {longVariable > doubleVariable}");
        }

        public void CompareStringsUsingTernaryOperator()
        {
            string a = "car";
            string b = "bus";

            string result = (a == b) ? "Equal" : "Not equal";
            Console.WriteLine(result);
        }

        public void CompareOperandsUsingLogicalAND()
        {
            bool a = true;
            bool b = false;

            bool result = a & b;
            Console.WriteLine(result); // both operands are evaluated even if the left one is 'false'
        }

        public void CompareOperandsUsingConditionalLogicalAND()
        {
            bool x = false;
            bool y = true;

            bool result = x && y;
            Console.WriteLine(result); // if left operand is 'false' then right one is not evaluated
        }

        public void CompareOperandsUsingLogicalOR()
        {
            bool a = true;
            bool b = false;

            bool result = a | b;
            Console.WriteLine(result); // both operands are evaluated even if the left one is 'true'
        }

        public void CompareOperandsUsingConditionalLogicalOR()
        {
            bool x = true;
            bool y = false;

            bool result = x || y;
            Console.WriteLine(result); // if left operand is 'true' then right one is not evaluated
        }

        public void ComparingUsingEqualityOperatorAndEqualsMethod()
        {
            string a = "autumnFall";
            string b = new string("autumnFall");

            Console.WriteLine($"Using Equality Operator: {a == b}"); // compares the reference identity
            Console.WriteLine($"Using Equals Method: {a.Equals(b)}"); // compares content of the string
        }

        public void UsingBitwiseOperators()
        {
            int a = 50; //binary is 00110010
            int b = 15; //binary is 00001111

            int result1 = a & b;
            Console.WriteLine(result1);//00000010 whicn is 2

            int result2 = a | b;
            Console.WriteLine(result2);//00111111 which is 63

            int result3 = a ^ b;
            Console.WriteLine(result3);//00111101 which is 61

            int result4 = a << 1;
            Console.WriteLine(result4);//01100100 which is 100

            int result5 = a >> 1;
            Console.WriteLine(result5);//00011001 which is 25
        }

        public void DefineAge()
        {
            int age = 18;

            switch(age)
            {
                case 10:
                    Console.WriteLine("My age is 10");
                    break;
                case 18:
                    Console.WriteLine("My age is 18");
                    break;
                case 25:
                    Console.WriteLine("My age is 25");
                    break;
                case 30:
                    Console.WriteLine("My age is 30");
                    break;
            }  
        }

    }
}
