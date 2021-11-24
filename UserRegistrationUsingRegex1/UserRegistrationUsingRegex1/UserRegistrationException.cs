using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex1
{
    public class UserRegistrationException : Exception
    {

        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;

        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
    
}
