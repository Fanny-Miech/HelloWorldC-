using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        //Attributes
        private string m_userName;
        private int m_hour1;
        private int m_hour2;
        private int m_hour3;
        private IDate m_date;

        //Public read-only property to get the HelloMessage
        public string HelloMessage
        {
            get => GetHello() + m_userName
                    + "\r\nIt's " + m_date.Date.DayOfWeek + ", "
                    + m_date.Date.Hour + " o'clock";
        }

        //Constructors
        public Message() : this(new RealUser(), new RealDate()) { }

        //constructor with default values
        public Message(int hour1, int hour2, int hour3)
            : this(new RealUser(), new RealDate(), hour1, hour2, hour3)
        {
        }

        //constructor used for tests
        public Message(IUser user, IDate date, int hour1 = 9, int hour2 = 13, int hour3 = 18)
        {
            m_date = date;
            m_hour1 = hour1;
            m_hour2 = hour2;
            m_hour3 = hour3;
            m_userName = user.Name;
        }

        //method to get the value of m_hello
        public string GetHello()
        {
            DateTime currentDate = m_date.Date;
            if (currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
            {
                return "Good week-end ";
            }
            else
            {
                if (currentDate.Hour >= m_hour1 && currentDate.Hour < m_hour2)
                {
                    return "Good morning ";
                }
                else if (currentDate.Hour >= m_hour2 && currentDate.Hour < m_hour3)
                {
                    return "Good afternoon ";
                }
                else return "Good night ";
            }
        }
    }
}
