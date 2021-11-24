using System;
using UserRegistrationUsingRegex1;

namespace UserRegistrationUsingRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the user registration problem");
            Console.WriteLine("Enter the first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the mobile pattern = ");
            string mobilePattern = Console.ReadLine();
            Console.WriteLine("Enter the password = ");
            string preDefinedPassword = Console.ReadLine();
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            Console.WriteLine(userRegistrationRegex.validateFirstName(firstName));
            Console.WriteLine(userRegistrationRegex.validateLastName(lastName));
            Console.WriteLine(userRegistrationRegex.validateEmail(email));
            Console.WriteLine(userRegistrationRegex.validateMobileFormat(mobilePattern));
            Console.WriteLine(userRegistrationRegex.validatePreDefinedPassword(preDefinedPassword));
            Console.WriteLine("Email sample validator");
            EmailSamples emailSamples = new EmailSamples();
            emailSamples.validateEmails();

        }
    }
}