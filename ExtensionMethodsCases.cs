using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public enum StringFormatting
    {
        [Description("")]
        None,
        [Description("HHmmss")] // 000000
        TimeWithSecondsNoSeparator,
        [Description("yyyy-MM-dd HH:mm:ss.fff")] // 2000-01-01 00:00:00.000
        DateWithDashesTimeWithColonsAndThreeSecondsFraction,
        [Description("yyyy-MM-dd")] // 2000-01-01
        DateWithDashes,
        [Description("yyyyMMddHHmmss")] // 20000101000000
        DateThenTimeWithSecondsNoSeparator,
        [Description("yyyyMMddHHmmssfffffff")] // 200001010000000000000
        DateThenTimeWithSevenSecondsFractionNoSeparator,
        [Description("HHmmssf")] // 0000000
        TimeWithOneSecondsFractionNoSeparator,
        [Description("dd/MM/yyyy")] // 01/01/2000
        DateWithSlashesDayFirst,
        [Description("dd/MM/yy")] // 01/01/00
        DateWithSlashesDayFirstYearShort,
        [Description("MM/dd/yyyy")] // 01/01/2000
        DateWithSlashesMonthFirst,
        [Description("MMMM")] // January
        MonthFullString,
        [Description("MM")] // 01
        MonthTwoNumeric,
        [Description("d MMMM yyyy")] // 1 January 2000
        DateWithFullStringMonth,
        [Description("MM/dd/yyyy HH:mm:ss")] // 01/01/2000 00:00:00
        DateWithSlashesThenTimeWithDots,
        [Description("yyyyMMddHHmmffff")] // 2000010100000000
        DateThenTimeWithFourSecondsFractionNoSeparator
    }

    public static class ExtensionMethodsCases
    {
        /// <summary>
        /// Extension method to get Int value of an Enum
        /// </summary>
        /// <param name="theEnum"></param>
        /// <returns></returns>
        public static int GetIntValueOfEnum(this Enum theEnum)
        {
            int result = Convert.ToInt32(theEnum);
            return result;
        }

        public static T ToEnum<T>(this int theInt) where T: Enum
        {
            if (typeof(T).IsEnumDefined(theInt))
            {
                return (T)(object)theInt;
            }
            return default;
        }

        /// <summary>
        /// Extension method to convert DateTime to String culture wise
        /// </summary>
        /// <param name="theDateTime"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string DateTimeToStringCultureWise(this DateTime theDateTime, CultureInfo culture)
        {
            return theDateTime.ToString("g", culture);
        }


        /// <summary>
        /// Extension method to convert DateTime to String with specific formatting
        /// </summary>
        /// <param name = "this" ></ param >
        /// < returns ></ returns >
        public static string DateTimeToStringWithFormatting(this DateTime theDateTime, StringFormatting stringFormatting)
        {
            return theDateTime.ToString(stringFormatting.Text());
        }

        /// <summary>
        /// Extension method to return the Description of an enum value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="titleCase"></param>
        /// <returns></returns>
        public static string Text(this Enum element, bool titleCase = false)
        {
            Type type = element.GetType();

            MemberInfo[] memberInfo = type.GetMember(element.ToString());

            if (memberInfo.Length > 0)
            {
                object[] attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes.Length > 0)
                {
                    return titleCase
                        ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((DescriptionAttribute)attributes[0]).Description
                            .ToLower())
                        : ((DescriptionAttribute)attributes[0]).Description;
                }
            }

            return element.ToString();
        }


        /// <summary>
        /// Extension method to extract the numeric values in a String
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static object ExtractNumeric(this string theString)
        {
            return theString.Concat("g".Where(char.IsNumber));
            
        }

        /// <summary>
        /// Extension method to get a Substring of a String using regular expression
        /// </summary>
        /// <param name="theString"></param>
        /// <returns></returns>
        public static string GetSubstringFromString(this string theString, string regexPattern)
        {
            Regex regex = new Regex(regexPattern);
            return regex.Replace(theString, "");
        }
    }

}
