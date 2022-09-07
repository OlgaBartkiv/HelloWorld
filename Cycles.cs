using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    class Cycles
    {
        public void ForLoop()
        {
            for (int a=0; a<10; a++)
            {
                Console.WriteLine($"For loop iteration number: {a+1}");
            }
        }

        public void ForLoopReverse()
        {
            int count = 1;
            for (int d=10; d>0; d--)
            {
                Debug.WriteLine($"For reverse loop iteration number: {count++}");
            }
        }

        public void WhileLoop()
        {
            int b=0;
            while (b<10)
            {
                Console.WriteLine($"While loop iteration number: {b+1}");
                b++;
            }
        }

        public void DoWhileLoop()
        {
            int c = 0;
            do
            {
                Console.WriteLine($"DoWhile loop iteration number: {c+1}");
                c++;
            }
            while (c < 10);
        }

        /// <summary>
        /// Recursive method of getting factorial number with exit condition
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FactorialWithExit(int n)
        {
            if (n == 0) // exit condition
                return 1;
            else
                return n * FactorialWithExit(n - 1);
        }

        /// <summary>
        /// Recursive method of getting factorial number with no exit condition - Stack Overflow Exception is thrown
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FactorialNoExit(int n)
        {
            return n * FactorialNoExit(n - 1);
        }

        /// <summary>
        /// Condition repeats indefinitely
        /// </summary>
        public void InfiniteLoopFor()
        {
            for(; ; )
            {
                Console.WriteLine("I love C#");
            }
        }

        public void PrintingArrayUsingForeach()
        {
            char[] myArray = { 'O', 'l', 'g', 'a' };
            foreach(char x in myArray)
            {
                Console.WriteLine(x);
            }
        }

        public int ReverseNumber(int number)
        {
            int reverse = 0, remaining;
            while (number!=0)
            {
                remaining = number % 10;
                reverse = reverse * 10 + remaining;
                number /= 10;
            }
            return reverse;
        }

        public void CheckIfPalindrome(int myNumber)
        {
            int myReverse = ReverseNumber(myNumber); // calling ReverseNumber method 
            
            if (myNumber == myReverse)
                Console.WriteLine($"This is a palindrome: {myNumber}");
            else
                Console.WriteLine($"This is not a palindrome: {myNumber}");
        }



    }
}
