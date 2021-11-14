using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegistration;

namespace MsTestUser
{
    [TestClass]
    public class UnitTest1
    {
        string firstName = "^[A-Z]{1}[a-z]{2,10}$";
        string lastName = "^[A-Z]{1}[a-z]{2,10}$";
        string email = "^[a-zA-Z0-9]{3,}[@]{1}[A-Za-z0-9]+[.]{1}[a-zA-Z]{2,4}$";
        string phoneNumber = "^(\\d{1,2}?)[- .][6-9]{1}[0-9]{9}$";
        UserDetails us = new UserDetails();
        [TestMethod]
        public void FirstName()
        {
            var result = us.FirstName("Shruti", firstName);
            Assert.AreEqual(true, result.Success);
        }
        //UC2 for last name
        [TestMethod]
        public void LastName()
        {
            var result = us.LastName("Belsare", lastName);
            Assert.AreEqual(true, result.Success);

        }
    //UC3 for email
    [TestMethod]
    public void Email1()
    {
        var result = us.Email("shruti123@gmail.com", email);
        Assert.AreEqual(true, result.Success);

    }
        //UC4 for phonenumber
        [TestMethod]
        public void Test4()
        {
            var result = us.PhoneNumber("91 9878786877", phoneNumber);
            Assert.AreEqual(true, result.Success);

        }
    }
}
