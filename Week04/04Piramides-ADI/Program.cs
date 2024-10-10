using System;

namespace _04Piramides_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //piramide 1
            // *
            // * *
            // * * *
            // * * * *
            // * * * * *

            Console.WriteLine("Piramide 1:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //piramide 2
            // * * * * *
            // * * * *
            // * * *
            // * *
            // *

            Console.WriteLine("Piramide 2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("test");


            //piramide 3
            //        *
            //      * *
            //    * * *
            //  * * * *
            //* * * * *

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

          //piramide 4
          //* * * * *
          //  * * * *
          //    * * *
          //      * *
          //        *

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("test");


        }


    }
}
