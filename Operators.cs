using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Operators
    {
        
        public void MathOperations()
        {
            int a, b, c;
            a = 5; b = 2;
            c = a + b;
            b += 3;
            a -= 4;

            Debug.WriteLine($"a={a}, b={b}, c={c}");
        }

        public void RetrieveRandomItem()
        {
            object[] array = new object[6] { 1, 1.1111, "Sharad", null, 'c', 2.79769313486232E+3 };

            Stack<object> myStack = new Stack<object>(array);

            Random rnd = new Random();
            var shuffled = myStack.OrderBy(_ => rnd.Next());
            Debug.WriteLine(shuffled);






            

            //Debug.WriteLine(String.Join(", ", shuffled));

            //foreach (var item in shuffled)
            //{
            //    if ((item.ToString() == item!.ToString()))
            //    {
            //        Debug.WriteLine($"random item: {item}");
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

        }


    }
}
