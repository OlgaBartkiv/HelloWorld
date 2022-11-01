using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    public enum Achievement
    {
        [Description("Reorganized something to make it work better")]
        Reorganized,
        [Description("Identified a problem and solved it")]
        Identified,
        [Description("Come up with a new idea that improves things")]
        NewIdea,
        [Description("Developed new procedures")]
        Developed,
        [Description("Worked on special projects")]
        Special,
        [Description("Received awards")]
        Awards,
        [Description("Been complimented by manager or co-workers")]
        Complimented
    }
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public Dictionary <int, Enum?> AchievementsByMonth { get; set; }

        public bool IsAwarded;

        public bool CanBeAwarded(int month)
        {
            var achievement = AchievementsByMonth[month];

            if (achievement != null && !IsAwarded )
            {
                return true;
            }
            return false;
        }

    }
    
}
