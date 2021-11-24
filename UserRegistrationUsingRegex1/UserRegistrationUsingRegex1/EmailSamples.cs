using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex1
{
    class EmailSamples
    {
        public void validateEmails()
        {
            //valid emails
            var emails = new ArrayList();
            emails.Add("abc@yahoo.com");
            emails.Add("abc-100@yahoo.com");
            emails.Add("abc.100@yahoo.com");
            emails.Add("abc111@abc.com");
            emails.Add("abc - 100@abc.net");
            emails.Add("abc.100@abc.com.au");
            emails.Add("abc@1.com");
            emails.Add("abc@gmail.com.com");
            emails.Add("abc+100@gmail.com");
            //Invalid emails
            emails.Add("abc");
            emails.Add("abc@.com.my");
            emails.Add("abc123@gmail.a");
            emails.Add("abc123@.com");
            emails.Add("abc123@.com.com");
            emails.Add(".abc@abc.com");
            emails.Add("abc()*@gmail.com");
            emails.Add("abc@%*.com");
            emails.Add("abc..2002@gmail.com");
            emails.Add("abc.@gmail.com");
            emails.Add("abc@abc@gmail.com");
            String regex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
            Regex emailPattern = new Regex(regex);
            foreach (string samples in emails)
            {
                Console.WriteLine(samples + "=" + emailPattern.IsMatch(samples));
            }
        }
    }
}