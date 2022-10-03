using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public enum PhoneType
    {
        Mobile,
        Landline,
        Fax
    }
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public User (string firstName, string middleName, string lastName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "The FirstName value is missing");
            MiddleName = middleName ?? "";
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "The LastName value is missing");
        }
        public User() { }

        public List<string> SearchPhoneByType(PhoneType phoneType)
        {
            List<string> results = new List<string>();

            Dictionary<PhoneType, List<string>> phoneTypes = new Dictionary<PhoneType, List<string>>
            {
                { PhoneType.Mobile, new List<string>{"+38067", "+38063"} },
                { PhoneType.Landline, new List<string>{"+38032", "+38044"} }
            };

            if (phoneType == PhoneType.Fax)
            {
                foreach (var phoneNumber in PhoneNumbers)
                {
                    if (phoneNumber.Length == 11)
                    {
                        results.Add(phoneNumber);
                    }
                }
            }
            else
            {
                var patterns = phoneTypes[phoneType];
                foreach (var phoneNumber in PhoneNumbers)
                {
                    foreach (var pattern in patterns)
                    {
                        if (phoneNumber.StartsWith(pattern, StringComparison.OrdinalIgnoreCase))
                            results.Add(phoneNumber);
                    }
                }
            }
            /*return results ?? new List<string> { PhoneNumbers[0] }; */// this will not work, as in case of no match we will get a new empty List (line 31)
            /*return results.Any() ? results : new List<string> { PhoneNumbers[0] }; */// this works for SearchPhoneByType method, but doesn't make sense when using VerifyMandatoryData method, as it will always return at least one result
            return results; // using this for VerifyMandatoryData method
        }

        public bool VerifyMandatoryData(User user)
        {
            if (user is null || user.FirstName is null || user.LastName is null || !user.SearchPhoneByType(PhoneType.Mobile).Any())
            {
                return false;
            }
            return true;
        }
        
    }
}
