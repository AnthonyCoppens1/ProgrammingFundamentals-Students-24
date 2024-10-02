using System;

namespace _03IfStatement_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 50) 
            {
                Console.WriteLine("The number is smaller than 50");
            }
            else if (number > 50)
            {
                Console.WriteLine("The number is bigger than 50");
            }
            else
            {
                Console.WriteLine("The number is 50.");
            }

            //always need as else if we want to open a second if

            if (number < 50)
            {
                Console.WriteLine("Number is smaller than 50");
            }
            //don't forget to add else in front of if, otherwise treated as new if-statement
            if (number == 50) 
            {
                Console.WriteLine("Number is exactly 50");
            }
            else
            {
                Console.WriteLine("Number is greater than 50.");
            }
            Console.WriteLine();
            Console.WriteLine("Option2");

            //option 2 if in else
            if (number < 50)
            {
                Console.WriteLine("smaller than 50");
            }
            else
            {
                if (number == 50)
                {
                    Console.WriteLine("equal to 50");
                }
                else
                {
                    Console.WriteLine("greater than 50");
                }
            }

            //option3: combining if's
            if (number != 50)
            {
                if (number < 50)
                {
                    Console.WriteLine("small");
                }
                else
                {
                    Console.WriteLine("big");
                }
            }
            else
            {
                Console.WriteLine("EXACT");
            }


            //combining checks
            //check if number is (not) equal to 50

            //option 1
            if (number == 50)
            {
                Console.WriteLine("number is equal to 50");
            }
            else
            {
                Console.WriteLine("number is NOT equal to 50");
            }


            //option2
            if (number < 50 || number > 50) //|| means or, one of both cases needs to be true to execute
            {
                Console.WriteLine("number is not equal to 50");
            }
            else
            {
                Console.WriteLine("number is equal to 50");
            }


            //option 3
            if (number != 50)
            {
                Console.WriteLine("not equal to 50");
            }
            else
            {
                Console.WriteLine("equal to 50");
            }


            //option 4
            if (!(number == 50))
            {
                Console.WriteLine("number is not equal to 50");
            }
            else
            {
                Console.WriteLine("number is exactly 50");
            }


            //option 5
            if (number == 50 && !(number != 50))
            {
                Console.WriteLine("number is equal to 50");
            }
            else
            {
                Console.WriteLine("number is NOT 50");
            }


            //option 6
            bool condition = number != 50;
            
            if (condition) // if condition == True
            {
                Console.WriteLine("number is not equal to 50");
            }
            else
            {
                Console.WriteLine("number is equal to 50");
            }

            //option 7
            if (!condition)
            {
                Console.WriteLine("number is equal to 50");
            }
            else
            {
                Console.WriteLine("number is NOT equal to 50");
            }


        }
    }
}
