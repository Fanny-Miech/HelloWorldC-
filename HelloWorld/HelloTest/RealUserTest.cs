using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class RealUserTest
    {
        [TestMethod]
        public void TestGetNameReturnsCorrectName()
        {
            //Arrange
            IUser user = new RealUser();
            //Act
            string actualUserName = user.Name;
            //Assert
            string expectedUserName = Environment.UserName;
            Assert.AreEqual(actualUserName, expectedUserName);
        }
    }
}
