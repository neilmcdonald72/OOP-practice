using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat
{
    class Program
    {
        static void Main(string[] args)
        {   //Part 1
            //Run as client vs server
            Console.WriteLine("Listening for messages");
            //User input mode. one hitting "I" key
            var userKey = Console.ReadKey();
            //Display incoming message

            //Allow for input

            //Let user quit
            Console.WriteLine($"You typed {userKey.Key}");
            Console.Beep();

        }
    }
}
