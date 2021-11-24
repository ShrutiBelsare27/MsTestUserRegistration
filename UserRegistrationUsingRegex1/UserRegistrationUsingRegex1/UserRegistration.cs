using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    public class UserRegistration
    {
        private string message;
        public UserRegistration()
        {
        }
        public UserRegistration(string message)
        {
            this.message = message;
        }
        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public string checkMultipleEntriesOfEmail(string email1, string email2, string email3, string email4)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool emailForEntry1 = userRegistrationRegex.validateEmail(email1);
            bool emailForEntry2 = userRegistrationRegex.validateEmail(email2);
            bool emailForEntry3 = userRegistrationRegex.validateEmail(email3);
            bool emailForEntry4 = userRegistrationRegex.validateEmail(email4);
            if (emailForEntry1 && emailForEntry2 && emailForEntry3 && emailForEntry4)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
    }
}