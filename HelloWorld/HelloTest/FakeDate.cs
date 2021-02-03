using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace HelloWorldTest
{
    public class FakeDate : IDate
    {
        private DateTime m_date;
        public DateTime Date { get => m_date; set => m_date = value; }

        public FakeDate(int hour, DayOfWeek day)
        {
            Date = new DateTime(1, 1, 1, hour, 1, 1);
            while (Date.DayOfWeek != day)
            {
                Date = Date.AddDays(1);
            }
        }
    }
}
