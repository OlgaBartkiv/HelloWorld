using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Operators operators = new Operators();
            ////operators.MathOperations();
            ////operators.MathOperationsForString();
            NullValidation nullValidation = new NullValidation();
            ////nullValidation.RetrieveRandomItem();
            ////nullValidation.RetrieveItemUsingCycle();
            ////nullValidation.AddNotNullItemsToCollection();
            nullValidation.AddNotNullItemsToCollectionVersionTwo();

            //User myUser = new User("Carl", "Vosper", "Mortimer");
            //myUser.PhoneNumbers = new List<string> { };
            //myUser.PhoneNumbers.Add("+380444567890");
            //myUser.PhoneNumbers.Add("+380224567834");
            //myUser.PhoneNumbers.Add("+380672345567");
            //myUser.PhoneNumbers.Add("+380633344567");
            //myUser.PhoneNumbers.Add("-3803245678909");
            //myUser.PhoneNumbers.Add("+3803245678909");
            //myUser.PhoneNumbers.Add("+3805645678");
            //myUser.PhoneNumbers.Add("+3805645677");
            //var results = myUser.SearchPhoneByType(PhoneType.Fax);
            //foreach (var result in results)
            //{
            //    Debug.WriteLine(result);
            //}

            //User myUser2 = null; // created 'null' user
            //Debug.WriteLine(myUser.VerifyMandatoryData(myUser2)); // method returns 'false'

            //User myUser3 = new User(); // creating user without LastName
            //myUser3.FirstName = "John";
            //myUser3.MiddleName = "Paul";
            //myUser3.PhoneNumbers = new List<string> { };
            //myUser3.PhoneNumbers.Add("+380444567890");
            //myUser3.PhoneNumbers.Add("+380633344567");
            //Debug.WriteLine(myUser3.VerifyMandatoryData(myUser3)); // method returns 'false' because LastName is mandatory

            //User myUser4 = new User(); // creating user without MiddleName
            //myUser4.FirstName = "John";
            //myUser4.LastName = "Newman";
            //myUser4.PhoneNumbers = new List<string> { };
            //myUser4.PhoneNumbers.Add("+380444567890");
            //myUser4.PhoneNumbers.Add("+380633344567");
            //Debug.WriteLine(myUser4.VerifyMandatoryData(myUser4)); // method returns 'true' because MiddleName is not mandatory

            //User myUser5 = new User(); // creating user with only Landline and Fax numbers provided
            //myUser5.FirstName = "John";
            //myUser5.LastName = "Newman";
            //myUser5.PhoneNumbers = new List<string> { };
            //myUser5.PhoneNumbers.Add("+380444567890");
            //myUser5.PhoneNumbers.Add("+3805645677");
            //Debug.WriteLine(myUser5.VerifyMandatoryData(myUser5)); // method returns 'false' because Mobile number is mandatory

            //User myUser6 = new User(); // creating user with no phones provided
            //myUser6.FirstName = "John";
            //myUser6.LastName = "Newman";
            //myUser6.PhoneNumbers = new List<string> { };
            //Debug.WriteLine(myUser6.VerifyMandatoryData(myUser6)); // method returns 'false' because Mobile number is mandatory



        }
    }
}
