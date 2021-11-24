using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingRegex;
using UserRegistrationUsingRegex1;

namespace UserRegistrationTesting
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        public void GivenParameterizedTest_ToValidateMultipleEntries_ReturnEntryIsSucessful()
        {
            UserRegistration userRegistration = new UserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com");
            Assert.AreEqual(result, "Entry is successful");
        }
        [TestMethod]
        [DataRow("shruti")]
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
        [DataRow("belsare")]
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
        [DataRow("91 8149713160")]
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
        [TestMethod]
        [DataRow("Shruti")]
        public void GivenFirstName_Whenvalid_ThenShouldReturnTrueUsingLambda(string firstName)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateFirstName = userRegistrationRegex.isValidFirstName(firstName);
            Assert.AreEqual(true, validateFirstName);
        }
       
        [TestMethod]
        [DataRow("Belsare")]
        public void GivenLastName_WhenValid_ThenShouldReturnTrueUsingLambda(string lastName)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateLastName = userRegistrationRegex.isValidLastName(lastName);
            Assert.AreEqual(true, validateLastName);
        }
       
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        public void GivenEmail_WhenValid_ThenShouldReturnTrueUsingLambda(string email)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateEmail = userRegistrationRegex.isValidEmail(email);
            Assert.AreEqual(true, validateEmail);
        }
       
        [TestMethod]
        [DataRow("91 9733213160")]
        public void GivenMobileFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string mobileFormat)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateMobileFormat = userRegistrationRegex.isValidMobileNumber(mobileFormat);
            Assert.AreEqual(true, validateMobileFormat);
        }
   
        [TestMethod]
        [DataRow("Shruti@123")]
        public void GivenPasswordFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string preDefinedPassword)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validatePassword = userRegistrationRegex.isValidPassword(preDefinedPassword);
            Assert.AreEqual(true, validatePassword);
        }
    }
}
