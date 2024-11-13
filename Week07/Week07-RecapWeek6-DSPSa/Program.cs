using System;

namespace Week07_RecapWeek6_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* make a matrix report card of all the tests that a teacher has given
             * input the number of students and number of tests
             * result: matrix, average per student, average per test*/

            Console.Write("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            int[,] reportCard = new int[students, tests];

            for (int i = 0; i < students; i++) //or reportCard.GetLength(0)
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write($"Grade for test {j+1} of student {i+1}: ");
                    reportCard[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //printing the results in a matrix
            for (int i = 0; i < students; i++)
            {
                Console.Write($"Student {i + 1}:\t");
                for (int j = 0; j < tests; j++)
                {
                    Console.Write(reportCard[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //calculate the average per student
            int sum = 0;

            for (int i = 0; i < students; i++)
            {
                Console.Write($"Average of student {i + 1}:\t");
                for (int j = 0; j < tests; j++)
                {
                    sum += reportCard[i, j];
                }
                Console.Write(sum / tests);
                Console.WriteLine();
                sum = 0;
            }

            //average of every test result
            sum = 0;

            for (int i = 0; i < tests; i++)
            {
                Console.Write($"Average of test {i + 1}:\t");
                for (int j = 0; j < students; j++)
                {
                    sum += reportCard[j,i];
                }
                Console.Write(sum / students);
                Console.WriteLine();
                sum = 0;
            }
        }
    }
}
