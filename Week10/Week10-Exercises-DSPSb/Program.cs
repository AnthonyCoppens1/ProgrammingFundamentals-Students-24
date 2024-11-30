using System;

namespace Week10_Exercises_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1: MultiplicationTable
             * read in a number and print out the multiplication table of the number
             * input: 12
             * output:
             * 12 * 0 = 0
             * 12 * 1 = 12
             * ...
             * 12 * 10 = 120
             * 
             * 
             * 2: Squared and Cubed
             * read in a number, print out the squared number and the cubed number
             * input: 5
             * output:
             * 25
             * 125
             * 
             * SquaredAndCubed(number);
             * 
             * 3: Sum
             * read in a string and count up the values of the string (use arrays)
             * input: 3 6 12 9 3 4 8 2
             * Output:
             * 47
             * 
             */

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int number = Convert.ToInt32(Console.ReadLine());
                    MultiplicationTable(number);
                    break;
                case "2":
                    int N = Convert.ToInt32(Console.ReadLine());
                    SquaredAndCubed(N);
                    break;
                case "3":
                    string[] array = Console.ReadLine().Split();
                    Console.WriteLine(Sum(array));
                    break;
                default:
                    Console.WriteLine("Crazy input!");
                    break;
            }
        }
        static int Sum(string[] array)
        {
            int sum = 0;
            foreach (var item in Array.ConvertAll(array, Convert.ToInt32))
            {
                sum += item;
            }
            return sum;

        }


        static int Squared(int number)
        {
            return number * number;
        }

        static void SquaredAndCubed(int number)
        {
            int cube = Squared(number) * number;
            Console.WriteLine($"squared: {Squared(number)} and cubed: {cube}");
        }

        static void MultiplicationTable(int number)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

    }
}
