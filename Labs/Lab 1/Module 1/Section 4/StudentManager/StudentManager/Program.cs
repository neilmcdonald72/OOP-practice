using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNamesGrades = new string[studentCount, 2];

            for (int j = 0; j < studentCount; j++)
            {
                Console.Write("Enter student #{0} name followed by their grade :", j + 1);
                for (int i = 0; i < studentCount; i++)
                {
                    
                    studentNamesGrades[j, i] = Console.ReadLine();
                    
                    
                }
            }
            for (int j = 0; j < studentCount; j++)
            {
                Console.Write("Student #{0} info: \n", j+1);
                for (int i = 0; i < studentCount; i++)
                {
                    Console.Write(studentNamesGrades[j, i]);
                    Console.WriteLine();                   
                    


                }
            }
        }
    }
}
