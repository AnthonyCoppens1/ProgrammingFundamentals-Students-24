using System;

namespace Week06ReportCard_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            int[,] reportCard = new int[students, tests];

            //adding the grades
            for (int i = 0; i < students; i++) //or i < reportCard.GetLength(0);
            {
                for (int j = 0; j < tests; j++) //or j < reportCard.GetLength(1);
                {
                    Console.Write($"Grade for test {j + 1} for student {i + 1}: ");
                    reportCard[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //printing out the grades
            for (int i = 0; i < students; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < tests;j++)
                {
                    Console.Write(reportCard[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            //average of every student
            
            for (int i = 0; i < students; i++)
            {
                int sum = 0;
                for (int j = 0; j < tests; j++)
                {
                    sum += reportCard[i, j];
                }
                Console.WriteLine($"Average for student {i + 1} is {sum / tests}");
            }


            //average of every test
            for (int i = 0; i < tests; i++)
            {
                int sum = 0;
                for (int j = 0; j < students; j++)
                {
                    sum += reportCard[j,i];
                }
                Console.WriteLine($"Average for test {i + 1} is {sum / students}");
            }
        }
    }
}
