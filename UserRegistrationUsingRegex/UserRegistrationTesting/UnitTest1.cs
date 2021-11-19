using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingRegex;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("Shruti")]
        public void GivenMessageReturnEntrySucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("12ds")]
        public void GivenMessageUnSucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }



        [TestMethod]
        [DataRow("Belsare")]
        public void GivenMessageReturnEntrySucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("abc")]
        public void GivenMessageReturnEntryUnSucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }

        [TestMethod]
        [DataRow("shrutibelsare@gmail.com")]
        public void GivenMessageReturnEntrySucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }

        [TestMethod]
        [DataRow("Asdd$32")]
        public void GivenMessageReturnEntryUnSucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }

        [TestMethod]
        [DataRow("91 8549859758")]
        public void GivenMessageReturnEntrySucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is successful");
        }

        [TestMethod]
        [DataRow("985996869")]
        public void GivenMessageReturnEntryUnSucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Abc345")]
        public void GivenMessageReturnEntrySucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }

        [TestMethod]
        [DataRow("839697d")]
        public void GivenMessageReturnEntryUnSucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenParameterizedTest_WhenValidateMultipleEntries_ReturnEntryIsSucessful(string emails)
        {
            UserRegistration userRegistration = new UserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail(emails);
            Assert.AreEqual(result, "Entry is successful");
        }
        
        /*// Givens the parameterized test when validate multiple entries return entry is Unsuccessful.
      
        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        public void GivenParameterizedTest_WhenInvalidValidateMultipleEntries_ReturnEntryIsUnSucessful(string emails)
        {
            UserRegistration userRegistration = new UserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail(emails);
            Assert.AreEqual(result, "Entry is not successful");
        }*/

        [TestMethod]
        [DataRow("Shruti")]
        public void GivenFirstName_WhenInvalid_ThenShouldThrowInvalidFirstNameException(string firstName)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkFirstName(firstName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid First Name Format", exception.Message);
            }
        }
       
        [TestMethod]
        [DataRow("Belsare")]
        public void GivenLastName_WhenInvalid_ThenShouldThrowInvalidLastNameException(string lastName)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkLastName(lastName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Last Name Format", exception.Message);
            }
        }
       
        [TestMethod]
        [DataRow("abc@.com.my")]
        public void GivenEmail_WhenInvalid_ThenShouldThrowInvalidEmailException(string email)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkEmail(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Email Format", exception.Message);
            }
        }

        [TestMethod]
        [DataRow("91 8569870987")]
        public void GivenMobileFormat_WhenInvalid_ThenShouldThrowInvalidMobileFormatException(string mobileFormat)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkMobile(mobileFormat);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Mobile Number Format", exception.Message);
            }
        }

        [TestMethod]
        [DataRow("shruti@123")]
        public void GivenPasswordFormat_WhenInvalid_ThenShouldThrowInvalidPasswordFormatException(string preDefinedPassword)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkPassword(preDefinedPassword);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Password Format", exception.Message);
            }
        }
    
       
       
        
    }
}
