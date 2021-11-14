using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MsTestUserRegistration
{
   public  class UserDetails
    {
        public String firstName;
        public String lastName;
        public String email;
        public Match FirstName(string firstname, string pattern)
        {
            this.firstName = firstname;
            return Regex.Match(firstName, pattern);

        }
        public Match LastName(string lastname, string pattern)
        {
            this.lastName = lastname;
            
            return Regex.Match(lastName, pattern);

        }
        public Match Email(string email, string pattern)
        {
            this.email = email;


            return Regex.Match(email, pattern);

        }
    }
}
