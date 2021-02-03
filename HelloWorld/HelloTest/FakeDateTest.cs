using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class FakeDateTest
    {
        [TestMethod]
        public void TestFakeDateReturnsGivenDayOfWeek()
        {
            //Arrange
            DayOfWeek expectedDay = DayOfWeek.Tuesday;
            IDate fakeDate = new FakeDate(9, expectedDay);
            //Act
            DayOfWeek actualDay = fakeDate.Date.DayOfWeek;
            //Assert
            Assert.AreEqual(expectedDay, actualDay);
        }

        [TestMethod]
        public void TestFakeDateReturnsGivenHour()
        {
            //Arrange
            int expectedHour = 10;
            IDate fakeDate = new FakeDate(expectedHour, DayOfWeek.Tuesday);
            //Act
            int actualHour = fakeDate.Date.Hour;
            //Assert
            Assert.AreEqual(expectedHour, actualHour);
        }
    }
}
