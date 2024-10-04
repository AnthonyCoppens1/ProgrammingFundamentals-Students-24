using System;

namespace _03CartesianQuadrant_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CARTESIAN QUADRANT
             * a quadrant with 4 parts --> q1, q2, q3 and q4
             * Provide a number for x and a number for y
             * Print out in whichever quadrant you are. */

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else //y < 0
                {
                    Console.WriteLine("Q4");
                }
            }
            else //x < 0
            {
                if (y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }


            //option 2
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("PERFECT MIDDLE");
            }





        }
    }
}
