using System;

namespace _04WHILE_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE

            Console.Write("START!, press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("press y again to continue: ");
                answer = Console.ReadLine();
            }
            Console.WriteLine("END");


            //guessing game
            /*Random r = new Random();
            int number = r.Next(1, 20);

            Console.Write("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            while (guess != number && counter < 10)
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            Console.WriteLine($"End of the game, the number was {number}");*/


            //sequence printing: 3 9 27 81 ... Int16.MaxValue
            Console.WriteLine("\nSequence 1: 3 9 27 81...");
            int i = 3;

            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= 3; //i = i * 3
            }


            //importance of order of code
            //beware, because the last number exceeds the actual sequence max and starts at 9
            Console.WriteLine("\nSequence 2: 3 9 27 81...");
            i = 3;

            while (i < Int16.MaxValue)
            {
                i *= 3; //i = i * 3
                Console.Write(i + " ");
            }



            Console.WriteLine("\nSequence 3: ");
            int x = Convert.ToInt32(Console.ReadLine());
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }


            //do while will always execute or loop at least 1 time
            //order of your code is still important
            Console.WriteLine("\nSequence 3: ");
            x = Convert.ToInt32(Console.ReadLine());
            i = x;
            do
            {
                Console.Write(i + " ");
                i *= x;
            } while (i < Int16.MaxValue);


            //order of your code is still important
            Console.WriteLine("\nSequence 3: ");
            x = Convert.ToInt32(Console.ReadLine());
            i = x;
            do
            {
                i *= x;
                Console.Write(i + " ");
            } while (i < Int16.MaxValue);
        }
    }
}
