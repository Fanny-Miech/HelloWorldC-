using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class FakeUserTest
    {
        [TestMethod]
        public void TestFakeUserReturnsCorrectUserName()
        {
            //Arrange
            string expectedUserName = "toto";
            IUser fakeUser = new FakeUser(expectedUserName);
            //Act
            string actualUserName = fakeUser.Name;
            //Assert
            Assert.AreEqual(expectedUserName, actualUserName);
        }

        [TestMethod]
        public void TestFakeUserReturnsHello()
        {
            //Arrange
            string expectedUserName = "HELLO";
            IUser fakeUser = new FakeUser();
            //Act
            string actualUserName = fakeUser.Name;
            //Assert
            Assert.AreEqual(expectedUserName, actualUserName);
        }
    }
}
