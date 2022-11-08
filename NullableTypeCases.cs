using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class TaxiDriver
    {
        public int SleepHours;


        public TaxiDriver() { }
      
    }

    public static class TaxiDriverExtensions
    {
        public static void CompareAndStoreBiggerValue(ref int sleepHours, int? workHours)
        {
            if (Nullable.Compare<int>(sleepHours, workHours) < 0)
            {
                sleepHours = workHours ?? sleepHours;
            }



            if(workHours == null)
            {
                return;
            }
            sleepHours = (workHours > sleepHours) ? (int)workHours : sleepHours;


        }

        public static void AddingHours(out int sleepHours, out int workHours, out int total)
        {
            sleepHours = 9;
            workHours = 8;
            total = sleepHours + workHours;
        }

    }
}
