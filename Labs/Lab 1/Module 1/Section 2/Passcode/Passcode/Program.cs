using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            if (code == "secret")
            {
                Console.WriteLine("Authenticated");
                Console.WriteLine("Change the passcode");
                code = Console.ReadLine();
                Console.WriteLine("Your new password is {0}", code);


            }
            else if (code != "secret")
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}

//Here is a simpler option without the use of if statements.


//    class Program
//{
//    static void Main(string[] args)
//    {


//        string code = null;
//        while (code != "secret")
//        {
//            Console.WriteLine("Not Authenticated");
//            Console.WriteLine("What is the pass code?");
//            code = Console.ReadLine();
//        }

//        Console.WriteLine("Authenticated");
//        Console.WriteLine("Change the passcode");
//        code = Console.ReadLine();
//        Console.WriteLine("Your new password is {0}", code);
//    }
//}
