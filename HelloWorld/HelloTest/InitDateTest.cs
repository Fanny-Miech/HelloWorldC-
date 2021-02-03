using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class InitDateTest
    {
        [TestMethod]
        public void TestInitDateReturnsCurrentDayOfWeek()
        {
            //Arrange
            IDate date = new RealDate();
            //Act
            DayOfWeek actualDay = date.Date.DayOfWeek;
            //Assert
            Assert.AreEqual(actualDay, DateTime.Now.DayOfWeek);
        }

        [TestMethod]
        public void TestInitDateReturnsCurrentHour()
        {
            //Arrange
            IDate date = new RealDate();
            //Act
            int actualHour = date.Date.Hour;
            //Assert
            Assert.AreEqual(actualHour, DateTime.Now.Hour);
        }
    }
}
