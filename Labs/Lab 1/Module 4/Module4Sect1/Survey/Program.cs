using System;

namespace Survey
{
    class Program
    {
        enum monthCategory
        {
            January = 0,
            Febuary = 1,
            March = 2,
            April = 3,
            May = 4,
            June = 5,
            July = 6,
            August = 7,
            September = 8,
            October = 9,
            November = 10,
            December = 11

        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            Console.WriteLine("January : 0\nFebuary: 1\n March: 2\n April: 3\n may: 4\n June: 5\n July: 6\n August: 7\n September: 8\n October: 9\n November: 10\n December: 11\n");
            var month = int.Parse(TryAnswer());
            monthCategory monthName = (monthCategory) month;

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", monthName);

            switch (month)
            {
                case 2:
                    Console.WriteLine("You are Aries");
                    break;
                case 3:
                    Console.WriteLine("You are Taurus");
                    break;
                case 4:
                    Console.WriteLine("You are Gemini");
                    break;
                default:
                    Console.WriteLine("Incorrect month number");
                    break;
            }

            //if (month == "march")
            //{
            //    Console.WriteLine("you are an Aries.");
            //}
            //else if (month == "april")
            //{
            //    Console.WriteLine("you are a Taurus.");
            //}
            //else if (month == "may")
            //{
            //    Console.WriteLine("you are a Gemini.");
            //}
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}
