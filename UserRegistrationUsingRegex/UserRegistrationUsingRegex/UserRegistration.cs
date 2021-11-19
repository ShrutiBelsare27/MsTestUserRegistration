using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    public class UserRegistration
    {
        private string message;
        UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
        
        public UserRegistration()
        {
        }
        
        public UserRegistration(string message)
        {
            this.message = message;
        }
        
        public string checkForFirstName()
        {
            if (message.Contains("Shruti"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
  
        public string checkForLastName()
        {
            if (message.Contains("Belsare"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        
        public string checkForEmail()
        {
            if (message.Contains("shrutibelsare@gmail.com"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        
        public string checkForMobile()
        {
            if (message.Contains("91 8549859758"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        
        public string checkForPassword()
        {
            if (message.Contains("Abc345"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public string checkMultipleEntriesOfEmail(string emails)
        {
            bool emailForEntry1 = userRegistrationRegex.validateEmail(emails);
            if (emailForEntry1 == true)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public void checkFirstName(string firstName)
        {
            if (userRegistrationRegex.validateFirstName(firstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name Format");
            }
        }
        
        public void checkLastName(string lastName)
        {
            if (userRegistrationRegex.validateLastName(lastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name Format");
            }
        }
       
        public void checkEmail(string email)
        {
            if (userRegistrationRegex.validateEmail(email))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email Format");
            }
        }
      
        public void checkMobile(string mobileFormat)
        {
            if (userRegistrationRegex.validateMobileFormat(mobileFormat))
            {
                Console.WriteLine("mobile format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number Format");
            }
        }
        
        public void checkPassword(string preDefinedPassword)
        {
            if (userRegistrationRegex.validatePreDefinedPassword(preDefinedPassword))
            {
                Console.WriteLine("password format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password Format");
            }
        }
    }
}
