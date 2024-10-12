using System;

namespace _04FOR_LOOPS_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR LOOPS
            //make a table of multiples of a number by 1, 2 ...
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //IDIOT VERSION
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");
            Console.WriteLine($"{number} * 5 = {number * 5}");


            //BETTER VERSION --> for-loop
            Console.WriteLine("\nFOR LOOP i = 0, i <= 10");
            for (int i = 0; i <= 10; i++) //i = i + 1
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }



            Console.WriteLine("\nFOR LOOP i = 1, i <= 10");
            for (int i = 1; i <= 10; i++) //i = i + 1
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 0, i <= 10, stepsize 2");
            for (int i = 0; i <= 10; i+=2) //i = i + 2 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.WriteLine("\nFOR LOOP i = 1, i <= 10, stepsize 2");
            for (int i = 1; i <= 10; i += 2) //i = i + 2 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 1, i <= 10, stepsize multiply by 2");
            for (int i = 1; i <= 10; i *= 2) //i = i * 2 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            /*BEWARE OF INFINITE LOOP: 0 * 2 = 0, i never reaches the end of the condition
             * 
             * Console.WriteLine("\nFOR LOOP i = 0, i <= 10, stepsize multiply by 2");
            for (int i = 0; i <= 10; i *= 2) //i = i * 2 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }*/


            Console.WriteLine("\nFOR LOOP i = 10, i >= 1");
            for (int i = 10; i >= 1; i--) //i = i - 1 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            //BEWARE of infinite loop, starts at 10, 11, 12, never reaching 1
            /*Console.WriteLine("\nFOR LOOP i = 10, i >= 1");
            for (int i = 10; i >= 1; i++) 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }*/


            //sequence 3 6 9 12 15 ... 100
            Console.WriteLine("\nversion 1: sequence 3 6 9 ... 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nversion 2: sequence 3 6 9 ... 100");
            for (int i = 3; i <= 100; i+=3)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("\nFind numbers that are divisible by 3 5 and 7 between given start and end");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            //nesting for-loops --> loop in a loop
            Console.Write("\n\nEnter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTable of values of j");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTable of *");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTable of the value of i");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            //*
            //* *
            //* * *
            //* * * *
            Console.WriteLine("\nGive me the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPyramid");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }




        }
    }
}
