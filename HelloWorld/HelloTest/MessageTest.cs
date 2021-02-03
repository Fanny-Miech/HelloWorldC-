using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void TestGetHelloReturnsCorrectMessageForMondayMorning()
        {
            //Arrange
            string expectedHello = "Good morning ";
            IDate fakeDate = new FakeDate(9, DayOfWeek.Monday);
            string userName = "toto";
            IUser fakeUser = new FakeUser(userName);
            Message message = new Message(fakeUser, fakeDate);
            //Act
            string actualHello = message.GetHello();
            //Assert
            Assert.AreEqual(expectedHello, actualHello);
        }

        [TestMethod]
        public void TestGetHelloReturnsCorrectMessageForTuesdayAfternoon()
        {
            //Arrange
            string expectedHello = "Good afternoon ";
            IDate fakeDate = new FakeDate(13, DayOfWeek.Tuesday);
            string userName = "toto";
            IUser fakeUser = new FakeUser(userName);
            Message message = new Message(fakeUser, fakeDate);
            //Act
            string actualHello = message.GetHello();
            //Assert
            Assert.AreEqual(expectedHello, actualHello);
        }

        [TestMethod]
        public void TestGetHelloReturnsCorrectMessageForFridayNight()
        {
            //Arrange
            string expectedHello = "Good night ";
            IDate fakeDate = new FakeDate(18, DayOfWeek.Friday);
            string userName = "toto";
            IUser fakeUser = new FakeUser(userName);
            Message message = new Message(fakeUser, fakeDate);
            //Act
            string actualHello = message.GetHello();
            //Assert
            Assert.AreEqual(expectedHello, actualHello);
        }

        [TestMethod]
        public void TestGetHelloReturnsCorrectMessageForWeekEnd()
        {
            //Arrange
            string expectedHello = "Good week-end ";
            IDate fakeDate = new FakeDate(5, DayOfWeek.Saturday);
            string userName = "toto";
            IUser fakeUser = new FakeUser(userName);
            Message message = new Message(fakeUser, fakeDate);
            //Act
            string actualHello = message.GetHello();
            //Assert
            Assert.AreEqual(expectedHello, actualHello);
        }

        [TestMethod]
        public void TestGetHelloMessageReturnsCorrectMessageForMondayMorning()
        {
            //Arrange
            IDate fakeDate = new FakeDate(9, DayOfWeek.Monday);
            string userName = "toto";
            IUser fakeUser = new FakeUser(userName);
            Message message = new Message(fakeUser, fakeDate);
            string expectedMessage = "Good morning " + userName + "\r\nIt's " + DayOfWeek.Monday + ", 9 o'clock";
            //Act
            string actualMessage = message.HelloMessage;
            //Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

    }
}
