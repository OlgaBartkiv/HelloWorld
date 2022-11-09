using HelloWorld.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld.Services
{
    public class EmployeeService
    {
        public LoggerWrapper log;

        public EmployeeService()
        {
            log = new LoggerWrapper(log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }

        public void Goat(int month, List<Employee> listOfEmployees)
        {
            if (month <= 12)
            {
                var shuffledEmployees = ShuffleList(listOfEmployees);
                foreach (Employee employee in shuffledEmployees)
                {
                    if (employee.CanBeAwarded(month))
                    {
                        GiveAward(ref employee.IsAwarded);
                        log.Info($"Employee {employee.Position} {employee.FirstName} {employee.LastName} is awarded in {month} month");
                        break;
                    }
                }
            }
            else
                return;
        }

        public void GiveAward(ref bool isAwarded)
        {
            isAwarded = true;
        }

        public List<Employee> ShuffleList(List<Employee> list)
        {
            var listCopy = new List<Employee>(list);
            var random = new Random();
            var newShuffledList = new List<Employee>();
            var listcCount = listCopy.Count;
            for (int i = 0; i < listcCount; i++)
            {
                var randomElementInList = random.Next(0, listCopy.Count);
                newShuffledList.Add(listCopy[randomElementInList]);
                listCopy.Remove(listCopy[randomElementInList]);
            }
            return newShuffledList;
        }
    }
}
