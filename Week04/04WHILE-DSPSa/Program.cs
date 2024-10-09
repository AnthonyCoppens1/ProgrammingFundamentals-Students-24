using System;
using System.ComponentModel.DataAnnotations;

namespace _04WHILE_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            Console.Write("START! press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("press y to continue again: ");
                answer = Console.ReadLine();
            }




            Console.WriteLine("Provide your password: ");
            string password = Console.ReadLine();

            while (password != "LAPTOPCHARGER")
            {
                Console.WriteLine("Wrong password, try again: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Good job, you have logged in.");



            //random number game
            /*Random random = new Random();
            int number = random.Next(1, 20);

            Console.Write("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            while (number != guess && counter < 10)
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            Console.WriteLine("Congratulations: you've guess correctly");
            Console.WriteLine($"{number} was the correct number");*/


            //sequence 3 9 81 273 ... --> Int16.MaxValue
            Console.WriteLine("\nsequence 3 9 81 ...");
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i = i * i;
            }

            //importance of order of statements
            // 3 9 27 81 ...
            Console.Write("\nEnter a number x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nsequence 1");
            i = x;

            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }


            Console.WriteLine("\nsequence 2");
            i = x;

            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }



            //do while: will always loop at least 1 time
            //order of statements is also important

            Console.WriteLine("\nsequence 3");
            i = x;
            do
            {
                Console.Write(i + " ");
                i *= x;
            } while (i < Int16.MaxValue);



            //order of statements is also important

            Console.WriteLine("\nsequence 4");
            i = x;
            do
            {
                i *= x;
                Console.Write(i + " ");
            } while (i < Int16.MaxValue);
        }
    }
}
