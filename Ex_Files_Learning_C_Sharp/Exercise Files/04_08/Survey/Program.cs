using System;
using System.ComponentModel.DataAnnotations;

namespace Survey
{
    class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Month { get; set; }

        public int Day { get; set; }

        public void Display()
            {
                Console.WriteLine("Your name is: {0}", Name);
                Console.WriteLine("Your age is: {0}", Age);
                Console.WriteLine("Your birth month is: {0}", Month);
                Console.WriteLine("Your birth day is the: {0}th", Day);

            if ((Month == 3 && Day >= 21) || (Month == 4 && Day <= 19 ))
            {
                Console.WriteLine("You are an aries");
            }
            if ((Month == 4 && Day >= 20) || (Month == 5 && Day <= 20 ))
            {
                Console.WriteLine("You are a taurus");
            }
            if ((Month == 5 && Day >= 21) || (Month == 6 && Day <= 20 ))
           {
                Console.WriteLine("You are a gemini");
            }
            if ((Month == 6 && Day >= 21) || (Month == 7 && Day <= 22 ))
            {
                Console.WriteLine("You are a cancer");
            }
            if ((Month == 7 && Day >= 23) || (Month == 8 && Day <= 22 ))
            {
                Console.WriteLine("You are a leo");
            }
            if ((Month == 8 && Day >= 23) || (Month == 9 && Day <= 22 ))
            {
                Console.WriteLine("You are a virgo");
            }
            if ((Month == 9 && Day >= 23) || (Month == 10 && Day <= 22 ))
            {
                Console.WriteLine("You are a libra");
            }
            if ((Month == 10 && Day >= 23) || (Month == 11 && Day <= 21 ))
            {
                Console.WriteLine("You are a scorpio");
            }
            if ((Month == 11 && Day >= 22) || (Month == 12 && Day <= 21 ))
            {
                Console.WriteLine("You are a sagittarius");
            }
            if ((Month == 12 && Day >= 22) || (Month == 1 && Day <= 19 ))
            {
                Console.WriteLine("You are a capricorn");
            }
            if ((Month == 1 && Day >= 20) || (Month == 2 && Day <= 18 ))
            {
                Console.WriteLine("You are an aquarius");
            }
            if ((Month == 2 && Day >= 19) || (Month == 3 && Day <= 20 ))
            {
                Console.WriteLine("You are a pisces");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            var data = new Data();

                while(true)
            {
                try
                {
                    Console.WriteLine("What is your name?");
                    data.Name = Console.ReadLine();

                    Console.WriteLine("What is your age?");
                    data.Age = int.Parse(Console.ReadLine());

                    Console.WriteLine("What month (number) were you born in?");
                    data.Month = int.Parse(Console.ReadLine());

                    Console.WriteLine("What day of the month were you born in?");
                    data.Day = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Incorrect data type, please try again");
                    continue;
                }

                break;
            }

            data.Display();
        }

        //static string TryAnswer()
        //{
        //    var question = Console.ReadLine();
        //    if (question == "")
        //    {
        //        Console.WriteLine("You didn't type anything, please try again:");
        //        return Console.ReadLine();
        //    }
        //    return question;
        //}
    }
}
