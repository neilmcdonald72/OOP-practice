using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNamesGrades = new string[studentCount, studentCount];

            for (int j = 0; j < studentCount; j++)
            {
                for (int i = 0; i < studentCount; i++)
                {
                    Console.Write("Enter student name: ");
                    studentNamesGrades[j,0] = Console.ReadLine();
                    Console.Write("Enter student grade: ");


                }
            }
            for (int j = 0; j < studentCount; j++)
            {
                for (int i = 0; i < studentCount; i++)
                {
                    Console.Write("Name: {0} Grade: {1}", studentNamesGrades[i,j]);


                }
            }
        }
    }
}
