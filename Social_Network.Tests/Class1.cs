using NUnit.Framework;
using Social_Network.BLL.Exceptions;
using Social_Network.BLL.Models;
using Social_Network.BLL.Services;
using System;

namespace Social_Network.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
 
            UserService userService = new UserService();
            var userRegistrationData = new UserRegistrationData();

            userRegistrationData.FirstName = "Test";
            userRegistrationData.LastName = "Test";
            userRegistrationData.Email = "Test@test.com";
            userRegistrationData.Password = "12345678";
            Assert.DoesNotThrow(() => userService.Register(userRegistrationData));
            
        }

    }
}
