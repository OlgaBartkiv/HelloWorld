using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

    public enum Title
    {
        [Description("Mr")]
        Mr,
        [Description("Mrs")]
        Mrs,
        [Description("Miss")]
        Miss
    }

    public enum EmployeeLevel
    {
        Junior = 1000,
        Middle = 2000,
        Senior = 3000
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public Dictionary <int, Enum?> AchievementsByMonth { get; set; }

        public bool IsAwarded;

        public int? Salary;

        public EmployeeLevel? Level;

        public int FeedbackScore;

        public bool CanBeAwarded(int month)
        {
            var achievement = AchievementsByMonth[month];

            if (achievement != null && !IsAwarded )
            {
                return true;
            }
            return false;
        }

        public void PrintGreeting(string firstName, string lastName = "", Title? title = null)
        {
            if (lastName != null && title.HasValue)
            {
                Debug.WriteLine($"Hello, {title.Value} {firstName} {lastName}!");
            }
            else if (lastName != null)
            {
                Debug.WriteLine($"Hello, {firstName} {lastName}!");
            }
            else if (title.HasValue == false)
            {
                Debug.WriteLine($"Hello, {firstName}!");
            }


            Debug.WriteLine($"Hello, {(title.HasValue? $"{title.Value} ": "")}{(firstName == null ? "": $"{firstName} ")}{(lastName == null ? "" : $"{lastName} ")}!");
        }

        public void DoOffer(Employee employee)
        {
            if (employee.Level.HasValue == true && employee.Salary.HasValue == true)
            {
                Debug.WriteLine($"The offer was made for {employee.Level.Value} level with the salary = {employee.Salary}"); 
            }
            else if (employee.Level.HasValue == true && employee.Salary.HasValue == false)
            {
                Debug.WriteLine($"The offer was made for {employee.Level.Value} level with the salary = {(int)employee.Level.Value}");
            }
            else if (employee.Level.HasValue == false && employee.Salary.HasValue == true)
            {
                if (employee.Salary > (int)EmployeeLevel.Senior)
                {
                    employee.Level = EmployeeLevel.Senior;
                    Debug.WriteLine($"The offer was made for {employee.Level.Value} level with the salary = {employee.Salary}");
                }
                else if (employee.Salary < (int)EmployeeLevel.Senior && employee.Salary > (int)EmployeeLevel.Junior)
                {
                    employee.Level = EmployeeLevel.Middle;
                    Debug.WriteLine($"The offer was made for {employee.Level.Value} level with the salary = {employee.Salary}");
                }
                else if (employee.Salary < (int)EmployeeLevel.Junior)
                {
                    employee.Level = EmployeeLevel.Junior;
                    Debug.WriteLine($"The offer was made for {employee.Level.Value} level with the salary = {employee.Salary}");
                }
            }
                    

        }


    }
    
}
