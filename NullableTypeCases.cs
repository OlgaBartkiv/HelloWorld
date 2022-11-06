using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class TaxiDriver
    {
        public int SleepHours { get; set; }


        public TaxiDriver() { }



        public int CompareAndStoreBiggerValue(int sleepHours, int? workHours)
        {
            if (Nullable.Compare<int>(sleepHours, workHours) < 0)
            {

                return workHours ?? sleepHours;
            }
            else
                return sleepHours;

        }

        public void AddingHours(out int sleepHours, out int workHours, out int total)
        {
            sleepHours = 9;
            workHours = 8;
            total = sleepHours + workHours;
        }
      
    }
}
