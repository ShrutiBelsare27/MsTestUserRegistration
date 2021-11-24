using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAILPATTERN = "^[a-zA-Z-9]+([._+-]*[0-9A-Za-z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-z]{2,4})?$";
        public static string MOBILEPATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORDRULE = "^[a-zA-z](?=.*[A-Z]).(?=.*[0-9]).(?=.*?[#?!@$%^&*-]).{8,}$";
        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
        public bool validateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }
        public bool validateEmail(String email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }
        public bool validateMobileFormat(String mobileFormat)
        {
            return Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        }
        public bool validatePreDefinedPassword(String preDefinedPassword)
        {
            return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        }

        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidLastName = lastName => Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAILPATTERN);
        public Func<string, bool> isValidMobileNumber = mobileFormat => Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        public Func<string, bool> isValidPassword = preDefinedPassword => Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
    }
}