using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            ConsoleKeyInfo key = Console.ReadKey();
            bool run = true;

            while (run)
            {
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.WriteLine(message.HelloMessage);
                }

                string exit = Console.ReadLine();

                if (exit.Equals("exit"))
                {
                    run = false;
                }
            }
        }
    }
}
