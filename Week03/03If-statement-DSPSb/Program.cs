using System;

namespace _03If_statement_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 50)
            {
                Console.WriteLine("Number is smaller than 50");
            }
            else if (number == 50)
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is bigger than 50");
            }


            if (number == 50)
            {
                Console.WriteLine("number == 50");
            }
            else
            {
                Console.WriteLine("number is different from 50");
            }



            //need an else before a second if
            //if my number is smaller than 50, it'll print Number SMALL and Number GREATER
            //Solve by adding else if instead of second if.
            if (number < 50)
            {
                Console.WriteLine("Number SMALL");
            }
            if (number == 50)
            {
                Console.WriteLine("Number 50");
            }
            else
            {
                Console.WriteLine("Number GREATER");
            }


            int dice = Convert.ToInt32(Console.ReadLine());
            //rolling the dice --> possible number: 1-6
            //if you do all separate if's it will keep checking all of them regardless of number
            //if you syntax it correctly, it will run the first condition that's true and then ignore the rest
            if (dice == 1)
            {
                Console.WriteLine("number 1");
            }
            else if (dice == 2)
            {
                Console.WriteLine("number 2");
            }
            else if (dice == 3)
            {
                Console.WriteLine("number 3");
            }
            else if (dice == 4)
            {
                Console.WriteLine("number 4");
            }
            else if (dice == 5)
            {
                Console.WriteLine("number 5");
            }
            else if (dice == 6)
            {
                Console.WriteLine("number 6");
            }
            else
            {
                Console.WriteLine("weirdest dice alive.");
            }


            //different options of how you can check if a number is smaller, equal or greater than 50
            //option 2

            if (number < 50)
            {
                Console.WriteLine("smaller than 50");
            }
            else //can be bigger or equal to 50
            {
                if (number == 50)
                {
                    Console.WriteLine("equal to 50");
                }
                else //bigger than 50
                {
                    Console.WriteLine("bigger than 50");
                }
            }


            //option 3
            if (number != 50) //is it different from 50?
            {
                if (number < 50)
                {
                    Console.WriteLine("Number small");
                }
                else //must be greater than 50 to execute this
                {
                    Console.WriteLine("Number big");
                }
            }
            else
            {
                Console.WriteLine("exactly 50");
            }


            //combining checks 
            //check if a number is (not) equal to 50
            //base option -- 1
            if (number == 50)
            {
                Console.WriteLine("number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to 50");
            }


            //option 2
            if (number < 50 || number > 50)
            {
                Console.WriteLine("number is NOT equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }


            //option 3
            if (number != 50)
            {
                Console.WriteLine("Number is NOT equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }


            //option 4
            if (!(number == 50))
            {
                Console.WriteLine("Number is NOT equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }


            //option 5
            if (!(number < 50) && !(number > 50))
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to 50");
            }


            //option 6 
            number = 50;
            bool condition = number == 50;

            if (condition)
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to 50");
            }


            //option 7
            if (!condition)
            {
                Console.WriteLine("Number is NOT equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }
        }
    }
}
