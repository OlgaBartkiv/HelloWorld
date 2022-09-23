using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public enum PhoneTypes
        {
            Mobile,
            Landline,
            Fax
        }
        public User (string FirstName, string MiddleName, string LastName)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
        }


    }
}
