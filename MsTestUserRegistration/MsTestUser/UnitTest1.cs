using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegistration;

namespace MsTestUser
{
    [TestClass]
    public class UnitTest1
    {
        string firstName = "^[A-Z]{1}[a-z]{2,10}$";
        string lastName = "^[A-Z]{1}[a-z]{2,10}$";
        UserDetails us = new UserDetails();
        [TestMethod]
        public void TestMethod1()
        {
            var result = us.FirstName("Shruti", firstName);
            Assert.AreEqual(true, result.Success);
        }
        //UC2 for last name
        [TestMethod]
        public void Test2()
        {
            var result = us.LastName("Belsare", lastName);
            Assert.AreEqual(true, result.Success);

        }
    }
}