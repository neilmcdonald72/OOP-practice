using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleChat
{
    class Program
    {
        static void Main(string[] args)
        {   //----------Part 1-------------------
            //Run as client vs server
            //Console.WriteLine("Listening for messages");
            //User input mode. one hitting "I" key
            //var userKey = Console.ReadKey();
            //Display incoming message

            //Allow for input

            //Let user quit
            //Console.WriteLine($"You typed {userKey.Key}");
            //Console.Beep();

            //----------------Part 2---------------------

            //Run as client vs server
            while (true)
            {
                Console.WriteLine("Listening for messages");

                //User input mode. once hitting "I" key

                ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement

                //Allow for input

                //Let user quit
                Console.WriteLine($"You typed {userKey.Key}");


            }
            Console.WriteLine("Listening for messages");
            //User input mode. one hitting "I" key
            var userKey = Console.ReadKey();

            //----------------Part 3---------------------

            //Run as client vs server
            while (true)
            {
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    //User input mode. once hitting "I" key

                    ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement

                    //Allow for input

                    //Let user quit
                    Console.WriteLine($"You typed {userKey.Key}");
                    Thread.Sleep(500);
                }


                //---------------------------Part 4--------------------------------

                //Run as client vs server
                while (true)
                {
                    Console.WriteLine("Listening for messages");
                    if (Console.KeyAvailable)
                    {
                        //User input mode. once hitting "I" key

                        ConsoleKeyInfo userKey = Console.ReadKey(); //Blocking statement
                        if (userKey.Key == ConsoleKey.I)
                        {
                            Console.WriteLine("I is PRESSED >>");
                            Console.ReadLine();
                            //break;
                        }
                        else
                        {
                            Console.WriteLine($"You typed {userKey.Key}");
                            Thread.Sleep(500);
                        }
                        //Allow for input

                        //Let user quit
                        Console.WriteLine($"You typed {userKey.Key}");
                        Thread.Sleep(500);
                    }


                }
            }
    }
}

