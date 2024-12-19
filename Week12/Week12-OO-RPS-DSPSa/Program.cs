using System;

namespace Week12_OO_RPS_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPS game = new RPS();
            Console.WriteLine($"Rock, Paper or Scissor");
            string answer = Console.ReadLine();

            while (answer != "I am done!")
            {
                string result;
                switch (answer)
                {
                    case "Rock":
                        game.MyChoice = (Choice)0;
                        result = game.Round();
                        Console.WriteLine(result);
                        break;
                    case "Paper":
                        game.MyChoice = (Choice)1;
                        result = game.Round();
                        Console.WriteLine(result);
                        break;
                    case "Scissor":
                        game.MyChoice = (Choice)2;
                        result = game.Round();
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Try again, this is not a valid option");
                        break;

                }
                Console.WriteLine(game);
                answer = Console.ReadLine();
            }

            Console.WriteLine($"Final result: {game}");
        }
    }
}
