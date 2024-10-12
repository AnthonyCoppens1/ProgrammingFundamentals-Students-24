using System;

namespace _04Pyramids_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pyramid 1
            //*
            //* *
            //* * *
            //* * * *
            //* * * * *


            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPyramid 1");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //Pyramid 2
            //* * * * *
            //* * * *
            //* * *
            //* *
            //*
            Console.WriteLine("\nPyramid 2");
            for (int i = 0; i < x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //Pyramid 3
            //        *
            //      * *
            //    * * *
            //  * * * *
            //* * * * *

            Console.WriteLine("\nPyramid 3");
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pyramid 4
            //* * * * *
            //  * * * *
            //    * * *
            //      * *
            //        *

            Console.WriteLine("\nPyramid 4");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = x; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
