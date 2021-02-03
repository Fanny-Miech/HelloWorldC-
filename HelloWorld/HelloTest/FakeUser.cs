using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace HelloWorldTest
{
    internal class FakeUser : IUser
    {
        public string Name { get; set; }
        public FakeUser(string name = "HELLO")
        {
            Name = name;
        }
    }
}
